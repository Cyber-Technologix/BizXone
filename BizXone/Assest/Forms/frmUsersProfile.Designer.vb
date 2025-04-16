Imports DevExpress.XtraData
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsersProfile
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsersProfile))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim StubGlyphOptions1 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Dim StubGlyphOptions2 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.tknWorkstation = New DevExpress.XtraEditors.TokenEdit()
        Me.txtFullName = New DevExpress.XtraEditors.TextEdit()
        Me.imgUser = New DevExpress.XtraEditors.PictureEdit()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.gvUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.HistroyRepositoryItemButton = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.cmbGroup = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.cmbStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem6 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.tknWorkstation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistroyRepositoryItemButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutMain
        '
        Me.LayoutMain.Controls.Add(Me.tknWorkstation)
        Me.LayoutMain.Controls.Add(Me.txtFullName)
        Me.LayoutMain.Controls.Add(Me.imgUser)
        Me.LayoutMain.Controls.Add(Me.GridMain)
        Me.LayoutMain.Controls.Add(Me.txtUserName)
        Me.LayoutMain.Controls.Add(Me.txtPassword)
        Me.LayoutMain.Controls.Add(Me.txtID)
        Me.LayoutMain.Controls.Add(Me.cmbGroup)
        Me.LayoutMain.Controls.Add(Me.cmbStatus)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 0)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.Root = Me.LayoutControlGroup1
        Me.LayoutMain.Size = New System.Drawing.Size(972, 500)
        Me.LayoutMain.TabIndex = 0
        Me.LayoutMain.Tag = "syUsers"
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'tknWorkstation
        '
        Me.tknWorkstation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tknWorkstation.EnterMoveNextControl = True
        Me.tknWorkstation.Location = New System.Drawing.Point(86, 138)
        Me.tknWorkstation.Name = "tknWorkstation"
        Me.tknWorkstation.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tknWorkstation.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.tknWorkstation.Properties.Appearance.Options.UseBackColor = True
        Me.tknWorkstation.Properties.Appearance.Options.UseForeColor = True
        Me.tknWorkstation.Properties.Separators.AddRange(New String() {","})
        Me.tknWorkstation.Size = New System.Drawing.Size(546, 20)
        Me.tknWorkstation.StyleController = Me.LayoutMain
        Me.tknWorkstation.TabIndex = 31
        Me.tknWorkstation.Tag = "WorkstationID"
        '
        'txtFullName
        '
        Me.txtFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFullName.EnterMoveNextControl = True
        Me.txtFullName.Location = New System.Drawing.Point(86, 66)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtFullName.Properties.Appearance.Options.UseForeColor = True
        Me.txtFullName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFullName.Size = New System.Drawing.Size(546, 20)
        Me.txtFullName.StyleController = Me.LayoutMain
        Me.txtFullName.TabIndex = 30
        Me.txtFullName.Tag = "FullName"
        Me.txtFullName.ToolTip = "Enter User Name"
        '
        'imgUser
        '
        Me.imgUser.EditValue = Global.BizXone.My.Resources.Resources.EE_Picture
        Me.imgUser.Location = New System.Drawing.Point(844, 12)
        Me.imgUser.Name = "imgUser"
        Me.imgUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.imgUser.Size = New System.Drawing.Size(116, 146)
        Me.imgUser.StyleController = Me.LayoutMain
        Me.imgUser.TabIndex = 29
        Me.imgUser.Tag = "Photo"
        '
        'GridMain
        '
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMain.Location = New System.Drawing.Point(12, 186)
        Me.GridMain.MainView = Me.gvUser
        Me.GridMain.Name = "GridMain"
        Me.GridMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.HistroyRepositoryItemButton})
        Me.GridMain.Size = New System.Drawing.Size(948, 302)
        Me.GridMain.TabIndex = 28
        Me.GridMain.TabStop = False
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUser})
        '
        'gvUser
        '
        Me.gvUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gvUser.GridControl = Me.GridMain
        Me.gvUser.Name = "gvUser"
        Me.gvUser.OptionsBehavior.ReadOnly = True
        Me.gvUser.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = " ID"
        Me.GridColumn1.FieldName = "UserID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = " NAME"
        Me.GridColumn2.FieldName = "UserName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 280
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Group"
        Me.GridColumn3.FieldName = "GroupName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 164
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "History"
        Me.GridColumn4.ColumnEdit = Me.HistroyRepositoryItemButton
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'HistroyRepositoryItemButton
        '
        Me.HistroyRepositoryItemButton.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.HistroyRepositoryItemButton.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.HistroyRepositoryItemButton.Name = "HistroyRepositoryItemButton"
        Me.HistroyRepositoryItemButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.EnterMoveNextControl = True
        Me.txtUserName.Location = New System.Drawing.Point(86, 90)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtUserName.Properties.Appearance.Options.UseForeColor = True
        Me.txtUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUserName.Size = New System.Drawing.Size(546, 20)
        Me.txtUserName.StyleController = Me.LayoutMain
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Tag = "UserName"
        Me.txtUserName.ToolTip = "Enter User Name"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(86, 114)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtPassword.Properties.Appearance.Options.UseForeColor = True
        Me.txtPassword.Size = New System.Drawing.Size(546, 20)
        Me.txtPassword.StyleController = Me.LayoutMain
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Tag = "Password"
        Me.txtPassword.ToolTip = "Enter Password"
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(101, 27)
        Me.txtID.Name = "txtID"
        Me.txtID.Properties.Appearance.BackColor = System.Drawing.Color.AliceBlue
        Me.txtID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtID.Properties.Appearance.Options.UseBackColor = True
        Me.txtID.Properties.Appearance.Options.UseFont = True
        Me.txtID.Properties.Appearance.Options.UseForeColor = True
        Me.txtID.Properties.Appearance.Options.UseTextOptions = True
        Me.txtID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtID.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtID.Properties.UseMaskAsDisplayFormat = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.StyleController = Me.LayoutMain
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "UserID"
        '
        'cmbGroup
        '
        Me.cmbGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BehaviorManager1.SetBehaviors(Me.cmbGroup, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.cmbGroup.EditValue = ""
        Me.cmbGroup.EnterMoveNextControl = True
        Me.cmbGroup.Location = New System.Drawing.Point(86, 162)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbGroup.Properties.Appearance.Options.UseForeColor = True
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbGroup.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbGroup.Properties.PopupSizeable = True
        Me.cmbGroup.Size = New System.Drawing.Size(234, 20)
        Me.cmbGroup.StyleController = Me.LayoutMain
        Me.cmbGroup.TabIndex = 4
        Me.cmbGroup.Tag = "GroupID"
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BehaviorManager1.SetBehaviors(Me.cmbStatus, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions2, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.cmbStatus.EditValue = ""
        Me.cmbStatus.Location = New System.Drawing.Point(367, 162)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbStatus.Properties.Appearance.Options.UseForeColor = True
        Me.cmbStatus.Properties.AppearanceFocused.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbStatus.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbStatus.Properties.PopupSizeable = True
        Me.cmbStatus.Size = New System.Drawing.Size(265, 20)
        Me.cmbStatus.StyleController = Me.LayoutMain
        Me.cmbStatus.TabIndex = 5
        Me.cmbStatus.Tag = "StatusID"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.EmptySpaceItem3, Me.EmptySpaceItem6, Me.LayoutControlGroup4, Me.LayoutControlItem8, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem9})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(972, 500)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridMain
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 174)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(952, 306)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.imgUser
        Me.LayoutControlItem6.Location = New System.Drawing.Point(832, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(120, 150)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(120, 150)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(120, 174)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(416, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(208, 54)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem6
        '
        Me.EmptySpaceItem6.AllowHotTrack = False
        Me.EmptySpaceItem6.Location = New System.Drawing.Point(208, 0)
        Me.EmptySpaceItem6.Name = "EmptySpaceItem6"
        Me.EmptySpaceItem6.Size = New System.Drawing.Size(208, 54)
        Me.EmptySpaceItem6.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(208, 54)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem5.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem5.Control = Me.txtID
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "ID:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem5.Size = New System.Drawing.Size(184, 30)
        Me.LayoutControlItem5.Text = "Record ID :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtFullName
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 54)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(624, 24)
        Me.LayoutControlItem8.Text = "Full Name :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUserName
        Me.LayoutControlItem2.CustomizationFormText = "Name:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(624, 24)
        Me.LayoutControlItem2.Text = "User Name :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtPassword
        Me.LayoutControlItem4.CustomizationFormText = "Name:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 102)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(624, 24)
        Me.LayoutControlItem4.Text = "Password :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cmbGroup
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 150)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(312, 24)
        Me.LayoutControlItem3.Text = "User Group :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(62, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbStatus
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "Directorate :"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(312, 150)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(312, 24)
        Me.LayoutControlItem1.Text = "Status :"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(38, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(624, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(208, 174)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.tknWorkstation
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(624, 24)
        Me.LayoutControlItem9.Text = "Workstation"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(62, 13)
        '
        'Commands
        '
        Me.Commands.BarName = "Commands"
        Me.Commands.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Commands.DockCol = 0
        Me.Commands.DockRow = 0
        Me.Commands.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Commands.OptionsBar.DistanceBetweenItems = 2
        Me.Commands.OptionsBar.DrawBorder = False
        Me.Commands.OptionsBar.MultiLine = True
        Me.Commands.OptionsBar.UseWholeRow = True
        Me.Commands.Text = "Commands"
        '
        'barManager
        '
        Me.barManager.AllowQuickCustomization = False
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRefresh, Me.btnSave})
        Me.barManager.MainMenu = Me.Bar1
        Me.barManager.MaxItemId = 6
        '
        'Bar1
        '
        Me.Bar1.BarName = "Commands"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh)})
        Me.Bar1.OptionsBar.DistanceBetweenItems = 2
        Me.Bar1.OptionsBar.DrawBorder = False
        Me.Bar1.OptionsBar.MultiLine = True
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Commands"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Id = 2
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(972, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 500)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(972, 40)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 500)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(972, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 500)
        '
        'frmUsersProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 540)
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = CType(resources.GetObject("frmUsersProfile.IconOptions.Image"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsersProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New User"
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.tknWorkstation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFullName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistroyRepositoryItemButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutMain As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HistroyRepositoryItemButton As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtFullName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents imgUser As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem6 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents tknWorkstation As DevExpress.XtraEditors.TokenEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
