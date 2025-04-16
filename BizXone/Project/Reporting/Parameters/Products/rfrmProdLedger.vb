Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class rfrmProdLedger


    Private Sub rformAccountLegder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtStartDate.DateTime = New DateTime(Date.Now.Year, 1, 1)
        dtEndDate.DateTime = Date.Now
        DBManger.XtraLoadDropDownData(cmbProduct, "ProductID", "ProductName", "tblProducts")
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Dim D1 As String = dtStartDate.DateTime.ToShortDateString
        Dim D2 As String = dtEndDate.DateTime.ToShortDateString


        If XtraHelper.isValidDate(dtStartDate, dtEndDate) = False Then Exit Sub
        'If CN.XtraShowRequiredError(MainLayout, Color.Blue, "Empty or Null not allowed") Then Exit Sub

        Try
            rptProductLedger.OpeningBalanceDate = D1
            rptProductLedger.ReportPeriod = "From:   " & D1 & "   To:   " & D2


            Dim Query As String = String.Format("Select * from vwInventoryLedger WHERE DocID NOT IN (8) AND ProductID={0}  And EntryDate >= '{1}' And EntryDate <= '{2}'", cmbProduct.EditValue, D1, D2)

            DBManger.ShowRibbonReport(Navigator, New rptProductLedger, Query, If(e.Item.Id.Equals(2), True, False))

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            Close()
        End Try
    End Sub

End Class