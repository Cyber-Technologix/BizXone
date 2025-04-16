Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEmployee
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim CompareAgainstControlValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Dim StubGlyphOptions1 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions5 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject19 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject20 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions6 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject21 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject22 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject23 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject24 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Dim StubGlyphOptions2 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Me.txtPassword = New DevExpress.XtraEditors.ButtonEdit()
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.FingerPrintTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cmbDepartment = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtHireDate = New DevExpress.XtraEditors.DateEdit()
        Me.imgPhoto = New DevExpress.XtraEditors.PictureEdit()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.txtJobTitle = New DevExpress.XtraEditors.TextEdit()
        Me.dtBrithDate = New DevExpress.XtraEditors.DateEdit()
        Me.ddlJobStatus = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.txtMobilePhone = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtHomePhone = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtEmail = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtAddress = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtFinalPassword = New DevExpress.XtraEditors.ButtonEdit()
        Me.ddlGender = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.FingerPrintTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDepartment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHireDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHireDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPhoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBrithDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtBrithDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlJobStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHomePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFinalPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlGender.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(149, 313)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPassword.Name = "txtPassword"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.txtPassword.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtPassword.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPassword.Size = New System.Drawing.Size(549, 22)
        Me.txtPassword.StyleController = Me.LayoutMain
        Me.txtPassword.TabIndex = 37
        Me.txtPassword.Tag = "Password"
        CompareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule2.Control = Me.txtFinalPassword
        CompareAgainstControlValidationRule2.ErrorText = "This value is not valid"
        Me.dxValidationProvider.SetValidationRule(Me.txtPassword, CompareAgainstControlValidationRule2)
        '
        'LayoutMain
        '
        Me.LayoutMain.Controls.Add(Me.FingerPrintTextEdit)
        Me.LayoutMain.Controls.Add(Me.cmbDepartment)
        Me.LayoutMain.Controls.Add(Me.dtHireDate)
        Me.LayoutMain.Controls.Add(Me.imgPhoto)
        Me.LayoutMain.Controls.Add(Me.GridMain)
        Me.LayoutMain.Controls.Add(Me.txtName)
        Me.LayoutMain.Controls.Add(Me.txtID)
        Me.LayoutMain.Controls.Add(Me.txtJobTitle)
        Me.LayoutMain.Controls.Add(Me.dtBrithDate)
        Me.LayoutMain.Controls.Add(Me.ddlJobStatus)
        Me.LayoutMain.Controls.Add(Me.txtMobilePhone)
        Me.LayoutMain.Controls.Add(Me.txtHomePhone)
        Me.LayoutMain.Controls.Add(Me.txtEmail)
        Me.LayoutMain.Controls.Add(Me.txtAddress)
        Me.LayoutMain.Controls.Add(Me.txtPassword)
        Me.LayoutMain.Controls.Add(Me.txtFinalPassword)
        Me.LayoutMain.Controls.Add(Me.ddlGender)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 126)
        Me.LayoutMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AlignInGroups
        Me.LayoutMain.Root = Me.LayoutControlGroup1
        Me.LayoutMain.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutMain.TabIndex = 0
        Me.LayoutMain.Tag = "tblEmployees"
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'FingerPrintTextEdit
        '
        Me.FingerPrintTextEdit.Location = New System.Drawing.Point(149, 339)
        Me.FingerPrintTextEdit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FingerPrintTextEdit.Name = "FingerPrintTextEdit"
        Me.FingerPrintTextEdit.Properties.AllowFocused = False
        Me.FingerPrintTextEdit.Properties.ReadOnly = True
        Me.FingerPrintTextEdit.Size = New System.Drawing.Size(1227, 20)
        Me.FingerPrintTextEdit.StyleController = Me.LayoutMain
        Me.FingerPrintTextEdit.TabIndex = 36
        Me.FingerPrintTextEdit.Tag = "FingerPrint"
        '
        'cmbDepartment
        '
        Me.cmbDepartment.EnterMoveNextControl = True
        Me.cmbDepartment.Location = New System.Drawing.Point(149, 265)
        Me.cmbDepartment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbDepartment.Name = "cmbDepartment"
        Me.cmbDepartment.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbDepartment.Properties.Appearance.Options.UseForeColor = True
        Me.cmbDepartment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDepartment.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "Department Name")})
        Me.cmbDepartment.Properties.NullText = ""
        Me.cmbDepartment.Size = New System.Drawing.Size(549, 20)
        Me.cmbDepartment.StyleController = Me.LayoutMain
        Me.cmbDepartment.TabIndex = 31
        Me.cmbDepartment.Tag = "DepartmentID"
        '
        'dtHireDate
        '
        Me.dtHireDate.EditValue = Nothing
        Me.dtHireDate.EnterMoveNextControl = True
        Me.dtHireDate.Location = New System.Drawing.Point(827, 265)
        Me.dtHireDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtHireDate.Name = "dtHireDate"
        Me.dtHireDate.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dtHireDate.Properties.Appearance.Options.UseForeColor = True
        Me.dtHireDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHireDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtHireDate.Size = New System.Drawing.Size(549, 20)
        Me.dtHireDate.StyleController = Me.LayoutMain
        Me.dtHireDate.TabIndex = 30
        Me.dtHireDate.Tag = "HireDate"
        '
        'imgPhoto
        '
        Me.imgPhoto.EditValue = Global.BizXone.My.Resources.Resources.EE_Picture
        Me.imgPhoto.Location = New System.Drawing.Point(1241, 61)
        Me.imgPhoto.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.imgPhoto.Name = "imgPhoto"
        Me.imgPhoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgPhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.imgPhoto.Size = New System.Drawing.Size(147, 167)
        Me.imgPhoto.StyleController = Me.LayoutMain
        Me.imgPhoto.TabIndex = 29
        Me.imgPhoto.Tag = "Photo"
        '
        'GridMain
        '
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridMain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMain.Location = New System.Drawing.Point(12, 375)
        Me.GridMain.MainView = Me.GridView1
        Me.GridMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridMain.Name = "GridMain"
        Me.GridMain.Size = New System.Drawing.Size(1376, 137)
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
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
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
        Me.GridColumn1.Caption = " ID"
        Me.GridColumn1.FieldName = "EmployeeID"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 47
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Name"
        Me.GridColumn2.FieldName = "Name"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 166
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Gender"
        Me.GridColumn3.FieldName = "Gender"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 237
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Email"
        Me.GridColumn4.FieldName = "Email"
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 166
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Mobile #"
        Me.GridColumn5.FieldName = "MobilePhone"
        Me.GridColumn5.MinWidth = 23
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 166
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Job Title"
        Me.GridColumn6.FieldName = "JobTitle"
        Me.GridColumn6.MinWidth = 23
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 159
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Department"
        Me.GridColumn7.FieldName = "DepartmentName"
        Me.GridColumn7.MinWidth = 23
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 159
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Hire Date"
        Me.GridColumn8.FieldName = "HireDate"
        Me.GridColumn8.MinWidth = 23
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 159
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.EnterMoveNextControl = True
        Me.txtName.Location = New System.Drawing.Point(120, 94)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Properties.Appearance.Options.UseForeColor = True
        Me.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Size = New System.Drawing.Size(1105, 20)
        Me.txtName.StyleController = Me.LayoutMain
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = "Name"
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(101, 24)
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
        Me.txtID.Size = New System.Drawing.Size(95, 20)
        Me.txtID.StyleController = Me.LayoutMain
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "EmployeeID"
        '
        'txtJobTitle
        '
        Me.txtJobTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJobTitle.EnterMoveNextControl = True
        Me.txtJobTitle.Location = New System.Drawing.Point(149, 289)
        Me.txtJobTitle.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobTitle.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtJobTitle.Properties.Appearance.Options.UseFont = True
        Me.txtJobTitle.Properties.Appearance.Options.UseForeColor = True
        Me.txtJobTitle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtJobTitle.Size = New System.Drawing.Size(549, 20)
        Me.txtJobTitle.StyleController = Me.LayoutMain
        Me.txtJobTitle.TabIndex = 2
        Me.txtJobTitle.Tag = "JobTitle"
        '
        'dtBrithDate
        '
        Me.dtBrithDate.EditValue = Nothing
        Me.dtBrithDate.EnterMoveNextControl = True
        Me.dtBrithDate.Location = New System.Drawing.Point(120, 118)
        Me.dtBrithDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtBrithDate.Name = "dtBrithDate"
        Me.dtBrithDate.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.dtBrithDate.Properties.Appearance.Options.UseForeColor = True
        Me.dtBrithDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBrithDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtBrithDate.Size = New System.Drawing.Size(502, 20)
        Me.dtBrithDate.StyleController = Me.LayoutMain
        Me.dtBrithDate.TabIndex = 30
        Me.dtBrithDate.Tag = "BrithDate"
        '
        'ddlJobStatus
        '
        Me.ddlJobStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BehaviorManager1.SetBehaviors(Me.ddlJobStatus, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.ddlJobStatus.EditValue = ""
        Me.ddlJobStatus.EnterMoveNextControl = True
        Me.ddlJobStatus.Location = New System.Drawing.Point(827, 289)
        Me.ddlJobStatus.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ddlJobStatus.Name = "ddlJobStatus"
        Me.ddlJobStatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlJobStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlJobStatus.Properties.Appearance.Options.UseFont = True
        Me.ddlJobStatus.Properties.Appearance.Options.UseForeColor = True
        Me.ddlJobStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlJobStatus.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ddlJobStatus.Properties.PopupSizeable = True
        Me.ddlJobStatus.Size = New System.Drawing.Size(549, 20)
        Me.ddlJobStatus.StyleController = Me.LayoutMain
        Me.ddlJobStatus.TabIndex = 13
        Me.ddlJobStatus.Tag = "JobStatus"
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.EnterMoveNextControl = True
        Me.txtMobilePhone.Location = New System.Drawing.Point(120, 194)
        Me.txtMobilePhone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtMobilePhone.Name = "txtMobilePhone"
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.txtMobilePhone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtMobilePhone.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMobilePhone.Properties.UseMaskAsDisplayFormat = True
        Me.txtMobilePhone.Size = New System.Drawing.Size(502, 22)
        Me.txtMobilePhone.StyleController = Me.LayoutMain
        Me.txtMobilePhone.TabIndex = 33
        Me.txtMobilePhone.Tag = "MobilePhone"
        '
        'txtHomePhone
        '
        Me.txtHomePhone.EnterMoveNextControl = True
        Me.txtHomePhone.Location = New System.Drawing.Point(722, 194)
        Me.txtHomePhone.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtHomePhone.Name = "txtHomePhone"
        EditorButtonImageOptions3.Image = CType(resources.GetObject("EditorButtonImageOptions3.Image"), System.Drawing.Image)
        Me.txtHomePhone.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtHomePhone.Size = New System.Drawing.Size(503, 22)
        Me.txtHomePhone.StyleController = Me.LayoutMain
        Me.txtHomePhone.TabIndex = 33
        Me.txtHomePhone.Tag = "HomePhone"
        '
        'txtEmail
        '
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(120, 168)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmail.Name = "txtEmail"
        EditorButtonImageOptions4.Image = CType(resources.GetObject("EditorButtonImageOptions4.Image"), System.Drawing.Image)
        Me.txtEmail.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtEmail.Size = New System.Drawing.Size(1105, 22)
        Me.txtEmail.StyleController = Me.LayoutMain
        Me.txtEmail.TabIndex = 35
        Me.txtEmail.Tag = "Email"
        '
        'txtAddress
        '
        Me.txtAddress.EnterMoveNextControl = True
        Me.txtAddress.Location = New System.Drawing.Point(120, 142)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAddress.Name = "txtAddress"
        EditorButtonImageOptions5.Image = CType(resources.GetObject("EditorButtonImageOptions5.Image"), System.Drawing.Image)
        Me.txtAddress.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions5, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtAddress.Size = New System.Drawing.Size(1105, 22)
        Me.txtAddress.StyleController = Me.LayoutMain
        Me.txtAddress.TabIndex = 34
        Me.txtAddress.Tag = "Address"
        '
        'txtFinalPassword
        '
        Me.txtFinalPassword.Location = New System.Drawing.Point(827, 313)
        Me.txtFinalPassword.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtFinalPassword.Name = "txtFinalPassword"
        EditorButtonImageOptions6.Image = CType(resources.GetObject("EditorButtonImageOptions6.Image"), System.Drawing.Image)
        Me.txtFinalPassword.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions6, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject21, SerializableAppearanceObject22, SerializableAppearanceObject23, SerializableAppearanceObject24, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.txtFinalPassword.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFinalPassword.Size = New System.Drawing.Size(549, 22)
        Me.txtFinalPassword.StyleController = Me.LayoutMain
        Me.txtFinalPassword.TabIndex = 37
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule1.Control = Me.txtPassword
        CompareAgainstControlValidationRule1.ErrorText = "Confrim password not match."
        Me.dxValidationProvider.SetValidationRule(Me.txtFinalPassword, CompareAgainstControlValidationRule1)
        '
        'ddlGender
        '
        Me.BehaviorManager1.SetBehaviors(Me.ddlGender, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions2, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.ddlGender.EnterMoveNextControl = True
        Me.ddlGender.Location = New System.Drawing.Point(722, 118)
        Me.ddlGender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ddlGender.Name = "ddlGender"
        Me.ddlGender.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlGender.Properties.Appearance.Options.UseForeColor = True
        Me.ddlGender.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlGender.Properties.PopupSizeable = True
        Me.ddlGender.Size = New System.Drawing.Size(503, 20)
        Me.ddlGender.StyleController = Me.LayoutMain
        Me.ddlGender.TabIndex = 32
        Me.ddlGender.Tag = "Gender"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup4, Me.EmptySpaceItem1, Me.EmptySpaceItem2, Me.LayoutControlItem7, Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.SimpleLabelItem1, Me.EmptySpaceItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1400, 524)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
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
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(72, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(200, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(495, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridMain
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 363)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1380, 141)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceGroup.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
        Me.LayoutControlGroup2.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem14, Me.LayoutControlItem5, Me.LayoutControlItem13, Me.LayoutControlItem15, Me.LayoutControlItem10, Me.LayoutControlItem12})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 49)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1229, 171)
        Me.LayoutControlGroup2.Text = "Personal Information"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtName
        Me.LayoutControlItem2.CustomizationFormText = "Name:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1205, 24)
        Me.LayoutControlItem2.Text = "Name :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txtAddress
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(1205, 26)
        Me.LayoutControlItem14.Text = "Address :"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txtHomePhone
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Home Phone"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(602, 100)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(603, 26)
        Me.LayoutControlItem5.Text = "Home Phone :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txtMobilePhone
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(602, 26)
        Me.LayoutControlItem13.Text = "Mobile Phone :"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.txtEmail
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(1205, 26)
        Me.LayoutControlItem15.Text = "Email :"
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.dtBrithDate
        Me.LayoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem10.CustomizationFormText = "Hire Date :"
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(602, 24)
        Me.LayoutControlItem10.Text = "Brith Date :"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.ddlGender
        Me.LayoutControlItem12.Location = New System.Drawing.Point(602, 24)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(603, 24)
        Me.LayoutControlItem12.Text = "Gender :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(84, 13)
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.AppearanceGroup.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information
        Me.LayoutControlGroup3.AppearanceGroup.Options.UseForeColor = True
        Me.LayoutControlGroup3.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem8, Me.LayoutControlItem16, Me.LayoutControlItem11, Me.LayoutControlItem6, Me.LayoutControlItem17, Me.LayoutControlItem9, Me.LayoutControlItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1380, 143)
        Me.LayoutControlGroup3.Text = "Professional Information"
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txtJobTitle
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "Name:"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem8.Text = "Job Title :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.FingerPrintTextEdit
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 74)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(1356, 24)
        Me.LayoutControlItem16.Tag = ""
        Me.LayoutControlItem16.Text = "Finger Print :"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.cmbDepartment
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem11.Text = "Department :"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ddlJobStatus
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(678, 24)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem6.Text = "Job Status :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txtPassword
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem17.Name = "LayoutControlItem17"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(678, 26)
        Me.LayoutControlItem17.Tag = ""
        Me.LayoutControlItem17.Text = "Password :"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.dtHireDate
        Me.LayoutControlItem9.Location = New System.Drawing.Point(678, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(678, 24)
        Me.LayoutControlItem9.Text = "Hire Date :"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(113, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtFinalPassword
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Password"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(678, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(678, 26)
        Me.LayoutControlItem3.Text = "Confrim Password :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(113, 13)
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
        Me.SimpleLabelItem1.Text = "ADD NEW EMPLOYEE"
        Me.SimpleLabelItem1.TextSize = New System.Drawing.Size(237, 45)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(790, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(295, 49)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.imgPhoto
        Me.LayoutControlItem4.Location = New System.Drawing.Point(1229, 49)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(151, 171)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(151, 171)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(151, 171)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1400, 126)
        Me.BarDockControl4.Manager = Nothing
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 524)
        '
        'CommandRibbon
        '
        Me.CommandRibbon.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 30, 35, 30)
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiEdit, Me.bbiRefresh, Me.bbiPreview, Me.BarButtonItem1, Me.BarButtonItem2})
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
        Me.bbiPreview.ImageOptions.SvgImage = CType(resources.GetObject("bbiPreview.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
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
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print"
        Me.BarButtonItem2.Id = 23
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Employee"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Report"
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmAddEmployee"
        Me.Size = New System.Drawing.Size(1400, 650)
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.FingerPrintTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDepartment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHireDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHireDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPhoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBrithDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtBrithDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlJobStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMobilePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHomePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFinalPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlGender.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleLabelItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LayoutMain As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents imgPhoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtJobTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtHireDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtBrithDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbDepartment As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents FingerPrintTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ddlJobStatus As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtMobilePhone As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtHomePhone As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtAddress As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtFinalPassword As DevExpress.XtraEditors.ButtonEdit
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents ddlGender As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
End Class
