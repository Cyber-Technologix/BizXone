Public Class rptProductLedger
    Public Shared Property OpeningBalanceDate As String
    Public Shared Property ReportPeriod As String
    Dim Opening, RunTotal, V1, V2 As Double
    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
        XrPeriod.Text = ReportPeriod
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        XrOpeningBal.Text = 0
        Opening = Val(DBManger.XtraTableColumnValue("ISNULL(Sum(Credit-Debit),0)", String.Format("vwInventoryLedger WHERE ProductID={0} and EntryDate < '{1}'", Me.GetCurrentColumnValue("ProductID"), OpeningBalanceDate)))
        txtStock.Text = Val(DBManger.XtraTableColumnValue("Balance", String.Format("tblProducts WHERE ProductId={0}", Me.GetCurrentColumnValue("ProductID"))))
        XrOpeningBal.Text = Format(Opening, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub


    Private Sub Detail_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        V1 = If(String.IsNullOrEmpty(GetCurrentColumnValue("Credit")), 0, GetCurrentColumnValue("Credit"))
        V2 = If(String.IsNullOrEmpty(GetCurrentColumnValue("Debit")), 0, GetCurrentColumnValue("Debit"))
        RunTotal = RunTotal + V1 - V2 + Opening
        Opening = 0
        XrRunTotal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
        XrClosingBal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub
End Class