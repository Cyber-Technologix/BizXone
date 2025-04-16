Imports DevExpress.XtraEditors

Public Class rfrmHeadBalance


    Private Sub rfrmAccountHeadBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(CmbAccountHeads, "AccountTypeID", "AccountTypeName", "tblAccountTypes where AccountTypeID not in(24) Order by AccountTypeName")

    End Sub


    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        rptHeadWiseBalance.ReportPeriod = "For the Period Ended on " '& dtEndDate.DateTime.ToShortDateString

        'If CN.XtraShowRequiredError(MainLayout, Color.Blue, "Empty or Null not allowed") Then Exit Sub
        Try
            Dim Query As String = String.Format("SELECT * FROM udfAccountsBalanceSheet() WHERE AccountTypeID IN({0})", CmbAccountHeads.EditValue)

            DBManger.ShowRibbonReport(Navigator, New rptHeadWiseBalance, Query, If(e.Item.Id.Equals(2), True, False))
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub

End Class