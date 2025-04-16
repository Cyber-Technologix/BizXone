Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors

Public Class rfrmWarehouseStock

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick


        If Not dxValidationProvider.Validate Then Exit Sub
        Try
            Dim Query As String = String.Format("SELECT * from udfWarehouseBalance({0}) Where Balance<>0", cmbWarehouse.EditValue).ToString
            DBManger.ShowRibbonReport(Navigator, New rptWarehouseStock, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            rptWarehouseStock.WarehouseName = cmbWarehouse.Text
            Close()
        End Try
    End Sub


    Private Sub rfrmProductsStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(cmbWarehouse, "WarehouseID", "WarehouseName", "tblWarehouse")
    End Sub

End Class