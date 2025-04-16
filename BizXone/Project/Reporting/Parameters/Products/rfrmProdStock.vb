Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors

Public Class rfrmProdStock

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick

        Dim EndDate As String = dtEndDate.DateTime.ToShortDateString
        Dim isActive As Integer = DirectCast(ddlStatus.EditValue, ListItem).Value
        'If CN.XtraShowRequiredError(MainLayout, Color.Blue, "Empty or Null not allowed") Then Exit Sub

        Dim Reorder As String = If(tshReorder.IsOn, "AND ReorderLevel>=Balance", "")
        Dim Query As String = String.Format("SELECT * FROM udfInventoryBalanceByDate('{0}') WHERE isActive={1} {2} Order By DepartmentID", EndDate, isActive, Reorder)

        Try

            If chkSelected.CheckState = CheckState.Checked Then
                Query = String.Format("SELECT * FROM udfInventoryBalanceByDate('{0}') WHERE isActive={1} and DepartmentID IN({2}) {3} Order By DepartmentID", EndDate, isActive, cmbDepartment.EditValue, Reorder)
            End If

            DBManger.ShowRibbonReport(Navigator, New rptProductStock, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub


    Private Sub rfrmProductsStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim items As List(Of ListItem) = New List(Of ListItem) From {
            New ListItem With {.Text = "Active", .Value = 1},
            New ListItem With {.Text = "Deactivate", .Value = 0}
        }

        ddlStatus.Clear()
        ddlStatus.Properties.Items.AddRange(items.ToArray)
        ddlStatus.SelectedIndex = 0

        DBManger.XtraLoadDropDownData(cmbDepartment, "DepartmentID", "DepartmentName", "tblDepartments")
        dtEndDate.DateTime = Date.Now
    End Sub

    Private Sub chkSelected_EditValueChanged(sender As Object, e As EventArgs) Handles chkSelected.EditValueChanged
        If chkSelected.CheckState = CheckState.Checked Then
            cmbDepartment.ReadOnly = False

        Else
            cmbDepartment.SetEditValue(Nothing)
            cmbDepartment.ReadOnly = True
        End If
    End Sub

End Class