Imports DevExpress.XtraData

Public Class rptProductStock

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub

    Private Sub Detail_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        Dim V1 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("Balance")), 0, Me.GetCurrentColumnValue("Balance"))
        Dim V2 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("EqualToUnit")), 0, Me.GetCurrentColumnValue("EqualToUnit"))


        XrStock.Text = XtraHelper.ConvertToPacksAndLooseUnits(V1, V2, Me.GetCurrentColumnValue("UnitName").ToString, Me.GetCurrentColumnValue("LUnitName").ToString)

    End Sub
End Class