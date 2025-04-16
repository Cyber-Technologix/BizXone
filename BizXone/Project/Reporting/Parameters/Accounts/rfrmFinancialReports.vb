Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class rfrmFinancialReports

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim AutoPrint As Boolean = If(e.Item.Id.Equals(2), True, False)

        Try

            Select Case CInt(ddlReport.EditValue)
                Case 1
                    rptBalanceSheet.ReportPeriod = "For the Period Ended on"
                    DBManger.ShowRibbonReport(Navigator, New rptBalanceSheet, "SELECT * FROM udfAccountsBalanceSheet()", AutoPrint)
                Case 2
                    'rptTrialBalance.ReportPeriod = "For the Period Ended on " & dtEndDate.DateTime.ToShortDateString
                    DBManger.ShowRibbonReport(Navigator, New rptTrialBalance, "Exec spAccountsTrialBalance", AutoPrint)
                Case 3
                    'rptTrialBalance.ReportPeriod = "For the Period Ended on " & dtEndDate.DateTime.ToShortDateString
                    DBManger.ShowRibbonReport(Navigator, New rptProfitAndLoss, "SELECT * FROM udfAccountsBalanceSheet() where HeadID IN(3,4)", AutoPrint)

            End Select
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Close()
        End Try


    End Sub

    Private Sub rfrmFinancialReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim items As New List(Of ImageComboBoxItem) From {
           New ImageComboBoxItem With {.Description = "Accounts Balance Sheet", .Value = 1},
           New ImageComboBoxItem With {.Description = "Accounts Trail Balance", .Value = 2},
           New ImageComboBoxItem With {.Description = "Profit and Loss Statement", .Value = 3}
       }
        ddlReport.Properties.Items.Clear()
        ddlReport.Properties.Items.AddRange(items)
        ddlReport.SelectedIndex = 0
    End Sub
End Class