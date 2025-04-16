Imports DevExpress.XtraData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClient
       Inherits DevExpress.XtraSecure.ModuleBase
    'Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim StubGlyphOptions1 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClient))
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.imgPhoto = New DevExpress.XtraEditors.PictureEdit()
        Me.cmbClientHead = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMobile = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.ddlStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.imgPhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClientHead.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutMain
        '
        Me.LayoutMain.Appearance.Control.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutMain.Appearance.Control.Options.UseFont = True
        Me.LayoutMain.Controls.Add(Me.imgPhoto)
        Me.LayoutMain.Controls.Add(Me.cmbClientHead)
        Me.LayoutMain.Controls.Add(Me.GridMain)
        Me.LayoutMain.Controls.Add(Me.txtMobile)
        Me.LayoutMain.Controls.Add(Me.txtAddress)
        Me.LayoutMain.Controls.Add(Me.txtPhone)
        Me.LayoutMain.Controls.Add(Me.txtName)
        Me.LayoutMain.Controls.Add(Me.txtID)
        Me.LayoutMain.Controls.Add(Me.ddlStatus)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 126)
        Me.LayoutMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1165, 380, 650, 400)
        Me.LayoutMain.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AlignInGroups
        Me.LayoutMain.Root = Me.LayoutControlGroup1
        Me.LayoutMain.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutMain.TabIndex = 0
        Me.LayoutMain.Tag = "tblClients"
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'imgPhoto
        '
        Me.imgPhoto.EditValue = Global.BizXone.My.Resources.Resources.EE_Picture
        Me.imgPhoto.Location = New System.Drawing.Point(1242, 61)
        Me.imgPhoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.imgPhoto.Name = "imgPhoto"
        Me.imgPhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.imgPhoto.Size = New System.Drawing.Size(146, 186)
        Me.imgPhoto.StyleController = Me.LayoutMain
        Me.imgPhoto.TabIndex = 30
        Me.imgPhoto.Tag = "Photo"
        '
        'cmbClientHead
        '
        Me.cmbClientHead.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClientHead.EditValue = ""
        Me.cmbClientHead.EnterMoveNextControl = True
        Me.cmbClientHead.Location = New System.Drawing.Point(117, 166)
        Me.cmbClientHead.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbClientHead.Name = "cmbClientHead"
        Me.cmbClientHead.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbClientHead.Properties.Appearance.Options.UseForeColor = True
        Me.cmbClientHead.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbClientHead.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbClientHead.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbClientHead.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ClientHeadName", "Head Name", 23, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbClientHead.Properties.NullText = ""
        Me.cmbClientHead.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbClientHead.Size = New System.Drawing.Size(506, 20)
        Me.cmbClientHead.StyleController = Me.LayoutMain
        Me.cmbClientHead.TabIndex = 13
        Me.cmbClientHead.Tag = "ClientHeadID"
        '
        'GridMain
        '
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.GridMain.Location = New System.Drawing.Point(12, 251)
        Me.GridMain.MainView = Me.GridView1
        Me.GridMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.Size = New System.Drawing.Size(1376, 261)
        Me.GridMain.TabIndex = 28
        Me.GridMain.TabStop = False
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.LightYellow
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.LightCyan
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
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
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ClientID"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 160
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "NAME"
        Me.GridColumn2.FieldName = "ClientName"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 758
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "TYPE"
        Me.GridColumn3.FieldName = "ClientTypeName"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 308
        '
        'txtMobile
        '
        Me.txtMobile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMobile.EditValue = ""
        Me.txtMobile.EnterMoveNextControl = True
        Me.txtMobile.Location = New System.Drawing.Point(117, 142)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtMobile.Properties.Appearance.Options.UseForeColor = True
        Me.txtMobile.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMobile.Properties.NullText = "0300-1234567"
        Me.txtMobile.Properties.NullValuePrompt = "0300-1234567"
        Me.txtMobile.Size = New System.Drawing.Size(506, 20)
        Me.txtMobile.StyleController = Me.LayoutMain
        Me.txtMobile.TabIndex = 5
        Me.txtMobile.Tag = "MobileNo"
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.EditValue = ""
        Me.txtAddress.EnterMoveNextControl = True
        Me.txtAddress.Location = New System.Drawing.Point(117, 118)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtAddress.Properties.Appearance.Options.UseForeColor = True
        Me.txtAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Size = New System.Drawing.Size(1109, 20)
        Me.txtAddress.StyleController = Me.LayoutMain
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Tag = "Address"
        '
        'txtPhone
        '
        Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhone.EditValue = ""
        Me.txtPhone.EnterMoveNextControl = True
        Me.txtPhone.Location = New System.Drawing.Point(720, 142)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPhone.Properties.Appearance.Options.UseForeColor = True
        Me.txtPhone.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPhone.Properties.NullText = "0300-1234567"
        Me.txtPhone.Properties.NullValuePrompt = "0300-1234567"
        Me.txtPhone.Size = New System.Drawing.Size(506, 20)
        Me.txtPhone.StyleController = Me.LayoutMain
        Me.txtPhone.TabIndex = 4
        Me.txtPhone.Tag = "PhoneNo"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.EditValue = ""
        Me.txtName.EnterMoveNextControl = True
        Me.txtName.Location = New System.Drawing.Point(117, 94)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Properties.Appearance.Options.UseForeColor = True
        Me.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Size = New System.Drawing.Size(1109, 20)
        Me.txtName.StyleController = Me.LayoutMain
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = "ClientName"
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(99, 24)
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
        Me.txtID.Properties.MaskSettings.Set("mask", "d")
        Me.txtID.Properties.UseMaskAsDisplayFormat = True
        Me.txtID.Size = New System.Drawing.Size(97, 20)
        Me.txtID.StyleController = Me.LayoutMain
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "ClientID"
        '
        'ddlStatus
        '
        Me.ddlStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BehaviorManager1.SetBehaviors(Me.ddlStatus, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.ddlStatus.EditValue = ""
        Me.ddlStatus.Location = New System.Drawing.Point(720, 166)
        Me.ddlStatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ddlStatus.Name = "ddlStatus"
        Me.ddlStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlStatus.Properties.Appearance.Options.UseForeColor = True
        Me.ddlStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ddlStatus.Properties.PopupSizeable = True
        Me.ddlStatus.Size = New System.Drawing.Size(506, 20)
        Me.ddlStatus.StyleController = Me.LayoutMain
        Me.ddlStatus.TabIndex = 8
        Me.ddlStatus.Tag = "StatusID"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup2, Me.LayoutControlGroup4, Me.EmptySpaceItem1, Me.EmptySpaceItem5, Me.EmptySpaceItem2, Me.SimpleLabelItem1, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutControlGroup1.TextLocation = DevExpress.Utils.Locations.[Default]
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridMain
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 239)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1380, 265)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem6, Me.LayoutControlItem10, Me.LayoutControlItem3, Me.LayoutControlItem11, Me.LayoutControlItem5})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1230, 190)
        Me.LayoutControlGroup2.Text = "Add New Client Information"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtName
        Me.LayoutControlItem2.CustomizationFormText = "Name:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1206, 24)
        Me.LayoutControlItem2.Text = "Name :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me.txtMobile
        Me.LayoutControlItem6.CustomizationFormText = "&Mobile No:"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(603, 24)
        Me.LayoutControlItem6.Text = "Mobile Phone :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txtPhone
        Me.LayoutControlItem10.CustomizationFormText = "&Phone No:"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(603, 48)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(603, 24)
        Me.LayoutControlItem10.Text = "Home Phone :"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtAddress
        Me.LayoutControlItem3.CustomizationFormText = "A&ddress:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1206, 24)
        Me.LayoutControlItem3.Text = "A&ddress :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmbClientHead
        Me.LayoutControlItem11.CustomizationFormText = "Type:"
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(603, 73)
        Me.LayoutControlItem11.Text = "Client Head :"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.Control = Me.ddlStatus
        Me.LayoutControlItem5.CustomizationFormText = "&Status:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(603, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(603, 73)
        Me.LayoutControlItem5.Text = "&Status :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignModeGroup.AlignLocal
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(200, 49)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.Control = Me.txtID
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "ID:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(176, 25)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(176, 25)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(176, 25)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Record ID :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(200, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(495, 0)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(790, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
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
        Me.SimpleLabelItem1.Location = New System.Drawing.Point(1085, 0)
        Me.SimpleLabelItem1.Name = "SimpleLabelItem1"
        Me.SimpleLabelItem1.Size = New System.Drawing.Size(295, 49)
        Me.SimpleLabelItem1.Text = "ADD NEW CLIENTS"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(210, 45)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.imgPhoto
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1230, 49)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(150, 190)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(150, 190)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(150, 190)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'CommandRibbon
        '
        Me.CommandRibbon.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 30, 35, 30)
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiEdit, Me.bbiRefresh, Me.btnPreview, Me.BarButtonItem1, Me.btnPrint})
        Me.CommandRibbon.Location = New System.Drawing.Point(0, 0)
        Me.CommandRibbon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CommandRibbon.MaxItemId = 25
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
        'btnPreview
        '
        Me.btnPreview.Caption = "Preview"
        Me.btnPreview.Id = 201
        Me.btnPreview.ImageOptions.SvgImage = CType(resources.GetObject("bbiPrintPreview.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btnPreview.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.btnPreview.Name = "btnPreview"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close"
        Me.BarButtonItem1.Id = 22
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Clients"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnPreview)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnPrint)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Report"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 202
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmClient"
        Me.Size = New System.Drawing.Size(1400, 650)
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.imgPhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClientHead.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutMain As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtMobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbClientHead As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPreview As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ddlStatus As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Private WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents imgPhoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
End Class
