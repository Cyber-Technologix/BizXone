Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmAccountLedger


    Private Sub rformAccountLegder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now
        DBManger.XtraLoadDropDownData(cmbAccounts, "AccountID", "AccountName", "tblAccounts")
    End Sub


    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        Dim D1 As String = dtStartDate.DateTime.ToShortDateString()
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString()

        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub
        'If CN.XtraShowRequiredError(MainLayout, Color.Blue, "Empty or Null not allowed") Then Exit Sub

        rptAccountLedger.OpeningBalanceDate = D1
        rptAccountLedger.ReportPeriod = "From:   " & D1 & "   To:   " & D2

        Try
            Dim Query As String = "Select * from vwAccountsLedger where AccountID='" & cmbAccounts.EditValue & "' And EntryDate >= '" & D1 & "' And EntryDate <= '" & D2 & "'"

            DBManger.ShowRibbonReport(Navigator, New rptAccountLedger, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub

    Private Sub cmbAccounts_BeforePopup(sender As Object, e As EventArgs) Handles cmbAccounts.BeforePopup
        cmbAccounts.PopupBestFit
    End Sub
End Class