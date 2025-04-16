Public Class rptClientInventory
    Public Shared Property ReportPeriod As String

    Private Sub rptClientProductReport_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
        XrPeriod.Text = ReportPeriod
    End Sub
End Class