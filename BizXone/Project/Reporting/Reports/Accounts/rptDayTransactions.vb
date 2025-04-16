Public Class rptDayTransactions
    Dim Opening As Double = 0

    Public Shared Property ReportPeriod As String
    Public Shared Property OpeningBalanceDate As String
    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Detail.BeforePrint
        Dim V1 As Double
        Dim V2 As Double
        V1 = IIf(String.IsNullOrEmpty(Me.GetCurrentColumnValue("Credit")), 0, Me.GetCurrentColumnValue("Credit"))
        V2 = IIf(String.IsNullOrEmpty(Me.GetCurrentColumnValue("Debit")), 0, Me.GetCurrentColumnValue("Debit"))
        Dim RunTotal As Double = RunTotal + V2 - V1 + Opening
        Opening = 0
        XrRunTotal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
        XrClosingBal.Text = Format(RunTotal, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub

    Private Sub GroupHeader1_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GroupHeader1.BeforePrint
        Dim Acc As String = DBManger.XtraTableColumnValue("CashAccountID", "tblDocs WHERE Docid = 3")
        XrOpeningBal.Text = 0
        Opening = Val(DBManger.XtraTableColumnValue("isNull(Sum(Credit-Debit),0)", String.Format("vwAccountsLedger WHERE AccountID= {0} and EntryDate < '{1}'", Acc, OpeningBalanceDate)))
        XrOpeningBal.Text = Format(Opening, "#,##0.00 Cr;#,##0.00 Dr")
    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        XrPeriod.Text = ReportPeriod
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class