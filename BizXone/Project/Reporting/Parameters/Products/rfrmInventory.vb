Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmInventory


    Private Sub rfrmCustomerInvoiceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now

        Dim items As List(Of ListItem) = New List(Of ListItem) From {
            New ListItem With {.Text = "Purchase", .Value = 1},
            New ListItem With {.Text = "Purchase Return", .Value = 2},
            New ListItem With {.Text = "Sale", .Value = 3},
            New ListItem With {.Text = "Sale Return", .Value = 4}
        }

        ddlInventoryType.Clear()
        ddlInventoryType.Properties.Items.AddRange(items.ToArray)
        ddlInventoryType.SelectedIndex = 2

    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString

        If dxValidationProvider.Validate.Equals(False) Then Exit Sub
        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub

        Try

            rptInventory.ReportPeriod = "From:   " & D1 & "   To:   " & D2

            Dim DocID As Integer = DirectCast(ddlInventoryType.EditValue, ListItem).Value


            Dim Query As String = String.Format("Select * from vwInventory where DocID={0} AND  EntryDate >= '{1}' And EntryDate <= '{2}'", DocID, D1, D2)

            DBManger.ShowRibbonReport(Navigator, New rptInventory, Query, If(e.Item.Id.Equals(2), True, False))
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            rptInventory.ReportName = String.Format("{0} Products Report", ddlInventoryType.SelectedText)
            Close()
        End Try
    End Sub


End Class