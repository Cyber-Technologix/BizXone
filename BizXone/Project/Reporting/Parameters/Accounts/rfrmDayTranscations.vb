Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmDayTransactions


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub rformAccountLegder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now
    End Sub


    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString

        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub


        rptDayTransactions.OpeningBalanceDate = D1
        rptDayTransactions.ReportPeriod = "From:   " & D1 & "   To:   " & D2

        Try
            Dim Query As String = "SELECT * FROM vwDayTransactions  where  EntryDate >= '" & D1 & "' And EntryDate <= '" & D2 & "'"
            DBManger.ShowRibbonReport(Navigator, New rptDayTransactions, Query, If(e.Item.Id.Equals(2), True, False))
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub
End Class