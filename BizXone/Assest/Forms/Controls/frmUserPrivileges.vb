Imports DevExpress.XtraBars

Public Class frmUserPrivileges
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Navigator.MergeCommandRibbon(CommandRibbon)
    End Sub
    Private Sub GridBtnDeleteMenu_Click(sender As Object, e As System.EventArgs) Handles GridBtnDeleteItem.Click
        UserRoleManager.DeleteMenuItem(grdViewUser)

    End Sub

    Private Sub GridBtnAddMenu_Click(sender As Object, e As System.EventArgs) Handles GridBtnAddMenu.Click

        UserRoleManager.AddMenuItem(grdViewMenu)

    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Select Case e.Item.Id

            Case 101 'Save Command
                DBManger.XtraExecuteSQLQuery(String.Format("UPDATE syUsers SET RibbonItems='{1}' where UserID={0}", lstUser.SelectedValue, UserRoleManager.GetUserRibbonItemsData))
                UserAlerts.ShowSaveRecordMsg()
            Case 104 'Close Command
                Navigator.ShowDashboard(GetType(MdiDashboard))
            Case 106 'Add User Command
                frmUsersProfile.ShowDialog()
                DBManger.XtraLoadDropDownData(lstUser, "UserID", "FullName", "syUsers")
        End Select
    End Sub

    Private Sub frmUserRoles_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        DBManger.XtraLoadDropDownData(lstUser, "UserID", "FullName", "syUsers")
        lstUser.SelectedIndex = 0

        LoadUserMenuFromDB(lstUser.SelectedValue)
    End Sub

    Private Sub LoadUserMenuFromDB(ByVal UserID As String)

        grdRibbonCommands.DataSource = Nothing
        grdRibbonCommands.RefreshDataSource()


        If String.IsNullOrWhiteSpace(UserID) Then Exit Sub
        Dim UserRibbonItemsData As String = DBManger.XtraTableColumnValue("RibbonItems", "syUsers where UserID=" & Convert.ToInt32(UserID)).ToString
        'If IsDBNull(UserRibbonItemsData) Or String.IsNullOrEmpty(UserRibbonItemsData) Then Exit Sub
        UserRoleManager.LoadUserMenu(UserRibbonItemsData, grdUserRibbon, grdRibbonCommands)

    End Sub

    Private Sub lstUser_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstUser.SelectedValueChanged
        LoadUserMenuFromDB(lstUser.SelectedValue)
    End Sub
End Class