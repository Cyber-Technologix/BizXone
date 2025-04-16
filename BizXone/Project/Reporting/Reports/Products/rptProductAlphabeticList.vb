Public Class rptProductAlphabeticList
    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportFooter.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class