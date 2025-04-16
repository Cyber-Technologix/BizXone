Public Class rptClients

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class