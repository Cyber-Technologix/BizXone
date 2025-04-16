Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors

Public Class rfrmProdManufactureList
    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        'If CN.XtraShowRequiredError(MainLayout, Color.Blue, "Empty or Null not allowed") Then Exit Sub
        Dim Query As String = String.Format("SELECT * FROM vwProducts").ToString

        Try

            If chkSelected.CheckState = CheckState.Checked Then
                Query = String.Format("SELECT * FROM vwProducts WHERE ManufactureID IN({0}) ", cmbManufacturer.EditValue).ToString
            End If

            DBManger.ShowRibbonReport(Navigator, New rptProductManufactureList, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub


    Private Sub rfrmProductsStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(cmbManufacturer, "ManufactureID", "ManufactureName", "tblManufacturers")
    End Sub

    Private Sub chkSelected_EditValueChanged(sender As Object, e As EventArgs) Handles chkSelected.EditValueChanged
        If chkSelected.CheckState = CheckState.Checked Then
            cmbManufacturer.ReadOnly = False

        Else
            cmbManufacturer.Clear()
            cmbManufacturer.ReadOnly = True
        End If
    End Sub
End Class