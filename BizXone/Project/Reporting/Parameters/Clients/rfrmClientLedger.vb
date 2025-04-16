Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraData

Public Class rfrmClientLedger

    Private Sub rfrmCustomerLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now
        DBManger.XtraLoadDropDownData(cmbClient, "ClientID", "ClientName", "vwClients")

    End Sub



    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString

        If dxValidationProvider.Validate.Equals(False) Then Exit Sub
        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub


        Try

            rptClientLedger.OpeningBalanceDate = D1
            rptClientLedger.ReportPeriod = "From:   " & D1 & "   To:   " & D2

            rptClientMaxLedger.OpeningBalanceDate = D1
            rptClientMaxLedger.ReportPeriod = "From:   " & D1 & "   To:   " & D2


            Dim Query As String = String.Empty

            If chkMaxLegder.Checked Then
                Query = String.Format("Select * from vwClientMaxLedger WHERE ClientID={0} AND  EntryDate >= '{1}' AND EntryDate <= '{2}'", cmbClient.EditValue, D1, D2)

            Else
                Query = String.Format("Select * from vwClientLedger WHERE ClientID={0} AND  EntryDate >= '{1}' AND EntryDate <= '{2}'", cmbClient.EditValue, D1, D2)
            End If

            If chkMaxLegder.Checked Then
                DBManger.ShowRibbonReport(Navigator, New rptClientMaxLedger, Query, If(e.Item.Id.Equals(2), True, False))
            Else
                DBManger.ShowRibbonReport(Navigator, New rptClientLedger, Query, If(e.Item.Id.Equals(2), True, False))
            End If



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