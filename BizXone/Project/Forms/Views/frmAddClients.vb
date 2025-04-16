Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class frmClient
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = "Select * from vwClients"


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Navigator.MergeCommandRibbon(CommandRibbon)
        tableModule = New XtraTableModule(txtID, "ClientID") With {.Container = LayoutMain}
    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged
        If txtName.EditValue Is Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[ClientName] LIKE '%" & txtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlStatus.Properties.Items.AddEnum(Of RecordStatus)()
        DBManger.XtraLoadDropDownData(cmbClientHead, "ClientHeadID", "ClientHeadName", "tblClientHeads")
        RefreshView(sender, e)
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If Not DBManger.isFetchedRecord(tableModule) Then
            DBManger.AutoNumber(txtID, tableModule)
        Else
            ddlStatus.GetEnumByValue(Of RecordStatus)
        End If
    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Try
            Select Case e.Item.Id

                Case 101 'Save Command
                    If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                        DBManger.SaveRecord(tableModule)
                        RefreshView(sender, e)
                    End If

                Case 102 'Delete Command

                Case 103 'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain)
                    RefreshView(sender, e)

                Case 22 'Close Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 201, 202 'Preview Command
                    DBManger.ShowRibbonReport(Navigator, New rptClients, ViewQuery, If(e.Item.Id.Equals(202), True, False))

            End Select

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
        End Try
    End Sub

    Private Sub imgPhoto_EditValueChanged(sender As Object, e As EventArgs) Handles imgPhoto.EditValueChanged
        If imgPhoto.Image Is Nothing Then imgPhoto.Image = My.Resources.Resources.EE_Picture
    End Sub
    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
    End Sub
End Class