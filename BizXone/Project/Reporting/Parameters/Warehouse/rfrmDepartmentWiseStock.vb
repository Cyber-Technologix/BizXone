Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors

Public Class rfrmDepartmentWiseStock

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        If Not dxValidationProvider.Validate Then Exit Sub
        Try

            Dim Query As String = String.Format("SELECT * FROM udfWarehouseExpiryBalance({0}) WHERE DepartmentID={1} ORDER BY  ProductID,EXPDate", cmbWarehouse.EditValue, cmbDepartment.EditValue).ToString
            DBManger.ShowRibbonReport(Navigator, New rptDepartmentWiseStock, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            rptDepartmentWiseStock.WarehouseName = cmbWarehouse.Text
            Close()
        End Try
    End Sub


    Private Sub rfrmProductsStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(cmbWarehouse, "WarehouseID", "WarehouseName", "tblWarehouse")
        DBManger.XtraLoadDropDownData(cmbDepartment, "DepartmentID", "DepartmentName", "tblDepartments")
    End Sub

End Class