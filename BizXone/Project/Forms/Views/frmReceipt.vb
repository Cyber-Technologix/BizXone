Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class frmReceipt
    Dim DocID As Integer = 7
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = String.Format("SELECT * FROM vwClientLedger WHERE DocID={0} AND EntryDate= (SELECT Max(EntryDate) FROM vwClientLedger WHERE DocID={0})", DocID)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim fieldName = String.Format("DocID={0} AND TransactionID", DocID)
        tableModule = New XtraTableModule(txtID, fieldName) With {.Container = LayoutMain, .DocID = DocID, .PeriodID = ProjectResources.ActivePeriodID, .UserID = XtraAuthenticator.UserID}
        tableModule.SetModuleInitializer(LayoutMain)
        Navigator.MergeCommandRibbon(CommandRibbon)
    End Sub

    Private Sub frmPaymentReceipts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        DBManger.XtraLoadDropDownData(cmbClient, "ClientID", "ClientName", "vwClients ")
        DBManger.XtraLoadDropDownData(cmbAccount, "AccountID", "AccountName", "vwAccounts")
        RefreshView(sender, e)
    End Sub

    Private Sub CmbAccount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim SP As String = If(IsDBNull(cmbAccount.EditValue), 0, cmbAccount.EditValue)
        txtAccountBal.Value = DBManger.XtraTableColumnValue("CurrentBalance", "tblAccounts WHERE AccountID='" & SP & "'")
    End Sub

    Private Sub CmbClient_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim SP As String = If(IsDBNull(cmbClient.EditValue), 0, cmbClient.EditValue)
        txtClientBal.Value = DBManger.XtraTableColumnValue("CurrentBalance", "tblClients WHERE ClientID='" & SP & "'")
    End Sub

    Private Sub frmPaymentsReceipts_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        cmbClient.Properties.PopupFormWidth = cmbClient.Width
        cmbAccount.Properties.PopupFormWidth = cmbAccount.Width
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If Not DBManger.isFetchedRecord(tableModule) Then
            dtEntryDate.DateTime = DateTime.Now
            DBManger.AutoNumber(txtID, "TransactionID", String.Format("tblClientTransactions WHERE  DocID={0}", DocID))
        End If

    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Try
            Select Case e.Item.Id

                Case 101 'Save Command
                    If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                        DBManger.SaveRecord(tableModule)
                        RefreshView(sender, e)
                    End If

                Case 103 'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain, Color.Maroon)
                    RefreshView(sender, e)

                Case 22 'Close Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 23, 24 'Print & Preview Command
                    XtraMessageBox.Show("The voucher is not available.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
    End Sub

    Private Sub cmbAccount_BeforePopup(sender As Object, e As EventArgs) Handles cmbAccount.BeforePopup
        cmbAccount.PopupBestFit
    End Sub

    Private Sub cmbClient_BeforePopup(sender As Object, e As EventArgs) Handles cmbClient.BeforePopup
        cmbClient.PopupBestFit
    End Sub
End Class