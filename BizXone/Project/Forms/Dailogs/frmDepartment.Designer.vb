Imports DevExpress.XtraData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartment))
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbPurchaseAccount = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbSaleAccount = New DevExpress.XtraEditors.LookUpEdit()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtName = New DevExpress.XtraEditors.TextEdit()
        Me.txtID = New DevExpress.XtraEditors.SpinEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.cmbPurchaseAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSaleAccount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutMain
        '
        Me.LayoutMain.Controls.Add(Me.cmbPurchaseAccount)
        Me.LayoutMain.Controls.Add(Me.cmbSaleAccount)
        Me.LayoutMain.Controls.Add(Me.GridMain)
        Me.LayoutMain.Controls.Add(Me.txtName)
        Me.LayoutMain.Controls.Add(Me.txtID)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 0)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(843, 243, 650, 400)
        Me.LayoutMain.Root = Me.LayoutControlGroup1
        Me.LayoutMain.Size = New System.Drawing.Size(686, 341)
        Me.LayoutMain.TabIndex = 0
        Me.LayoutMain.Tag = "tblDepartments"
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'cmbPurchaseAccount
        '
        Me.cmbPurchaseAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPurchaseAccount.EditValue = ""
        Me.cmbPurchaseAccount.EnterMoveNextControl = True
        Me.cmbPurchaseAccount.Location = New System.Drawing.Point(441, 79)
        Me.cmbPurchaseAccount.Name = "cmbPurchaseAccount"
        Me.cmbPurchaseAccount.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbPurchaseAccount.Properties.Appearance.Options.UseForeColor = True
        Me.cmbPurchaseAccount.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbPurchaseAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPurchaseAccount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbPurchaseAccount.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountID", "Account ID", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Account Name", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbPurchaseAccount.Properties.NullText = ""
        Me.cmbPurchaseAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbPurchaseAccount.Size = New System.Drawing.Size(232, 20)
        Me.cmbPurchaseAccount.StyleController = Me.LayoutMain
        Me.cmbPurchaseAccount.TabIndex = 21
        Me.cmbPurchaseAccount.Tag = "PurchaseAccountID"
        '
        'cmbSaleAccount
        '
        Me.cmbSaleAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSaleAccount.EditValue = ""
        Me.cmbSaleAccount.EnterMoveNextControl = True
        Me.cmbSaleAccount.Location = New System.Drawing.Point(109, 79)
        Me.cmbSaleAccount.Name = "cmbSaleAccount"
        Me.cmbSaleAccount.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbSaleAccount.Properties.Appearance.Options.UseForeColor = True
        Me.cmbSaleAccount.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbSaleAccount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSaleAccount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbSaleAccount.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountID", "Account ID", 10, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountName", "Account Name", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbSaleAccount.Properties.NullText = ""
        Me.cmbSaleAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbSaleAccount.Size = New System.Drawing.Size(232, 20)
        Me.cmbSaleAccount.StyleController = Me.LayoutMain
        Me.cmbSaleAccount.TabIndex = 21
        Me.cmbSaleAccount.Tag = "SaleAccountID"
        '
        'GridMain
        '
        Me.GridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridMain.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMain.Location = New System.Drawing.Point(13, 103)
        Me.GridMain.MainView = Me.GridView1
        Me.GridMain.Name = "GridMain"
        Me.GridMain.Size = New System.Drawing.Size(660, 225)
        Me.GridMain.TabIndex = 28
        Me.GridMain.TabStop = False
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView1.GridControl = Me.GridMain
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = " ID"
        Me.GridColumn1.FieldName = "DepartmentID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 85
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = " NAME"
        Me.GridColumn2.FieldName = "DepartmentName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 488
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridMain
        Me.GridView2.Name = "GridView2"
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.EnterMoveNextControl = True
        Me.txtName.Location = New System.Drawing.Point(109, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txtName.Properties.Appearance.Options.UseForeColor = True
        Me.txtName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Size = New System.Drawing.Size(564, 20)
        Me.txtName.StyleController = Me.LayoutMain
        Me.txtName.TabIndex = 2
        Me.txtName.Tag = "DepartmentName"
        Me.txtName.ToolTip = "Enter Department Name"
        '
        'txtID
        '
        Me.txtID.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtID.EnterMoveNextControl = True
        Me.txtID.Location = New System.Drawing.Point(89, 22)
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
        Me.txtID.Properties.MaskSettings.Set("mask", "d")
        Me.txtID.Properties.UseMaskAsDisplayFormat = True
        Me.txtID.Size = New System.Drawing.Size(77, 20)
        Me.txtID.StyleController = Me.LayoutMain
        Me.txtID.TabIndex = 0
        Me.txtID.Tag = "DepartmentID"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlGroup4, Me.EmptySpaceItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(686, 341)
        Me.LayoutControlGroup1.TextLocation = DevExpress.Utils.Locations.[Default]
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridMain
        Me.LayoutControlItem7.CustomizationFormText = "LayoutControlItem7"
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 90)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(664, 229)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(166, 42)
        Me.LayoutControlGroup4.Text = "LayoutControlGroup2"
        Me.LayoutControlGroup4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlItem1.AppearanceItemCaption.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem1.Control = Me.txtID
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "ID:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(152, 28)
        Me.LayoutControlItem1.Text = "Record ID :"
        Me.LayoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(62, 13)
        Me.LayoutControlItem1.TextToControlDistance = 5
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(498, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(166, 42)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(332, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(166, 42)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(166, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(166, 42)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtName
        Me.LayoutControlItem2.CustomizationFormText = "Name:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(664, 24)
        Me.LayoutControlItem2.Text = "Name :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.cmbSaleAccount
        Me.LayoutControlItem4.CustomizationFormText = "Sale Account:"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 66)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(332, 24)
        Me.LayoutControlItem4.Text = "Sale Account :"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.cmbPurchaseAccount
        Me.LayoutControlItem5.CustomizationFormText = "Purchase Account:"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(332, 66)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(332, 24)
        Me.LayoutControlItem5.Text = "Purchase Account :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(93, 13)
        '
        'barManager
        '
        Me.barManager.AllowQuickCustomization = False
        Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Commands})
        Me.barManager.DockControls.Add(Me.barDockControlTop)
        Me.barManager.DockControls.Add(Me.barDockControlBottom)
        Me.barManager.DockControls.Add(Me.barDockControlLeft)
        Me.barManager.DockControls.Add(Me.barDockControlRight)
        Me.barManager.Form = Me
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnRefresh, Me.btnSave})
        Me.barManager.MainMenu = Me.Commands
        Me.barManager.MaxItemId = 6
        '
        'Commands
        '
        Me.Commands.BarName = "Commands"
        Me.Commands.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Commands.DockCol = 0
        Me.Commands.DockRow = 0
        Me.Commands.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Commands.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnRefresh)})
        Me.Commands.OptionsBar.DistanceBetweenItems = 2
        Me.Commands.OptionsBar.DrawBorder = False
        Me.Commands.OptionsBar.MultiLine = True
        Me.Commands.OptionsBar.UseWholeRow = True
        Me.Commands.Text = "Commands"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(686, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 341)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(686, 40)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 341)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(686, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 341)
        '
        'frmDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 381)
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.LargeImage = CType(resources.GetObject("frmDepartment.IconOptions.LargeImage"), System.Drawing.Image)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Departments"
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.cmbPurchaseAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSaleAccount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmbPurchaseAccount As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbSaleAccount As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtID As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
