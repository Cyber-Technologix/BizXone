Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraData

Public Class frmInventory
    Dim dtProducts As DataTable
    Dim tableModule As XtraTableModule
    Dim dtGridSource As New DataTable

    Dim FieldName As String
    Dim DocID As Integer, TransactionID As Long
    Dim total As Decimal = 0, PackQTY As Decimal = 0

    Private semaphore As New SemaphoreSlim(1)
    Private timer As New System.Windows.Forms.Timer() With {.Interval = 1000}
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        timer.Start()
        AddHandler timer.Tick, AddressOf Me.OnTimerTick

        DocID = Convert.ToInt16(Program.DocKind)
        FieldName = String.Format("DocID={0} AND InventoryID", DocID)

        tableModule = New XtraTableModule(spnInventoryID, FieldName) With {.Container = LayoutMain, .isMasterDetail = True, .Grid = GridMain, .GridSourceDataTable = dtGridSource, .DocID = DocID, .PeriodID = ProjectResources.ActivePeriodID, .UserID = XtraAuthenticator.UserID}
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
    Private Sub AddNewRecord()
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If DBManger.isFetchedRecord(tableModule) Then
            TransactionID = DBManger.XtraTableColumnValue("TransactionID", String.Format("tblInventory Where InventoryID={0}", TransactionID))
        Else
            dtEntryDate.DateTime = DateTime.Now
            spnInventoryID.EditValue = XtraAutoNumber.GetUniqueAutoID()
        End If
        txtBarcode.Focus()
        'imgBarcodeID.ShowBarcode(InventoryID.ToString, DevExpress.BarCodes.Symbology.PDF417)
    End Sub

    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraLoadDropDownData(cmbClient, "ClientID", "ClientName", "vwClients WHERE StatusID=1 AND ClientHeadID IN (2,3)")
        DBManger.XtraLoadDropDownData(cmbWarehouse, "WarehouseID", "WarehouseName", "tblWarehouse")
        DBManger.XtraLoadGridDropDown(DropDownProdName, "ProductID", "ProductName", "vwProductDropdown")
        AddNewRecord()
    End Sub
    Private Sub GridMainView_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GridMainView.CustomDrawFooterCell
        total = (Convert.ToDecimal(GridMainView.Columns("Total").SummaryItem.SummaryValue))
        spnTotalAmount.Value = Val(total - spnNetDiscount.Value)
    End Sub
    Private Sub GridMainView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridMainView.CellValueChanged

        If GridMainView.RowCount.Equals(0) Then Exit Sub
        If String.IsNullOrEmpty(GridMainView.GetRowCellValue(e.RowHandle, "ProductID").ToString) Then Exit Sub

        Dim ID = Convert.ToInt64(GridMainView.GetRowCellValue(e.RowHandle, "ProductID"))
        Dim selectedRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Int64)("ProductID") = ID)

        If selectedRow IsNot Nothing Then
            Dim equalToUnit = selectedRow.Field(Of Int16)("EqualToUnit")

            Select Case e.Column.VisibleIndex
                Case 6
                    'GridMainView.SetRowCellValue(e.RowHandle, "QTY_Pack", Val(e.Value / equalToUnit))
                    GridMainView.SetFocusedRowCellValue("QTY_Pack", Val(e.Value / equalToUnit))
            End Select
        End If

        GridMainView.UpdateCurrentRow()
        GridMainView.UpdateTotalSummary()
    End Sub
    Private Sub GridMainView_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridMainView.FocusedColumnChanged

        If GridMainView.RowCount.Equals(0) Then Exit Sub
        If String.IsNullOrEmpty(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "ProductID").ToString) Then Exit Sub

        Dim ID = Convert.ToInt64(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "ProductID"))
        Dim selectedRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Field(Of Int64)("ProductID") = ID)
        Dim PQ As Decimal = 0


        If selectedRow IsNot Nothing Then
            ' Use the foundRow for further processing, such as getting values 
            Dim equalToUnit = selectedRow.Field(Of Int16)("EqualToUnit")

            Select Case e.FocusedColumn.VisibleIndex

                Case 5
                    If GridMainView.GetFocusedValue() > 0 And equalToUnit > 0 Then
                        PQ = Val(GridMainView.GetRowCellValue(GridMainView.FocusedRowHandle, "Quantity") / equalToUnit)
                        GridMainView.SetRowCellValue(GridMainView.FocusedRowHandle, "QTY_Pack", PQ)
                    End If

                Case 6
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
    Private Sub txtBarcode_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtBarcode.ButtonClick

        Select Case e.Button.Index
            Case 0
                Dim ProdID = ProjectResources.GetAllProductData()
                If Not ProdID.Equals(0) Then AddNewItemRow(ProdID)
                'txtBarcode.EditValue = dtProducts.AsEnumerable().Where(Function(row) row.Item("ProductID") = ID).FirstOrDefault.Item("Barcode").ToString

        End Select
    End Sub
    Private Sub imgItems_EditValueChanged(sender As Object, e As EventArgs) Handles imgItems.EditValueChanged
        If imgItems.Image Is Nothing Then imgItems.Image = My.Resources.Resources.NoImage
    End Sub

    Private Sub spnDiscount_Per_EditValueChanged(sender As Object, e As EventArgs) Handles spnDiscount_Per.EditValueChanged
        spnNetDiscount.Value = Val(Format(total * spnDiscount_Per.Value / 100, "#.00"))
    End Sub

    Private Sub spnDiscount_Rs_EditValueChanged(sender As Object, e As EventArgs) Handles spnNetDiscount.EditValueChanged

        'spnDiscount_Per.Value = Format(Val(spnDiscount_Rs.Value / total) * 100, "#.00")
        spnTotalAmount.Value = Val(total - spnNetDiscount.Value)

    End Sub
    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Select Case e.Item.Id

            Case 101, 105 'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    dtGridSource.AsEnumerable.ForEach(Sub(row) row.Item("EXPDate") = Convert.ToDateTime(row.Item("EXPDate")).SetLastDayOfMonth)
                    TransactionID = DBManger.XtraTableColumnValue("TransactionID", String.Format("tblInventory Where InventoryID={0}", spnInventoryID.Value))
                    DBManger.SaveRecord(tableModule)
                    DBManger.XtraExecuteSQLQuery(String.Format("UPDATE tblInventory SET isHold={0} Where TransactionID={1}", If(e.Item.Id.Equals(105), 1, 0), TransactionID))
                    AddNewRecord()
                End If

            Case 102 'Delete Command
                'DeleteRecord()

            Case 103 'Refresh Command
                DBManger.XtraFormRefresh(LayoutMain, Color.Maroon)
                AddNewRecord()

            Case 104 'Close Command
                scanner.StopScanner()
                Navigator.ShowDashboard(GetType(MdiDashboard))

            Case 106, 107 'Preview Command
                DBManger.ShowRibbonReport(Navigator, New rptInventorySlip, String.Format("Select * from vwInventory Where TransactionID={0}", TransactionID), If(e.Item.Id.Equals(107), True, False))


            Case 32, 33 'Show Holds and Invoices
                ShowInvoiceAsEditable(e.Item.Id)

        End Select
    End Sub

    Private Sub GetProductBarcode(Barcode As String)
        Dim ProductRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Item("Barcode") = Barcode)

        If ProductRow IsNot Nothing Then
            Dim ProdID = ProductRow.Item("ProductID")
            AddNewItemRow(ProdID)
        Else
            txtBarcode.Text = "Product not found or invalid code!"
        End If
    End Sub
    Private Sub AddNewItemRow(ByVal ProductID As Integer)

        Dim ID = Convert.ToInt64(New Random().Next(1, 501))
        Dim AddNewRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Item("ProductID") = ProductID)

        Dim ProductRow As DataRow = dtGridSource.AsEnumerable().FirstOrDefault(Function(row) row.Item("ProductID") = AddNewRow.Item("ProductID"))

        If ProductRow IsNot Nothing Then
            dtGridSource.AsEnumerable().Where(Function(x) x.Item("ProductID") = AddNewRow.Item("ProductID")).ForEach(Sub(row)
                                                                                                                         row.SetField("Quantity", row.Item("Quantity") + AddNewRow.Item("EqualToUnit"))
                                                                                                                         row.SetField("QTY_Pack", row.Item("Quantity") / AddNewRow.Item("EqualToUnit"))
                                                                                                                     End Sub)
            Exit Sub
        End If


        If AddNewRow IsNot Nothing Then
            ' Use the foundRow for further processing, such as getting values 
            Dim barcode = AddNewRow.Item("Barcode")
            Dim ProdID = AddNewRow.Item("ProductID")
            Dim unitPrice = AddNewRow.Item("UnitCost")
            Dim equalToUnit = AddNewRow.Item("EqualToUnit")
            Dim Expiry = Date.Now.AddYears(1).SetLastDayOfMonth

            AddHandler GridMainView.InitNewRow, Sub(s, e)
                                                    Dim view As GridView = TryCast(s, GridView)
                                                    ' Set the new row cell value.
                                                    view.SetRowCellValue(e.RowHandle, "InventoryID", spnInventoryID.EditValue)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("Barcode"), barcode)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("ProductID"), ProdID)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("EXPDate"), Expiry)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("Rate"), unitPrice)
                                                    view.SetRowCellValue(e.RowHandle, view.Columns("Quantity"), equalToUnit)
                                                    view.SetRowCellValue(e.RowHandle, "QTY_Pack", 1)
                                                    view.SetRowCellValue(e.RowHandle, "Discount", 0)

                                                End Sub

        End If

        GridMainView.AddNewRow()
        GridMainView.UpdateCurrentRow()
    End Sub
    Private Sub ShowInvoiceAsEditable(commdID As Integer)
        Dim TransactionID As Long = ProjectResources.GetInvoiceSearch(DocID, If(commdID.Equals(32), True, False))
        If DBManger.isFetchedRecord(LayoutMain, "TransactionID", TransactionID) Then
            DBManger.XtraSaveGridData(GridCommand.SelectCommand, GridMain, dtGridSource, String.Format("tblInventoryDetail Where TransactionID={0}", TransactionID))
            Me.TransactionID = TransactionID
        End If
    End Sub
    Private Sub cmbClient_BeforePopup(sender As Object, e As EventArgs) Handles cmbClient.BeforePopup
        cmbClient.PopupBestFit
    End Sub
    Private Sub cmbClient_EditValueChanged(sender As Object, e As EventArgs) Handles cmbClient.EditValueChanged
        Dim ClientID As Integer = If(String.IsNullOrEmpty(cmbClient.EditValue), 0, cmbClient.EditValue)

        If Not ClientID.Equals(0) Then
            spnClientBalance.Value = XtraHelper.HandleNullValue(DBManger.XtraTableColumnValue("Balance", String.Format("tblClients Where ClientID={0}", ClientID)), 0)
        End If
    End Sub
    Private Async Function ActivateModule() As Task

        Dim res As Boolean = Await semaphore.WaitAsync(10)
        If Not res Then Return
        Try
            Select Case Program.DocKind
                Case 1
                    lblTitle.Text = "Purchase".ToUpper
                    rptInventorySlip.ReportName = "CREDIT NOTE (Purchase)"
                Case 2
                    lblTitle.Text = "Purchase Return".ToUpper
                    rptInventorySlip.ReportName = "DEBIT NOTE (Purchase Return)"
            End Select
            btnPrint.Enabled = If(TransactionID.Equals(0), False, True)
            btnPreview.Enabled = If(TransactionID.Equals(0), False, True)

        Finally

            semaphore.Release()
        End Try

    End Function

End Class