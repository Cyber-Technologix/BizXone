<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserPrivileges
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserPrivileges))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lstUser = New DevExpress.XtraEditors.ListBoxControl()
        Me.grdUserRibbon = New DevExpress.XtraGrid.GridControl()
        Me.grdViewUser = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridBtnDeleteItem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grdRibbonCommands = New DevExpress.XtraGrid.GridControl()
        Me.grdViewMenu = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridBtnAddMenu = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddUser = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.lstUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdUserRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBtnDeleteItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRibbonCommands, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBtnAddMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lstUser)
        Me.LayoutControl1.Controls.Add(Me.grdUserRibbon)
        Me.LayoutControl1.Controls.Add(Me.grdRibbonCommands)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 126)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1234, 604)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lstUser
        '
        Me.lstUser.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUser.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lstUser.Appearance.Options.UseFont = True
        Me.lstUser.Appearance.Options.UseForeColor = True
        Me.lstUser.Location = New System.Drawing.Point(1011, 12)
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(211, 580)
        Me.lstUser.StyleController = Me.LayoutControl1
        Me.lstUser.TabIndex = 67
        '
        'grdUserRibbon
        '
        Me.grdUserRibbon.Location = New System.Drawing.Point(24, 325)
        Me.grdUserRibbon.MainView = Me.grdViewUser
        Me.grdUserRibbon.Name = "grdUserRibbon"
        Me.grdUserRibbon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GridBtnDeleteItem})
        Me.grdUserRibbon.Size = New System.Drawing.Size(971, 255)
        Me.grdUserRibbon.TabIndex = 66
        Me.grdUserRibbon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewUser})
        '
        'grdViewUser
        '
        Me.grdViewUser.Appearance.EvenRow.BackColor = System.Drawing.Color.LightCyan
        Me.grdViewUser.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdViewUser.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grdViewUser.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdViewUser.Appearance.OddRow.BackColor = System.Drawing.Color.Azure
        Me.grdViewUser.Appearance.OddRow.Options.UseBackColor = True
        Me.grdViewUser.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn9, Me.GridColumn3, Me.GridColumn10})
        Me.grdViewUser.GridControl = Me.grdUserRibbon
        Me.grdViewUser.Name = "grdViewUser"
        Me.grdViewUser.OptionsView.EnableAppearanceEvenRow = True
        Me.grdViewUser.OptionsView.EnableAppearanceOddRow = True
        Me.grdViewUser.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ItemID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Name"
        Me.GridColumn2.FieldName = "ItemName"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 112
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Hint"
        Me.GridColumn9.FieldName = "ItemHint"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Page"
        Me.GridColumn3.FieldName = "PageName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 112
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Action"
        Me.GridColumn10.ColumnEdit = Me.GridBtnDeleteItem
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.ReadOnly = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 50
        '
        'GridBtnDeleteItem
        '
        Me.GridBtnDeleteItem.AutoHeight = False
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.GridBtnDeleteItem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.GridBtnDeleteItem.Name = "GridBtnDeleteItem"
        Me.GridBtnDeleteItem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'grdRibbonCommands
        '
        Me.grdRibbonCommands.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRibbonCommands.Location = New System.Drawing.Point(27, 48)
        Me.grdRibbonCommands.MainView = Me.grdViewMenu
        Me.grdRibbonCommands.Name = "grdRibbonCommands"
        Me.grdRibbonCommands.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.GridBtnAddMenu})
        Me.grdRibbonCommands.Size = New System.Drawing.Size(965, 225)
        Me.grdRibbonCommands.TabIndex = 63
        Me.grdRibbonCommands.TabStop = False
        Me.grdRibbonCommands.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdViewMenu})
        '
        'grdViewMenu
        '
        Me.grdViewMenu.Appearance.EvenRow.BackColor = System.Drawing.Color.LightYellow
        Me.grdViewMenu.Appearance.EvenRow.Options.UseBackColor = True
        Me.grdViewMenu.Appearance.OddRow.BackColor = System.Drawing.Color.Ivory
        Me.grdViewMenu.Appearance.OddRow.Options.UseBackColor = True
        Me.grdViewMenu.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn4, Me.GridColumn7, Me.GridColumn8})
        Me.grdViewMenu.GridControl = Me.grdRibbonCommands
        Me.grdViewMenu.Name = "grdViewMenu"
        Me.grdViewMenu.OptionsBehavior.ReadOnly = True
        Me.grdViewMenu.OptionsView.EnableAppearanceEvenRow = True
        Me.grdViewMenu.OptionsView.EnableAppearanceOddRow = True
        Me.grdViewMenu.OptionsView.ShowGroupPanel = False
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "ID"
        Me.GridColumn5.FieldName = "ItemID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 50
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Name"
        Me.GridColumn6.FieldName = "ItemName"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.ReadOnly = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 268
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Hint"
        Me.GridColumn4.FieldName = "ItemHint"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Page"
        Me.GridColumn7.FieldName = "PageName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 166
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn8.Caption = "Action"
        Me.GridColumn8.ColumnEdit = Me.GridBtnAddMenu
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 50
        '
        'GridBtnAddMenu
        '
        Me.GridBtnAddMenu.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.GridBtnAddMenu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.GridBtnAddMenu.Name = "GridBtnAddMenu"
        Me.GridBtnAddMenu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Root
        '
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup5, Me.LayoutControlGroup4, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1234, 604)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup5
        '
        Me.LayoutControlGroup5.CustomizationFormText = "Avalible Menu...."
        Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
        Me.LayoutControlGroup5.OptionsItemText.TextToControlDistance = 3
        Me.LayoutControlGroup5.Size = New System.Drawing.Size(999, 280)
        Me.LayoutControlGroup5.Text = "Commands"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.grdRibbonCommands
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(975, 235)
        Me.LayoutControlItem3.Text = "LayoutControlItem2"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 280)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(999, 304)
        Me.LayoutControlGroup4.Text = "Granted Commands"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.grdUserRibbon
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(975, 259)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.lstUser
        Me.LayoutControlItem4.Location = New System.Drawing.Point(999, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(215, 584)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'CommandRibbon
        '
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiEdit, Me.bbiClose, Me.btnAddUser})
        Me.CommandRibbon.Location = New System.Drawing.Point(0, 0)
        Me.CommandRibbon.MaxItemId = 24
        Me.CommandRibbon.Name = "CommandRibbon"
        Me.CommandRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.CommandRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.CommandRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.Size = New System.Drawing.Size(1234, 126)
        Me.CommandRibbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiEdit
        '
        Me.bbiEdit.Caption = "Save"
        Me.bbiEdit.Id = 101
        Me.bbiEdit.ImageOptions.LargeImage = CType(resources.GetObject("bbiEdit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiEdit.Name = "bbiEdit"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Close"
        Me.bbiClose.Id = 104
        Me.bbiClose.ImageOptions.Image = CType(resources.GetObject("bbiClose.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiClose.ImageOptions.LargeImage = CType(resources.GetObject("bbiClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiClose.Name = "bbiClose"
        '
        'btnAddUser
        '
        Me.btnAddUser.Caption = "Add User"
        Me.btnAddUser.Id = 106
        Me.btnAddUser.ImageOptions.Image = CType(resources.GetObject("btnAddUser.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageOptions.LargeImage = CType(resources.GetObject("btnAddUser.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddUser.Name = "btnAddUser"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.RibbonPageGroup2})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "User Managment"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEdit)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiClose)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Command"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddUser)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Action"
        '
        'frmUserRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Name = "frmUserRoles"
        Me.Size = New System.Drawing.Size(1234, 730)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.lstUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdUserRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBtnDeleteItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRibbonCommands, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBtnAddMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private timer As System.Windows.Forms.Timer
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents grdRibbonCommands As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewMenu As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBtnAddMenu As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents grdUserRibbon As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdViewUser As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridBtnDeleteItem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents bbiEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAddUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lstUser As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
