Public Class rptInventory
    Public Shared Property ReportName As String
    Public Shared Property ReportPeriod As String
    Private Sub rptProductInventory_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub

    Private Sub ReportHeader_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        XrReportName.Text = ReportName
        XrPeriod.Text = ReportPeriod
    End Sub
End Class