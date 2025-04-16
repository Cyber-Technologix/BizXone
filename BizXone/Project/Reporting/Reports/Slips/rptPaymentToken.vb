Public Class rptPaymentToken
    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportFooter.BeforePrint
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class