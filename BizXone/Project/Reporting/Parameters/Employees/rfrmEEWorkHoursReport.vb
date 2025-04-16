Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmEEWorkHoursReport

    Private Sub rfrmEEWorkHoursReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now
        DBManger.XtraLoadDropDownData(cmbEmployee, "EmployeeID", "Name", "vwEmployees")
    End Sub


    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString

        If dxValidationProvider.Validate.Equals(False) Then Exit Sub
        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub


        Try

            rptEEWorkHoursReport.ReportPeriod = "From:   " & D1 & "   To:   " & D2




            Dim Query As String = String.Empty




            Query = String.Format("Select * from vwAttendanceLogs WHERE ID={0} AND  Dated >= '{1}' AND Dated <= '{2}'", cmbEmployee.EditValue, D1, D2)


            DBManger.ShowRibbonReport(Navigator, New rptEEWorkHoursReport, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub

End Class