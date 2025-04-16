<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfrmInventory
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmInventory))
        Dim CompareAgainstControlValidationRule3 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.dtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarToggleSwitchItem1 = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.dtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.ddlInventoryType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddlInventoryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtStartDate
        '
        Me.dtStartDate.EditValue = Nothing
        Me.dtStartDate.Location = New System.Drawing.Point(12, 68)
        Me.dtStartDate.MenuManager = Me.barManager
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Properties.DisplayFormat.FormatString = "dddd, MMMM d, yyy"
        Me.dtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtStartDate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtStartDate.Properties.MaskSettings.Set("mask", "dddd, MMMM d, yyy")
        Me.dtStartDate.Size = New System.Drawing.Size(237, 20)
        Me.dtStartDate.StyleController = Me.MainLayout
        Me.dtStartDate.TabIndex = 56
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.LessOrEqual
        CompareAgainstControlValidationRule1.Control = Me.dtEndDate
        CompareAgainstControlValidationRule1.ErrorText = "This value is not valid"
        CompareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.dtStartDate, CompareAgainstControlValidationRule1)
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
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnPrintPreview, Me.BarToggleSwitchItem1})
        Me.barManager.MainMenu = Me.Commands
        Me.barManager.MaxItemId = 8
        '
        'Commands
        '
        Me.Commands.BarName = "Commands"
        Me.Commands.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Commands.DockCol = 0
        Me.Commands.DockRow = 0
        Me.Commands.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Commands.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrintPreview), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint)})
        Me.Commands.OptionsBar.DistanceBetweenItems = 2
        Me.Commands.OptionsBar.DrawBorder = False
        Me.Commands.OptionsBar.MultiLine = True
        Me.Commands.OptionsBar.UseWholeRow = True
        Me.Commands.Text = "Commands"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Caption = "Preview"
        Me.btnPrintPreview.Id = 1
        Me.btnPrintPreview.ImageOptions.Image = CType(resources.GetObject("btnPrintPreview.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintPreview.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintPreview.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.Id = 2
        Me.btnPrint.ImageOptions.Image = CType(resources.GetObject("btnPrint.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrint.ImageOptions.LargeImage = CType(resources.GetObject("btnPrint.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrint.Name = "btnPrint"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager
        Me.barDockControlTop.Size = New System.Drawing.Size(503, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 120)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(503, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 120)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(503, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 120)
        '
        'BarToggleSwitchItem1
        '
        Me.BarToggleSwitchItem1.Caption = "BarToggleSwitchItem1"
        Me.BarToggleSwitchItem1.Id = 7
        Me.BarToggleSwitchItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarToggleSwitchItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarToggleSwitchItem1.ImageOptions.SvgImage = CType(resources.GetObject("BarToggleSwitchItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.BarToggleSwitchItem1.Name = "BarToggleSwitchItem1"
        Me.BarToggleSwitchItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.dtStartDate)
        Me.MainLayout.Controls.Add(Me.dtEndDate)
        Me.MainLayout.Controls.Add(Me.ddlInventoryType)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup1
        Me.MainLayout.Size = New System.Drawing.Size(503, 120)
        Me.MainLayout.TabIndex = 42
        Me.MainLayout.Text = "LayoutControl1"
        '
        'dtEndDate
        '
        Me.dtEndDate.EditValue = Nothing
        Me.dtEndDate.Location = New System.Drawing.Point(253, 68)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Properties.DisplayFormat.FormatString = "dddd, MMMM d, yyy"
        Me.dtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEndDate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtEndDate.Properties.MaskSettings.Set("mask", "dddd, MMMM d, yyy")
        Me.dtEndDate.Size = New System.Drawing.Size(238, 20)
        Me.dtEndDate.StyleController = Me.MainLayout
        Me.dtEndDate.TabIndex = 57
        CompareAgainstControlValidationRule3.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.GreaterOrEqual
        CompareAgainstControlValidationRule3.Control = Me.dtStartDate
        CompareAgainstControlValidationRule3.ErrorText = "This value is not valid"
        CompareAgainstControlValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.dtEndDate, CompareAgainstControlValidationRule3)
        '
        'ddlInventoryType
        '
        Me.ddlInventoryType.EditValue = ""
        Me.ddlInventoryType.Location = New System.Drawing.Point(12, 28)
        Me.ddlInventoryType.MenuManager = Me.barManager
        Me.ddlInventoryType.Name = "ddlInventoryType"
        Me.ddlInventoryType.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlInventoryType.Properties.Appearance.Options.UseForeColor = True
        Me.ddlInventoryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlInventoryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ddlInventoryType.Size = New System.Drawing.Size(479, 20)
        Me.ddlInventoryType.StyleController = Me.MainLayout
        Me.ddlInventoryType.TabIndex = 55
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule2.ErrorText = "Empty or Null not allowed"
        ConditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.ddlInventoryType, ConditionValidationRule2)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem1})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(503, 120)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ddlInventoryType
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(483, 40)
        Me.LayoutControlItem2.Text = "Select Inventory :"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtStartDate
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(241, 40)
        Me.LayoutControlItem5.Text = "Start Date :"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(87, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtEndDate
        Me.LayoutControlItem6.Location = New System.Drawing.Point(241, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(242, 40)
        Me.LayoutControlItem6.Text = "End Date :"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(87, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 80)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(483, 20)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'rfrmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 176)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Inventory Report"
        CType(Me.dtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.dtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddlInventoryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarToggleSwitchItem1 As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents ddlInventoryType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents dtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
