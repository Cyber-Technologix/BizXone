Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraData

Public Class frmMerchandise
    Dim dtProducts As DataTable
    Dim tableModule As XtraTableModule
    Dim dtGridSource As New DataTable

    Dim FieldName As String
    Dim DocID As Integer, TransactionID As Long
    Dim total As Decimal = 0, PackQTY As Decimal = 0

    Private semaphore As New SemaphoreSlim(1)
    Private timer As New Windows.Forms.Timer() With {.Interval = 1000}


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

        dtProducts = ProjectResources.LoadProductData(0)
        Navigator.MergeCommandRibbon(CommandRibbon)

        scanner.Start()

        AddHandler scanner.BarcodeScanned, Sub(frmInventory, args)

                                               txtBarcode.Clear()
                                               txtBarcode.Text = args.Barcode
                                               GetProductBarcode(args.Barcode)
                                           End Sub
    End Sub

    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
        ActivateModule().ConfigureAwait(False)
    End Sub
    Private Sub AddNewRecord()
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If DBManger.isFetchedRecord(tableModule) Then
            TransactionID = DBManger.XtraTableColumnValue("TransactionID", String.Format("tblInventory Where InventoryID={0}", TransactionID))
        Else

            dtEntryDate.DateTime = DateTime.Now
            spnInventoryID.EditValue = XtraAutoNumber.GetUniqueAutoID()
            cmbClient.EditValue = Convert.ToInt32(My.Settings.Item("setCustomerID"))
            cmbWarehouse.EditValue = Convert.ToInt32(My.Settings.Item("setWarehouseID"))
        End If

        txtBarcode.Focus()
        'imgBarcodeID.ShowBarcode(InventoryID.ToString, DevExpress.BarCodes.Symbology.PDF417)

    End Sub

    Private Sub frmSales_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(cmbClient, "ClientID", "ClientName", "vwClients WHERE StatusID=1 AND ClientHeadID IN (1,3)")
        DBManger.XtraLoadDropDownData(cmbWarehouse, "WarehouseID", "WarehouseName", "tblWarehouse")
        DBManger.XtraLoadGridDropDown(DropDownProdName, "ProductID", "ProductName", "vwProductDropdown")
        AddNewRecord()

    End Sub
    Private Sub GridMainView_CustomDrawFooterCell(ByVal sender As Object, ByVal e As FooterCellCustomDrawEventArgs) Handles GridMainView.CustomDrawFooterCell
        total = (Convert.ToDecimal(GridMainView.Columns("Total").SummaryItem.SummaryValue))
        spnTotalAmount.Value = Val(total - spnNetDiscount.Value)
    End Sub
    Private Sub GridMainView_CellValueChanged(ByVal sender As Object, ByVal e As CellValueChangedEventArgs) Handles GridMainView.CellValueChanged


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
    Private Sub GridMainView_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles GridMainView.FocusedColumnChanged
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

    Private Sub imgItems_EditValueChanged(sender As Object, e As EventArgs) Handles imgItems.EditValueChanged
        If imgItems.Image Is Nothing Then imgItems.Image = My.Resources.Resources.NoImage
    End Sub

    Private Sub spnDiscount_Per_EditValueChanged(sender As Object, e As EventArgs) Handles spnDiscount_Per.EditValueChanged
        spnNetDiscount.Value = Val(Format(total * spnDiscount_Per.Value / 100, "#.00"))
    End Sub

    Private Sub spnDiscount_Rs_EditValueChanged(sender As Object, e As EventArgs) Handles spnNetDiscount.EditValueChanged
        spnTotalAmount.Value = Val(total - spnNetDiscount.Value)
    End Sub
    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Select Case e.Item.Id
            'CalculateItems()

            Case 101, 105 'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    dtGridSource.AsEnumerable.ForEach(Sub(row) row.Item("EXPDate") = Convert.ToDateTime(row.Item("EXPDate")).SetLastDayOfMonth)
                    TransactionID = DBManger.XtraTableColumnValue("TransactionID", String.Format("tblInventory Where InventoryID={0}", spnInventoryID.EditValue))
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

            Case 106 'Preview & Print Command
                DBManger.ShowRibbonReport(Navigator, New rptMerchandiseSlip, String.Format("Select * from vwInventory Where TransactionID={0}", TransactionID), If(e.Item.Id.Equals(107), True, False))

            Case 108 'Print Command
                DBManger.ShowReportPreview(New rptPaymentToken, String.Format("Select * from vwInventory Where TransactionID={0}", TransactionID), True)

            Case 32, 33 'Show Holds and Invoices
                ShowInvoiceAsEditable(e.Item.Id)

        End Select
    End Sub

    Private Sub GetProductBarcode(Barcode As String)
        Dim ProductRow As DataRow = dtProducts.AsEnumerable().FirstOrDefault(Function(row) row.Item("Barcode") = Barcode)

        If ProductRow IsNot Nothing Then
            AddNewItemDataRow(ProductRow)
        Else
            txtBarcode.Text = "Product not found or invalid code!"
        End If
    End Sub
    Private Sub txtBarcode_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles txtBarcode.ButtonClick
        Select Case e.Button.Index

            Case 0
                Dim WarehouseID As Integer = If(rdgWarehouse.SelectedIndex.Equals(1), 0, cmbWarehouse.EditValue)
                Dim ProductRow As DataRow = ProjectResources.GetProductData(WarehouseID)
                If ProductRow IsNot Nothing Then AddNewItemDataRow(ProductRow)
        End Select
    End Sub
    Private Sub AddNewItemDataRow(ByVal AddNewRow As DataRow)


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
            Dim unitPrice = AddNewRow.Item("UnitPrice")
            Dim equalToUnit = AddNewRow.Item("EqualToUnit")
            Dim Expiry = If(IsDBNull(AddNewRow.Item("EXPDate")), Date.Now.AddYears(1), AddNewRow.Item("EXPDate"))

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

    Private Sub cmbClient_EditValueChanged(sender As Object, e As EventArgs) Handles cmbClient.EditValueChanged
        Dim CustomerID As Integer = If(String.IsNullOrEmpty(cmbClient.EditValue), 0, cmbClient.EditValue)

        If Not CustomerID.Equals(0) Then
            spnClientBalance.Value = XtraHelper.HandleNullValue(DBManger.XtraTableColumnValue("Balance", String.Format("tblClients Where ClientID={0}", CustomerID)), 0)
            My.Settings.Item("setCustomerID") = CustomerID
            My.Settings.Save()
        End If
    End Sub

    Private Sub cmbWarehouse_EditValueChanged(sender As Object, e As EventArgs) Handles cmbWarehouse.EditValueChanged
        Dim WarehouseID As Integer = If(String.IsNullOrEmpty(cmbWarehouse.EditValue), 0, cmbWarehouse.EditValue)
        If Not WarehouseID.Equals(0) Then
            My.Settings.Item("setWarehouseID") = WarehouseID
            My.Settings.Save()
        End If
    End Sub
    Private Sub cmbClient_BeforePopup(sender As Object, e As EventArgs) Handles cmbClient.BeforePopup
        cmbClient.PopupBestFit
    End Sub

    Private Async Function ActivateModule() As Task

        Dim res As Boolean = Await semaphore.WaitAsync(10)
        If Not res Then Return
        Try
            Select Case Program.DocKind

                Case 3
                    lblTitle.Text = "Merchandise Sale".ToUpper
                    rptMerchandiseSlip.ReportName = "Merchandise Sale"
                Case 4
                    lblTitle.Text = "Merchandise Return".ToUpper
                    rptMerchandiseSlip.ReportName = "Merchandise Return"
            End Select
            btnPrint.Enabled = If(TransactionID.Equals(0), False, True)
            btnPreview.Enabled = If(TransactionID.Equals(0), False, True)
            btnToken.Enabled = If(TransactionID.Equals(0), False, True)

        Finally

            semaphore.Release()
        End Try

    End Function

    Public Sub CalculateItems()

        Dim dtOriginal As DataTable = dtGridSource

        Dim dtFinal As DataTable = dtOriginal.Clone() ' Clone the structure of dtOriginal
        Dim groupedData = dtOriginal.AsEnumerable().GroupBy(Function(r)
                                                                Return New With {Key .TransactionID = r("TransactionID"), Key .InventoryID = r("InventoryID"), Key .ProductID = r("ProductID"), Key .Barcode = r("Barcode"), Key .Expired = r("Expired"), Key .Rate = r("Rate"), Key .TrNo = r("TrNo")}
                                                            End Function).Select(Function(x)
                                                                                     Dim row = dtOriginal.NewRow()
                                                                                     row("TransactionID") = x.Key.TransactionID
                                                                                     row("InventoryID") = x.Key.InventoryID
                                                                                     row("ProductID") = x.Key.ProductID
                                                                                     row("Barcode") = x.Key.Barcode
                                                                                     row("Expired") = x.Key.Expired
                                                                                     row("Rate") = x.Key.Rate
                                                                                     row("TrNo") = x.Key.TrNo
                                                                                     row("Quantity") = x.Sum(Function(r) Convert.ToInt64(r("Quantity")))
                                                                                     row("QTY_Pack") = x.Sum(Function(r) Convert.ToInt64(r("QTY_Pack")))
                                                                                     row("Dis_Rs") = x.Sum(Function(r) Convert.ToInt64(r("Dis_Rs")))
                                                                                     Return row
                                                                                 End Function).ToList


        ' Iterate through each group and build DataRow
        For Each gp As DataRow In groupedData

            ' Add the populated row to dtFinal
            dtFinal.Rows.Add(gp.ItemArray)
        Next

    End Sub


End Class