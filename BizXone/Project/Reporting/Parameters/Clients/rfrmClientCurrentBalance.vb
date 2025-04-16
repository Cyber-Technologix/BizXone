Imports DevExpress.XtraEditors

Public Class rfrmClientCurrentBalance


    Private Sub rfrmAccountTrialBalance_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtEndDate.DateTime = Date.Now
    End Sub
    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        rptClientBalance.ReportPeriod = "For the Period Ended on " & dtEndDate.DateTime.ToShortDateString

        Try
            Dim Query As String = String.Format("SELECT * FROM udfClientBalanceByDate('{0}')  WHERE  Balance <>0", dtEndDate.DateTime.ToShortDateString)


            DBManger.ShowRibbonReport(Navigator, New rptClientBalance, Query, If(e.Item.Id.Equals(2), True, False))
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub

End Class