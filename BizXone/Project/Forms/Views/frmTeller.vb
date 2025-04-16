Imports System.Threading
Imports System.Threading.Tasks
Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class frmTeller
    Dim DocID As Integer = 9
    Dim PrintID As Integer
    Dim TransactionDocID As Integer
    Dim tableModule As XtraTableModule

    Private spnDebit As New SpinEdit With {.ForeColor = Color.Black, .Tag = "Debit"}
    Private spnCredit As New SpinEdit With {.ForeColor = Color.Black, .Tag = "Credit"}
    Private spnTellerID As New SpinEdit With {.ForeColor = Color.Maroon, .Tag = "TellerID"}
    Dim ViewQuery As String = String.Format("SELECT * FROM vwTellerTransactions")

    Private semaphore As New SemaphoreSlim(1)
    Private timer As New System.Windows.Forms.Timer() With {.Interval = 1000}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        timer.Start()
        AddHandler timer.Tick, AddressOf Me.OnTimerTick

        LayoutMain.AddItem("TellerID :", spnTellerID).Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutMain.AddItem("Debit :", spnDebit).Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        LayoutMain.AddItem("Credit :", spnCredit).Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

        tableModule = New XtraTableModule(txtID, "TransactionID") With {.Container = LayoutMain, .DocID = DocID, .PeriodID = ProjectResources.ActivePeriodID, .UserID = XtraAuthenticator.UserID}
        tableModule.SetModuleInitializer(LayoutMain)

        scanner.Start()
        AddHandler scanner.BarcodeScanned, Sub(frmInventory, args)
                                               txtBarcode.Clear()
                                               txtBarcode.Text = args.Barcode
                                               GetMerchandiseData(Convert.ToInt64(args.Barcode))
                                           End Sub
        Navigator.MergeCommandRibbon(CommandRibbon)
    End Sub
    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        ActivateModule().ConfigureAwait(False)
    End Sub

    Private Sub frmTeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshView(sender, e)
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If Not DBManger.isFetchedRecord(tableModule) Then
            dtEntryDate.DateTime = DateTime.Now
            DBManger.AutoNumber(txtID, tableModule)
            ProjectResources.GetDefaultTeller(spnTellerID)
        End If
    End Sub
    Private Sub txtBarcode_Leave(sender As Object, e As EventArgs) Handles txtBarcode.Leave

        GetMerchandiseData(txtBarcode.EditValue)
        spnPaidCash.EditValue = spnBillAmount.Value
    End Sub
    Private Sub txtBarcode_EditValueChanged(sender As Object, e As EventArgs) Handles txtBarcode.EditValueChanged
        If txtBarcode.EditValue Is Nothing Then
            GridView.ActiveFilter.Clear()
        Else
            GridView.ActiveFilterString = "[InventoryID] LIKE '%" & txtBarcode.EditValue.ToString & "%'"
        End If
    End Sub
    Private Sub spnPaidCash_EditValueChanged(sender As Object, e As EventArgs) Handles spnPaidCash.EditValueChanged
        spnChange.Value = Val(spnPaidCash.Value - spnBillAmount.Value)
    End Sub
    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick

        Try
            Select Case e.Item.Id

                Case 101 'Save Command
                    If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                        UpdateInventory()
                        If chkCredited.Checked = False Then DBManger.SaveRecord(tableModule)
                        RefreshView(sender, e)
                        txtBarcode.Focus()
                    End If

                Case 102 'Delete Command

                Case 103 'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain, Color.Maroon)
                    RefreshView(sender, e)

                Case 22 'Close Command
                    scanner.StopScanner()
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 201 'Preview Command
                    DBManger.ShowRibbonReport(Navigator, New rptMerchandiseSlip, String.Format("Select * from vwInventory Where TransactionID={0}", PrintID), If(e.Item.Id.Equals(202), True, False))

            End Select
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
        End Try
    End Sub
    Private Sub GetMerchandiseData(Barcode As Long)
        Dim obj As List(Of DataRow) = DBManger.XtraLoadDataTable(String.Format("SELECT TransactionID,DocID,FBRCode,NetValue,isCredited FROM tblInventory WHERE InventoryID={0}", Barcode)).AsEnumerable.ToList
        If Not obj.Any Then Exit Sub
        PrintID = obj(0).ItemArray(0)
        TransactionDocID = obj(0).ItemArray(1)
        txtFBRID.EditValue = obj(0).ItemArray(2)
        spnBillAmount.EditValue = obj(0).ItemArray(3)
        chkCredited.EditValue = obj(0).ItemArray(4)

        spnDebit.EditValue = If(TransactionDocID.Equals(3), obj(0).ItemArray(3), 0)
        spnCredit.EditValue = If(TransactionDocID.Equals(4), obj(0).ItemArray(3), 0)

    End Sub
    Private Sub UpdateInventory()
        If POS_transaction.SendFBRTransaction(ProjectResources.POSID, txtBarcode.EditValue) Then txtFBRID.EditValue = POS_transaction.FBRResponse.InvoiceNumber
        Dim PaymentMode As String = If(spnCredit.Value > 0, String.Format("Debit={0},", spnBillAmount.Value), String.Format("Credit={0},", spnBillAmount.Value))
        If chkCredited.Checked Then PaymentMode = String.Empty
        Dim Query = String.Format("UPDATE tblInventory SET {0} FBRCode='{1}',isCredited={2} WHERE InventoryID={3}", PaymentMode, txtFBRID.EditValue, Convert.ToInt16(chkCredited.EditValue), txtBarcode.EditValue)
        PrintID = DBManger.XtraTableColumnValue("TransactionID", String.Format("tblInventory Where InventoryID={0}", Convert.ToInt64(txtBarcode.EditValue)))
        DBManger.XtraExecuteSQLQuery(Query)
    End Sub

    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadData(GridMain, ViewQuery)
    End Sub
    Private Async Function ActivateModule() As Task

        Dim res As Boolean = Await semaphore.WaitAsync(10)
        If Not res Then Return
        Try

            Select Case TransactionDocID

                Case 3
                    rptMerchandiseSlip.ReportName = "Merchandise Sale"

                Case 4
                    rptMerchandiseSlip.ReportName = "Merchandise Return"
            End Select


            btnPrint.Enabled = If(PrintID.Equals(0), False, True)
            btnPreview.Enabled = If(PrintID.Equals(0), False, True)

        Finally

            semaphore.Release()
        End Try

    End Function

End Class