Public Class rptClientMaxLedger
    Public Shared Property ReportPeriod As String
    Public Shared Property OpeningBalanceDate As String

    Dim Opening, RunTotal, V1, V2 As Double
    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        V1 = If(String.IsNullOrEmpty(GetCurrentColumnValue("Credit")), 0, GetCurrentColumnValue("Credit"))
        V2 = If(String.IsNullOrEmpty(GetCurrentColumnValue("Debit")), 0, GetCurrentColumnValue("Debit"))
        RunTotal = RunTotal + V1 - V2 + Opening
        Opening = 0
        XrRunTotal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
        XrClosingBal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub


    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GroupHeader1.BeforePrint
        XrOpeningBal.Text = 0
        Opening = Val(DBManger.XtraTableColumnValue("isNULL(Sum(Credit-Debit),0)", String.Format("vwClientLedger WHERE ClientID={0} AND  EntryDate < '{1}'", Me.GetCurrentColumnValue("ClientID"), OpeningBalanceDate)))
        XrOpeningBal.Text = Format(Opening, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        XrPeriod.Text = ReportPeriod
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class