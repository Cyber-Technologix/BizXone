Imports DevExpress.XtraEditors

Public Class rptProductManufactureList

    Private Sub rptProductList_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
        If (RowCount = 0) Then XtraMessageBox.Show("No records found!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ProjectResources.DesignReport(XrLogo, XrHeading_1, XrHeading_2, XrHeading_3)
        XrDeveloper.Text = ProjectResources.AboutMe()
    End Sub
End Class