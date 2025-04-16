Imports DevExpress.XtraData

Public Class rptInventorySlip
    Public Shared Property ReportName As String
    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrReportName.Text = ReportName.ToUpper
    End Sub

    Private Sub PageFooter_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PageFooter.BeforePrint
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub

    Private Sub Detail_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        Dim V1 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("Quantity")), 0, Me.GetCurrentColumnValue("Quantity"))
        Dim V2 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("EqualToUnit")), 0, Me.GetCurrentColumnValue("EqualToUnit"))

        XrUnits.Text = XtraHelper.ConvertToPacksAndLooseUnits(V1, V2, Me.GetCurrentColumnValue("UnitName").ToString, Me.GetCurrentColumnValue("LUnitName").ToString)
    End Sub
End Class