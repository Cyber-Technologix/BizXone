Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraData

Public Class frmWarehouse
    Dim dtProducts As DataTable
    Dim tableModule As XtraTableModule
    Dim dtGridSource As New DataTable

    Dim FieldName As String
    Dim DocID As Integer, PrintID As Long
    Dim total As Decimal = 0

    Private semaphore As New SemaphoreSlim(1)
    Private timer As New System.Windows.Forms.Timer() With {.Interval = 1000}


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        timer.Start()
        AddHandler timer.Tick, AddressOf Me.OnTimerTick

        DocID = Convert.ToInt16(Program.DocKind)


        tableModule = New XtraTableModule(spnTransactionID, "TransactionID") With {.Container = LayoutMain, .isMasterDetail = True, .Grid = GridMain, .GridSourceDataTable = dtGridSource, .DocID = DocID, .PeriodID = ProjectResources.ActivePeriodID, .UserID = XtraAuthenticator.UserID}

        tableModule.SetModuleInitializer(LayoutMain)

        dtProducts = DBManger.XtraLoadDataTable("SELECT * FROM tblProducts")
        Navigator.MergeCommandRibbon(CommandRibbon)

        scanner.Start()

        AddHandler scanner.BarcodeScanned, Sub(frmInventory, args)

                                               txtBarcode.Clear()
                                               txtBarcode.Text = args.Barcode
                                               GetProductBarcode(args.Barcode)
                                           End Sub
    End Sub

    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        ActivateModule().ConfigureAwait(False)
    End Sub

    Private Sub spnTransactionID_Leave(sender As Object, e As EventArgs) Handles spnTransactionID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If Not DBManger.isFetchedRecord(tableModule) Then
            dtEntryDate.DateTime = DateTime.Now
            DBManger.AutoNumber(spnTransactionID, tableModule)
        Else
            DBManger.XtraSaveGridData(GridCommand.SelectCommand, GridMain, dtGridSource, String.Format("tblWarehouseInventoryDetail Where TransactionID={0}", spnTransactionID.EditValue))
            PrintID = spnTransactionID.EditValue
        End If
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraLoadDropDownData(cmbWarehouse, "WarehouseID", "WarehouseName", "tblWarehouse")
        DBManger.XtraLoadDropDownData(cmbTransfer, "WarehouseID", "WarehouseName", "tblWarehouse")
        DBManger.XtraLoadGridDropDown(DropDownProdName, "ProductID", "ProductName", "vwProductDropdown")
    End Sub
    Private Sub GridMainView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridMainView.CellValueChanged

        If String.IsNullOrEmpty(GridMainView.GetRowCellValue(e.RowHandle, "ProductID").ToString) Then Exit Sub

        Dim ID = Convert.ToInt64(GridMainView.GetRowCellValue(e.RowHandle, "ProductID"))
        Dim selectedRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Int64)("ProductID") = ID)

        If selectedRow IsNot Nothing Then
            Dim equalToUnit = selectedRow.Field(Of Int16)("EqualToUnit")

            Select Case e.Column.VisibleIndex

                Case 4
                    'GridMainView.SetRowCellValue(e.RowHandle, "QTY_Pack", Val(e.Value / equalToUnit))
                    GridMainView.SetFocusedRowCellValue("QTY_Pack", Val(e.Value / equalToUnit))
            End Select
        End If
        GridMainView.UpdateCurrentRow()
        GridMainView.UpdateTotalSummary()
    End Sub
    Private Sub GridMainView_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridMainView.FocusedColumnChanged
        'MsgBox(GridMainView.GetFocusedValue())

        If GridMainView.RowCount.Equals(0) Then Exit Sub
        If String.IsNullOrEmpty(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "ProductID").ToString) Then Exit Sub

        Dim ID = Convert.ToInt64(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "ProductID"))
        Dim selectedRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Int64)("ProductID") = ID)
        Dim PQ As Decimal = 0

        If selectedRow IsNot Nothing Then
            ' Use the foundRow for further processing, such as getting values 
            Dim equalToUnit = selectedRow.Field(Of Int16)("EqualToUnit")

            Select Case e.FocusedColumn.VisibleIndex

                Case 3

                    If GridMainView.GetFocusedValue() > 0 And equalToUnit > 0 Then
                        PQ = Val(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "Quantity") / equalToUnit)
                        GridMainView.SetRowCellValue(GridMainView.FocusedRowHandle, "QTY_Pack", PQ)
                    End If

                Case 4
                    Dim kk = GridMainView.GetFocusedValue()
                    If GridMainView.GetFocusedValue() > 0 And equalToUnit > 0 Then
                        PQ = Val(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "QTY_Pack") * equalToUnit)
                        GridMainView.SetRowCellValue(GridMainView.FocusedRowHandle, "Quantity", PQ)
                    End If


            End Select

        End If
        GridMainView.UpdateCurrentRow()
        GridMainView.UpdateTotalSummary()
    End Sub

    Private Sub frmSales_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        cmbWarehouse.Properties.PopupFormWidth = cmbWarehouse.Width
        cmbTransfer.Properties.PopupFormWidth = cmbTransfer.Width

    End Sub

    Private Sub txtBarcode_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtBarcode.ButtonClick

        'Dim ID = Convert.ToInt64(New Random().Next(1, 500))

        Select Case e.Button.Index
            Case 0
                Dim ProductRow As DataRow = ProjectResources.GetProductData(cmbWarehouse.EditValue)
                If ProductRow IsNot Nothing Then AddNewItemDataRow(ProductRow)
        End Select
    End Sub
    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Select Case e.Item.Id
            'CalculateItems()

            Case 101 'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    dtGridSource.AsEnumerable.ForEach(Sub(row) row.Item("EXPDate") = Convert.ToDateTime(row.Item("EXPDate")).SetLastDayOfMonth)

                    PrintID = spnTransactionID.Value
                    DBManger.SaveRecord(tableModule)
                    DBManger.XtraLoadGridDropDown(DropDownProdName, "ProductID", "ProductName", "vwProductDropdown")
                    spnTransactionID.Focus()
                    spnTransactionID_Leave(sender, e)
                End If

            Case 102 'Delete Command
                'DeleteRecord()

            Case 103 'Refresh Command
                DBManger.XtraFormRefresh(LayoutMain, Color.Maroon)
                spnTransactionID.Focus()
                spnTransactionID_Leave(sender, e)

            Case 104 'Close Command
                scanner.StopScanner()
                Navigator.ShowDashboard(GetType(MdiDashboard))

            Case 106 'Preview & Print Command
                DBManger.ShowRibbonReport(Navigator, New rptMerchandiseSlip, String.Format("Select * from vwInventory Where TransactionID={0}", PrintID), False)

            Case 107 'Preview & Print Command
                DBManger.ShowRibbonReport(Navigator, New rptMerchandiseSlip, String.Format("Select * from vwInventory Where TransactionID={0}", PrintID), True)

            Case 31 'Show Holds and Invoices
                ShowInvoiceAsEditable(e.Item.Id)

        End Select
    End Sub

    Private Sub GetProductBarcode(BarCode As String)
        Dim ProductRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Item("Barcode") = BarCode)

        If ProductRow IsNot Nothing Then
            AddNewItemDataRow(ProductRow)
        Else
            txtBarcode.Text = "Product not found or invalid code!"
        End If

    End Sub
    Private Sub AddNewItemDataRow(ByVal AddNewRow As DataRow)

        Dim ID = Convert.ToInt64(New Random().Next(1, 501))

        Dim ProductRow As DataRow = dtGridSource.AsEnumerable().FirstOrDefault(Function(row) row.Item("ProductID") = AddNewRow.Item("ProductID"))
        If ProductRow IsNot Nothing Then
            dtGridSource.AsEnumerable().Where(Function(x) x.Item("ProductID") = AddNewRow.Item("ProductID")).ForEach(Sub(row)
                                                                                                                         row.SetField("Quantity", row.Item("Quantity") + 1)
                                                                                                                         row.SetField("QTY_Pack", row.Item("Quantity") / AddNewRow.Item("EqualToUnit"))
                                                                                                                     End Sub)
            Exit Sub
        End If

        If AddNewRow IsNot Nothing Then
            ' Use the foundRow for further processing, such as getting values 
            Dim barcode = AddNewRow.Item("Barcode")
            Dim ProdID = AddNewRow.Item("ProductID")
            Dim equalToUnit = AddNewRow.Item("EqualToUnit")
            Dim Expiry = If(IsDBNull(AddNewRow.Item("EXPDate")), Date.Now.AddYears(1).SetLastDayOfMonth, AddNewRow.Item("EXPDate"))

            AddHandler GridMainView.InitNewRow, Sub(s, e)

                                                    Dim view As GridView = TryCast(s, GridView)
                                                    ' Set the new row cell value.
                                                    view.SetRowCellValue(e.RowHandle, "TransactionID", spnTransactionID.EditValue)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("Barcode"), barcode)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("ProductID"), ProdID)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("EXPDate"), Expiry)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("Quantity"), equalToUnit)
                                                    view.SetRowCellValue(e.RowHandle, "QTY_Pack", 1)

                                                End Sub

        End If

        GridMainView.AddNewRow()
        GridMainView.UpdateCurrentRow()
    End Sub

    Private Sub ShowInvoiceAsEditable(commdID As Integer)
        Dim TransactionID As Long = ProjectResources.GetInvoiceSearch(DocID, If(commdID.Equals(31), True, False))
        If DBManger.isFetchedRecord(LayoutMain, "TransactionID", TransactionID) Then
            DBManger.XtraSaveGridData(GridCommand.SelectCommand, GridMain, dtGridSource, String.Format("tblInventoryDetail Where TransactionID={0}", TransactionID))
            PrintID = TransactionID
        End If
    End Sub

    Private Async Function ActivateModule() As Task

        Dim res As Boolean = Await semaphore.WaitAsync(10)
        If Not res Then Return
        Try

            btnPrint.Enabled = If(PrintID.Equals(0), False, True)
            btnPreview.Enabled = If(PrintID.Equals(0), False, True)

        Finally

            semaphore.Release()
        End Try

    End Function



End Class