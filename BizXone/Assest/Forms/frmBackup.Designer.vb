<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBackup))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnBackup = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRestore = New DevExpress.XtraBars.BarButtonItem()
        Me.txtStatus = New DevExpress.XtraBars.BarStaticItem()
        Me.btnVerify = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.pbrStatus = New DevExpress.XtraEditors.ProgressBarControl()
        Me.cmbDatabases = New System.Windows.Forms.ComboBox()
        Me.cmbServers = New System.Windows.Forms.ComboBox()
        Me.txtBackupLocation = New DevExpress.XtraEditors.TextEdit()
        Me.cmdLoadDatabases = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdLoadServers = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.pbrStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBackupLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btnBackup, Me.btnRestore, Me.txtStatus, Me.btnVerify})
        Me.RibbonControl.LargeImages = Me.ImageCollection1
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 8
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(546, 158)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnBackup
        '
        Me.btnBackup.Caption = "Backup"
        Me.btnBackup.Id = 1
        Me.btnBackup.ImageOptions.LargeImageIndex = 0
        Me.btnBackup.Name = "btnBackup"
        '
        'btnRestore
        '
        Me.btnRestore.Caption = "Restore"
        Me.btnRestore.Id = 2
        Me.btnRestore.ImageOptions.LargeImageIndex = 1
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'txtStatus
        '
        Me.txtStatus.Caption = "Status messages will be displayed here."
        Me.txtStatus.Id = 6
        Me.txtStatus.ImageOptions.Image = CType(resources.GetObject("txtStatus.ImageOptions.Image"), System.Drawing.Image)
        Me.txtStatus.ImageOptions.ImageIndex = 0
        Me.txtStatus.ImageOptions.LargeImage = CType(resources.GetObject("txtStatus.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.txtStatus.ItemInMenuAppearance.Normal.Options.UseImage = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnVerify
        '
        Me.btnVerify.Caption = "Verify"
        Me.btnVerify.Id = 7
        Me.btnVerify.ImageOptions.LargeImageIndex = 2
        Me.btnVerify.Name = "btnVerify"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "db_comit.png")
        Me.ImageCollection1.Images.SetKeyName(1, "db_update.png")
        Me.ImageCollection1.Images.SetKeyName(2, "db_status.png")
        Me.ImageCollection1.Images.SetKeyName(3, "cancel.png")
        Me.ImageCollection1.Images.SetKeyName(4, "schedule.png")
        Me.ImageCollection1.Images.SetKeyName(5, "messagebox_warning.png")
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Backup and Restore"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnBackup)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRestore)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnVerify)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Options"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.txtStatus)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 293)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(546, 24)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.pbrStatus)
        Me.LayoutControl1.Controls.Add(Me.cmbDatabases)
        Me.LayoutControl1.Controls.Add(Me.cmbServers)
        Me.LayoutControl1.Controls.Add(Me.txtBackupLocation)
        Me.LayoutControl1.Controls.Add(Me.cmdLoadDatabases)
        Me.LayoutControl1.Controls.Add(Me.cmdLoadServers)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 158)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1000, 205, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(546, 135)
        Me.LayoutControl1.TabIndex = 2
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'pbrStatus
        '
        Me.pbrStatus.Location = New System.Drawing.Point(12, 88)
        Me.pbrStatus.MenuManager = Me.RibbonControl
        Me.pbrStatus.Name = "pbrStatus"
        Me.pbrStatus.Properties.ShowTitle = True
        Me.pbrStatus.Size = New System.Drawing.Size(522, 18)
        Me.pbrStatus.StyleController = Me.LayoutControl1
        Me.pbrStatus.TabIndex = 13
        '
        'cmbDatabases
        '
        Me.cmbDatabases.FormattingEnabled = True
        Me.cmbDatabases.Location = New System.Drawing.Point(99, 38)
        Me.cmbDatabases.Name = "cmbDatabases"
        Me.cmbDatabases.Size = New System.Drawing.Size(342, 21)
        Me.cmbDatabases.TabIndex = 12
        '
        'cmbServers
        '
        Me.cmbServers.FormattingEnabled = True
        Me.cmbServers.Location = New System.Drawing.Point(99, 12)
        Me.cmbServers.Name = "cmbServers"
        Me.cmbServers.Size = New System.Drawing.Size(342, 21)
        Me.cmbServers.TabIndex = 11
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.EditValue = ""
        Me.txtBackupLocation.Location = New System.Drawing.Point(99, 64)
        Me.txtBackupLocation.MenuManager = Me.RibbonControl
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.Properties.ReadOnly = True
        Me.txtBackupLocation.Size = New System.Drawing.Size(435, 20)
        Me.txtBackupLocation.StyleController = Me.LayoutControl1
        Me.txtBackupLocation.TabIndex = 8
        '
        'cmdLoadDatabases
        '
        Me.cmdLoadDatabases.Location = New System.Drawing.Point(445, 38)
        Me.cmdLoadDatabases.Name = "cmdLoadDatabases"
        Me.cmdLoadDatabases.Size = New System.Drawing.Size(89, 22)
        Me.cmdLoadDatabases.StyleController = Me.LayoutControl1
        Me.cmdLoadDatabases.TabIndex = 7
        Me.cmdLoadDatabases.Text = "Load Databases"
        '
        'cmdLoadServers
        '
        Me.cmdLoadServers.Location = New System.Drawing.Point(445, 12)
        Me.cmdLoadServers.Name = "cmdLoadServers"
        Me.cmdLoadServers.Size = New System.Drawing.Size(89, 22)
        Me.cmdLoadServers.StyleController = Me.LayoutControl1
        Me.cmdLoadServers.TabIndex = 6
        Me.cmdLoadServers.Text = "Load Servers"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "Root"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem8, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(546, 135)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmdLoadServers
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(433, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtBackupLocation
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(526, 24)
        Me.LayoutControlItem5.Text = "Backup location"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.cmbServers
        Me.LayoutControlItem8.CustomizationFormText = "LayoutControlItem8"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem8.Text = "Server name"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmdLoadDatabases
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(433, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(93, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbDatabases
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(433, 26)
        Me.LayoutControlItem1.Text = "Database name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(75, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.pbrStatus
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 76)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(526, 22)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 98)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(526, 17)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 317)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Image = CType(resources.GetObject("frmBackup.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackup"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Backup and  Restore Database"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.pbrStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBackupLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents btnBackup As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents cmdLoadServers As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdLoadDatabases As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtBackupLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnRestore As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbServers As System.Windows.Forms.ComboBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbDatabases As System.Windows.Forms.ComboBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents pbrStatus As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents txtStatus As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnVerify As DevExpress.XtraBars.BarButtonItem


End Class
