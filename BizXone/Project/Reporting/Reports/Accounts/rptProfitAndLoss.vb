Public Class rptProfitAndLoss

    Public Shared Property ReportPeriod As String
    Private Sub ReportFooter_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportFooter.BeforePrint

        Dim Query As String = "SELECT HeadID, HeadName, SUM(Balance) AS Balance FROM dbo.udfAccountsBalanceSheet()
                                WHERE (HeadID IN (3, 4)) GROUP BY HeadID, HeadName ORDER BY HeadID DESC, HeadName"


        Dim Query2 As String = "With tblCost as (SELECT ProductID, ProductName,Sum(Credit-debit) as Balance,
        (SELECt ISNULL(Max(Rate),0) from vwInventory where DocID=1 AND PeriodID=IL.PeriodID AND ProductID=IL.ProductID 
        AND EntryDate=( SELECT MAX(EntryDate) FROM vwInventory WHERE DocID = 1 AND PeriodID = IL.PeriodID AND ProductID = IL.ProductID))as UnitCost
        from vwInventoryLedger as IL where DocID IN (3,4) and PeriodID=(SELECT PeriodID FROM syPeriods WHERE StatusID = 1)
        group by PeriodID,ProductID, ProductName
        Having Sum(Credit-debit)>0) SELECT Sum(Balance*UnitCost)COGS from tblCost "


        Dim dt As DataTable = DBManger.XtraLoadDataTable(Query)
        Dim Rvnu As Double = dt.Rows.Item(0)(2)
        Dim Expn As Double = dt.Rows.Item(1)(2)

        Dim Cost As Double = DBManger.XtraLoadDataTable(Query2).AsEnumerable.Select(Function(row) row.Item(0)).ToList(0)

        XrRvn.Text = Rvnu
        XrCost.Text = Cost
        XrGP.Text = Val(Rvnu - Cost)
        XrExpn.Text = Expn
        XrNP.Text = Val(Rvnu - Cost + Expn)
    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ReportHeader.BeforePrint
        XrPeriod.Text = ReportPeriod
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub

End Class