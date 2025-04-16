Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class frmExpense
    Dim DocID As Integer = 5
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = String.Format("SELECT * FROM vwAccountsLedger WHERE DocID={0} AND EntryDate= (SELECT Max(EntryDate) FROM vwAccountsLedger WHERE DocID={0})", DocID)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "TransactionID") With {.Container = LayoutMain, .DocID = DocID, .PeriodID = ProjectResources.ActivePeriodID, .UserID = XtraAuthenticator.UserID}
        tableModule.SetModuleInitializer(LayoutMain)

        Navigator.MergeCommandRibbon(CommandRibbon)
    End Sub

    Private Sub frmAccountTransation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraLoadDropDownData(cmbAccounts, "AccountID", "AccountName", "vwAccounts where AccountTypeID NOT IN(24)")
        DBManger.XtraLoadDropDownData(cmbCash, "AccountID", "AccountName", "vwAccounts where AccountTypeID NOT IN(24)")
        'DatabaseManger.XtraGridAutoUpdateAsync(GridMain, ViewQuery, 3)
        RefreshView(sender, e)
    End Sub

    Private Sub TxtDebit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebit.EditValueChanged
        txtCredit.Properties.ReadOnly = IIf(txtDebit.EditValue <> 0, True, False)
    End Sub

    Private Sub TxtCredit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCredit.EditValueChanged
        txtDebit.Properties.ReadOnly = If(txtCredit.EditValue <> 0, True, False)
    End Sub

    Private Sub frmAccountTransation_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        cmbAccounts.Properties.PopupFormWidth = cmbAccounts.Width
        cmbCash.Properties.PopupFormWidth = cmbCash.Width
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If Not DBManger.isFetchedRecord(tableModule) Then
            dtEntryDate.DateTime = DateTime.Now
            DBManger.AutoNumber(txtID, tableModule)
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

                Case 102 'Delete Command

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

    Private Sub cmbAccounts_BeforePopup(sender As Object, e As EventArgs) Handles cmbAccounts.BeforePopup
        cmbAccounts.PopupBestFit
    End Sub

    Private Sub cmbCash_BeforePopup(sender As Object, e As EventArgs) Handles cmbCash.BeforePopup
         cmbCash.PopupBestFit
    End Sub
End Class