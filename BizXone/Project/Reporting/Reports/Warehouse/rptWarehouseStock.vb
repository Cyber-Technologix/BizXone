Imports DevExpress.XtraData

Public Class rptWarehouseStock
    Public Shared Property WarehouseName As String

    Private Sub Detail_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        Dim V1 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("Balance")), 0, Me.GetCurrentColumnValue("Balance"))
        Dim V2 As Double = If(String.IsNullOrEmpty(Me.GetCurrentColumnValue("EqualToUnit")), 0, Me.GetCurrentColumnValue("EqualToUnit"))


        XrStock.Text = XtraHelper.ConvertToPacksAndLooseUnits(V1, V2, Me.GetCurrentColumnValue("UnitName").ToString, Me.GetCurrentColumnValue("LUnitName").ToString)

    End Sub

    Private Sub PageHeader_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PageHeader.BeforePrint
        XrWarehouseName.Text = WarehouseName
    End Sub

    Private Sub ReportHeader_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class