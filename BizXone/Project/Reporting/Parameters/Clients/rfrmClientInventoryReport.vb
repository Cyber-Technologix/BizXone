Imports System.Web.UI.WebControls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmClientInventoryReport

    Private Sub rfrmCustomerInvoiceReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim items As List(Of ListItem) = New List(Of ListItem) From {
            New ListItem With {.Text = "Purchase Invoice", .Value = 1},
            New ListItem With {.Text = "Purchase Return", .Value = 2},
            New ListItem With {.Text = "Sale Invoice", .Value = 3},
            New ListItem With {.Text = "Sale Return", .Value = 4}
        }
        ddlInventoryType.Clear()
        ddlInventoryType.Properties.Items.AddRange(items.ToArray)
        ddlInventoryType.SelectedIndex = 2



        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1).ToShortDateString
        dtEndDate.DateTime = Date.Now.ToShortDateString
        DBManger.XtraLoadDropDownData(cmbClient, "ClientID", "ClientName", "vwClients")
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString


        If dxValidationProvider.Validate.Equals(False) Then Exit Sub
        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub


        rptDayTransactions.ReportPeriod = "From:   " & D1 & "   To:   " & D2


        Try

            Dim DocID As Integer = DirectCast(ddlInventoryType.EditValue, ListItem).Value

            Dim Query As String = String.Format("Select * from vwInventory where DocID={0} AND ClientID={1} And CAST(EntryDate AS DATE)>='{2}' And CAST(EntryDate AS DATE)<='{3}'", DocID, cmbClient.EditValue, D1, D2)

            DBManger.ShowRibbonReport(Navigator, New rptClientInventory, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try

    End Sub

    Private Sub cmbClient_BeforePopup(sender As Object, e As EventArgs) Handles cmbClient.BeforePopup
        cmbClient.PopupBestFit
    End Sub
End Class