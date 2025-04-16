Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraData
Imports DevExpress.XtraSecure

Public Class MdiRibbon

    Public Sub New()
        InitializeComponent()
        ProjectResources.ApplicationDefaultSkin()
        Navigator = New XtraModuleNavigator(Me, pcMain)
        UserRoleManager = New XtraUserRoleManagement(ApplicationRibbon, XtraAuthenticator.LoginUserPrivileges, False)
        BarAboutMe.Caption = ProjectResources.AboutMe()
        barUserName.Caption = XtraAuthenticator.UserName
    End Sub

    Private Sub MdiRibbon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Navigator.ShowDashboard(GetType(MdiDashboard))
        XtraAuthenticator.ShowChangePasswordMessage(frmPassword)
        ApplicationRibbon.SelectedPage = RibbonPage1

    End Sub
    Private Sub RibbonControl_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles ApplicationRibbon.ItemClick

        Select Case e.Item.Id

            Case 4
                MdiAlert.Show(Me, ProjectResources.AboutMe(), "About")
            Case 5
            Case 13
                frmAddTellers.ShowDialog()
            Case 14
                Navigator.ShowModule(New ModuleTagObject("Teller Transaction", GetType(frmTeller)))
            Case 15
                Navigator.ShowModule(New ModuleTagObject("Provisional Receipt", GetType(frmReceipt)))
            Case 16
                Navigator.ShowModule(New ModuleTagObject("Client Transaction", GetType(frmPayment)))
            Case 17
                Navigator.ShowModule(New ModuleTagObject("Add Accounts", GetType(frmAddAccounts)))
            Case 18
                Navigator.ShowModule(New ModuleTagObject("Add Employees", GetType(frmAddEmployee)))
            Case 166
                Navigator.ShowModule(New ModuleTagObject("Account Transaction", GetType(frmExpense)))
            Case 175
                Navigator.ShowModule(New ModuleTagObject("Add Products", GetType(frmAddProduct)))
            Case 182
                Navigator.ShowModule(New ModuleTagObject("Add Clients", GetType(frmClient)))
            Case 196
                Navigator.ShowModule(New ModuleTagObject("Product Analysis", GetType(frmViewer)))
            Case 217
                Navigator.ShowModule(New ModuleTagObject("User Roles", GetType(frmUserPrivileges)))
            Case 169
                rfrmHeadBalance.ShowDialog()
            'Case 171
            '    rfrmTrialBalance.ShowDialog()
            Case 172
                rfrmFinancialReports.ShowDialog()
            Case 179
                rfrmEEWorkHoursReport.ShowDialog()
            Case 187
                frmSettings.ShowDialog()
            'Case 205
            '    rfrmProdStock.ShowDialog()
            Case 206
                frmBackup.ShowDialog()
            Case 207
                XtraHelper.XtraQueryBuilderShow(DBManger.DataSource)
            Case 246
                rfrmWarehouseStock.ShowDialog()
            Case 243
                rfrmProdManufactureList.ShowDialog()
            Case 244
                rfrmInventory.ShowDialog()
            Case 245
                rfrmProdLedger.ShowDialog()
            Case 247
                rfrmProdStock.ShowDialog()
            Case 248
                rfrmDepartmentWiseStock.ShowDialog()

            Case 230
                Program.DocKind = DocumentKind.WarehouseTransaction
                Navigator.ShowModule(New ModuleTagObject("WarehouseTransaction", GetType(frmWarehouse)))
            Case 234
                Navigator.ShowModule(New ModuleTagObject("Attendance", GetType(frmAttendance)))
            Case 301
                Program.DocKind = DocumentKind.Sale
                Navigator.ShowModule(New ModuleTagObject("Sale Merchandise", GetType(frmMerchandise)))
            Case 302
                Program.DocKind = DocumentKind.SaleReturn
                Navigator.ShowModule(New ModuleTagObject("Sale-Return Merchandise", GetType(frmMerchandise)))
            Case 303
                Program.DocKind = DocumentKind.Purchase
                Navigator.ShowModule(New ModuleTagObject("Purchase Inventory", GetType(frmInventory)))
            Case 304
                Program.DocKind = DocumentKind.PurchaseReturn
                Navigator.ShowModule(New ModuleTagObject("Purchase-Return Inventory", GetType(frmInventory)))

        End Select

        'DevExpress.XtraEditors.XtraMessageBox.Show(e.Item.Id, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub NavBar_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBar.LinkClicked

        Select Case e.Link.ItemName
#Region "Accounts"

            Case "navAccountLedger"
                rfrmAccountLedger.ShowDialog()
            Case "navDayTransactions"
                rfrmDayTransactions.ShowDialog()
#End Region

#Region "Customers"

            Case "navClientLedger"
                rfrmClientLedger.ShowDialog()
            Case "navClientBalance"
                rfrmClientCurrentBalance.ShowDialog()
            Case "navClientInventory"
                rfrmClientInventoryReport.ShowDialog()

#End Region


        End Select
    End Sub

    Private Sub MdiRibbon_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing


        Dim action As New FlyoutAction() With {.Caption = Windows.Forms.Application.ProductName, .Description = "Are you sure you want to exit?"}
        Dim proerties As New FlyoutProperties() With {.ButtonSize = New Size(100, 40), .Style = FlyoutStyle.MessageBox}

        Dim command1 As New FlyoutCommand() With {.Text = "Yes", .Result = DialogResult.Yes}
        Dim command2 As New FlyoutCommand() With {.Text = "Cancel", .Result = DialogResult.No}
        action.ImageOptions.Image = My.Resources.Exit_Message
        action.Commands.Add(command1)
        action.Commands.Add(command2)



        If FlyoutDialog.Show(Me, action, proerties) = DialogResult.Yes Then
            Windows.Forms.Application.ExitThread()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SkinRibbonGallery_GalleryItemClick(sender As Object, e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs) Handles SkinRibbonGallery.GalleryItemClick
        My.Settings.Item("SkinName") = e.Item.Caption

        My.Settings.Save()
    End Sub

    Private Sub ApplicationRibbon_ApplicationButtonClick(sender As Object, e As EventArgs) Handles ApplicationRibbon.ApplicationButtonClick
        Navigator.ShowDashboard(GetType(MdiDashboard))
        'pcMain.Controls.Clear()
    End Sub

End Class
