Imports DevExpress.XtraData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddAccounts
       Inherits DevExpress.XtraSecure.ModuleBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddAccounts))
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.cmbACType = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem7 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbACType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutMain
        '
        Me.LayoutMain.Controls.Add(Me.GridMain)
        Me.LayoutMain.Controls.Add(Me.txtName)
        Me.LayoutMain.Controls.Add(Me.cmbACType)
        Me.LayoutMain.Controls.Add(Me.txtID)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 126)
        Me.LayoutMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1083, 281, 793, 620)
        Me.LayoutMain.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AlignInGroups
        Me.LayoutMain.Root = Me.LayoutControlGroup3
        Me.LayoutMain.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutMain.TabIndex = 0
        Me.LayoutMain.Tag = "tblAccounts"
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'GridMain
        '
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GridMain.Location = New System.Drawing.Point(12, 157)
        Me.GridMain.MainView = Me.GridView1
        Me.GridMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.Size = New System.Drawing.Size(1376, 355)
        Me.GridMain.TabIndex = 27
        Me.GridMain.TabStop = False
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightYellow
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.LightCyan
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 933
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ACCOUNT ID"
        Me.GridColumn1.FieldName = "AccountID"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 99
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ACCOUNT NAME"
        Me.GridColumn2.FieldName = "AccountName"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 569
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(127, 121)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Properties.Appearance.Options.UseForeColor = True
        Me.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Size = New System.Drawing.Size(571, 20)
        Me.txtName.StyleController = Me.LayoutMain
        Me.txtName.TabIndex = 21
        Me.txtName.Tag = "AccountName"
        '
        'cmbACType
        '
        Me.cmbACType.EnterMoveNextControl = True
        Me.cmbACType.Location = New System.Drawing.Point(127, 97)
        Me.cmbACType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbACType.Name = "cmbACType"
        Me.cmbACType.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbACType.Properties.Appearance.Options.UseForeColor = True
        Me.cmbACType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbACType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbACType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbACType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountTypeID", "Account Type ID", 12, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountTypeName", "Account Type Name", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbACType.Properties.NullText = ""
        Me.cmbACType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbACType.Size = New System.Drawing.Size(571, 20)
        Me.cmbACType.StyleController = Me.LayoutMain
        Me.cmbACType.TabIndex = 20
        Me.cmbACType.Tag = "AccountTypeID"
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(102, 26)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseForeColor = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtID.Properties.UseMaskAsDisplayFormat = True
        Me.txtID.Size = New System.Drawing.Size(115, 20)
        Me.txtID.StyleController = Me.LayoutMain
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "AccountID"
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup4, Me.EmptySpaceItem2, Me.LayoutControlItem6, Me.EmptySpaceItem6, Me.EmptySpaceItem7, Me.SimpleLabelItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Name = "Root"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem3})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1380, 93)
        Me.LayoutControlGroup1.Text = "Add New Account"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtName
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem5.Text = "Account Name :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(91, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.CustomizationFormText = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(678, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.OptionsTableLayoutItem.ColumnIndex = 1
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(678, 48)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbACType
        Me.LayoutControlItem3.CustomizationFormText = "Account Type:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.OptionsTableLayoutItem.RowIndex = 1
        Me.LayoutControlItem3.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem3.Text = "Account Type :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(224, 52)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup4.TextLocation = DevExpress.Utils.Locations.[Default]
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem2.Control = Me.txtID
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "ID:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(200, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(200, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 4, 4)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(200, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Record ID :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(224, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(236, 52)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.GridMain
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 145)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1380, 359)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(689, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(231, 52)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem7
        '
        Me.EmptySpaceItem7.AllowHotTrack = False
        Me.EmptySpaceItem7.Location = New System.Drawing.Point(460, 0)
        Me.EmptySpaceItem7.Name = "EmptySpaceItem7"
        Me.EmptySpaceItem7.Size = New System.Drawing.Size(229, 52)
        Me.EmptySpaceItem7.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleLabelItem1
        '
        Me.SimpleLabelItem1.AllowHotTrack = False
        Me.SimpleLabelItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Bahnschrift Condensed", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleLabelItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.LimeGreen
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseFont = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.SimpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
        Me.SimpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(1096, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(284, 52)
        Me.SimpleLabelItem1.Text = "ADD NEW ACCOUNTS"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(238, 45)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(920, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(176, 52)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'CommandRibbon
        '
        Me.CommandRibbon.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 30, 35, 30)
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiEdit, Me.bbiRefresh, Me.bbiPreview, Me.BarButtonItem1, Me.btnPrint})
        Me.CommandRibbon.Location = New System.Drawing.Point(0, 0)
        Me.CommandRibbon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CommandRibbon.MaxItemId = 24
        Me.CommandRibbon.Name = "CommandRibbon"
        Me.CommandRibbon.OptionsMenuMinWidth = 385
        Me.CommandRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.CommandRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.CommandRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.Size = New System.Drawing.Size(1400, 126)
        Me.CommandRibbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Save"
        Me.bbiEdit.Id = 101
        Me.bbiEdit.ImageOptions.LargeImage = CType(resources.GetObject("bbiEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiEdit.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2)
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiRefresh
        '
        Me.bbiRefresh.Caption = "Refresh"
        Me.bbiRefresh.Id = 103
        Me.bbiRefresh.ImageOptions.Image = CType(resources.GetObject("bbiRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiRefresh.ImageOptions.LargeImage = CType(resources.GetObject("bbiRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3)
        Me.bbiRefresh.Name = "bbiRefresh"
        '
        'bbiPreview
        '
        Me.bbiPreview.Caption = "Preview"
        Me.bbiPreview.Id = 201
        Me.bbiPreview.ImageOptions.SvgImage = CType(resources.GetObject("bbiPrintPreview.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.bbiPreview.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.bbiPreview.Name = "bbiPreview"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close"
        Me.BarButtonItem1.Id = 22
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 202
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "New Accounts"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Command"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.bbiPreview)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnPrint)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Report"
        '
        'frmAddAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAddAccounts"
        Me.Size = New System.Drawing.Size(1400, 650)
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbACType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutMain As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbACType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem7 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
End Class
