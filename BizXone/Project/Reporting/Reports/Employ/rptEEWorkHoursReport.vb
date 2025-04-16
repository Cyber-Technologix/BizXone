Public Class rptEEWorkHoursReport
    Public Shared Property ReportPeriod As String
    Private Sub ReportHeader_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
        XrPeriod.Text = ReportPeriod
    End Sub
End Class