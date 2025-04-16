Imports DevExpress.XtraData
Imports DevExpress.XtraSecure.Extensions
Public Class frmUsersProfile
    Dim tableModule As XtraTableModule
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "UserID") With {.Container = LayoutMain}
    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.EditValueChanged
        If txtUserName.EditValue Is Nothing Then
            gvUser.ActiveFilter.Clear()
        Else
            gvUser.ActiveFilterString = "[UserName] LIKE '%" & txtUserName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbGroup.Properties.Items.AddEnum(Of Group)()
        cmbStatus.Properties.Items.AddEnum(Of RecordStatus)()
        DBManger.XtraLoadDropDownData(tknWorkstation, "WorkstationID", "WorkstationName", "syWorkstations")
        DBManger.XtraGridLoadData(Me.GridMain, "SELECT UserID, UserName,CASE WHEN GroupID=1 THEN 'Administrator' Else 'User'END AS GroupName FROM syUsers")
        txtID_Leave(sender, e)
    End Sub

    Private Sub HistroyRepositoryItemButton_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles HistroyRepositoryItemButton.ButtonClick

        'CN.XtraGridLoadData(frmHistory.grdResult, Query:=String.Format("SELECT LgnHst.TrNo, LgnHst.LoginDateTime, LgnHst.LoginUserID, usr.UserName, LgnHst.LoginUserIP, LgnHst.LoginUserLocation, LgnHst.LoginUserQuery
        'FROM syUsers AS usr INNER JOIN tblLoginHistory AS LgnHst ON usr.UserID = LgnHst.LoginUserID where LgnHst.LoginUserID={0}", gvUser.GetFocusedRowCellValue("UserID")))
        'If Application.OpenForms().OfType(Of frmHistory).Any Then Exit Sub 'frmResult.Close()
        'frmHistory.Show(MdiRibbon)

    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If DBManger.isFetchedRecord(tableModule) Then
            txtPassword.EditValue = txtPassword.EditValue.ToString.ToDecrypt
            tknWorkstation.EditValue = If(String.IsNullOrEmpty(tknWorkstation.EditValue), String.Empty, tknWorkstation.EditValue.ToString.ToDecrypt)
            cmbGroup.GetEnumByValue(Of Group)
            cmbStatus.GetEnumByValue(Of RecordStatus)
        Else
            DBManger.AutoNumber(txtID, tableModule)
        End If
        txtFullName.Focus()
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Select Case e.Item.Id

            Case 1 'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    txtPassword.EditValue = txtPassword.EditValue.ToString.ToEncrypt
                    tknWorkstation.EditValue = If(String.IsNullOrEmpty(tknWorkstation.EditValue), String.Empty, tknWorkstation.EditValue.ToString.ToEncrypt)
                    DBManger.SaveRecord(tableModule)
                    DBManger.XtraGridLoadData(Me.GridMain, "SELECT UserID, UserName,CASE WHEN GroupID=1 THEN 'Administrator' Else 'User'END AS GroupName FROM syUsers")
                    UserAlerts.ShowSaveRecordMsg()
                    txtID_Leave(sender, e)
                End If

            Case 2 'Refresh Command
                DBManger.XtraFormRefresh(LayoutMain)
                txtID_Leave(sender, e)
        End Select
    End Sub

    Private Sub imgUser_EditValueChanged(sender As Object, e As EventArgs) Handles imgUser.EditValueChanged
        If imgUser.Image Is Nothing Then imgUser.Image = My.Resources.Resources.EE_Picture
    End Sub
End Class