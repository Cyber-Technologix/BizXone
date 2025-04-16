<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfrmClientInventoryReport
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
        Dim CompareAgainstControlValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmClientInventoryReport))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim CompareAgainstControlValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Me.dtStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.ddlInventoryType = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.cmbClient = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.ddlInventoryType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbClient.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtStartDate
        '
        Me.dtStartDate.EditValue = Nothing
        Me.dtStartDate.Location = New System.Drawing.Point(13, 111)
        Me.dtStartDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtStartDate.MenuManager = Me.barManager
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Properties.DisplayFormat.FormatString = "dddd, MMMM d, yyy"
        Me.dtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtStartDate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtStartDate.Properties.MaskSettings.Set("mask", "dddd, MMMM d, yyy")
        Me.dtStartDate.Size = New System.Drawing.Size(292, 20)
        Me.dtStartDate.StyleController = Me.MainLayout
        Me.dtStartDate.TabIndex = 53
        CompareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.LessOrEqual
        CompareAgainstControlValidationRule2.Control = Me.dtEndDate
        CompareAgainstControlValidationRule2.ErrorText = "This value is not valid"
        CompareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.dtStartDate, CompareAgainstControlValidationRule2)
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
        Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnPrint, Me.btnPrintPreview})
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlTop.Size = New System.Drawing.Size(616, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 152)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlBottom.Size = New System.Drawing.Size(616, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 152)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(616, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 152)
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.ddlInventoryType)
        Me.MainLayout.Controls.Add(Me.dtStartDate)
        Me.MainLayout.Controls.Add(Me.dtEndDate)
        Me.MainLayout.Controls.Add(Me.cmbClient)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup1
        Me.MainLayout.Size = New System.Drawing.Size(616, 152)
        Me.MainLayout.TabIndex = 47
        Me.MainLayout.Text = "LayoutControl1"
        '
        'ddlInventoryType
        '
        Me.ddlInventoryType.EditValue = ""
        Me.ddlInventoryType.Location = New System.Drawing.Point(13, 70)
        Me.ddlInventoryType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ddlInventoryType.MenuManager = Me.barManager
        Me.ddlInventoryType.Name = "ddlInventoryType"
        Me.ddlInventoryType.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlInventoryType.Properties.Appearance.Options.UseForeColor = True
        Me.ddlInventoryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlInventoryType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ddlInventoryType.Size = New System.Drawing.Size(590, 20)
        Me.ddlInventoryType.StyleController = Me.MainLayout
        Me.ddlInventoryType.TabIndex = 54
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Empty or Null not allowed"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.ddlInventoryType, ConditionValidationRule1)
        '
        'dtEndDate
        '
        Me.dtEndDate.EditValue = Nothing
        Me.dtEndDate.Location = New System.Drawing.Point(309, 111)
        Me.dtEndDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Properties.DisplayFormat.FormatString = "dddd, MMMM d, yyy"
        Me.dtEndDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtEndDate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtEndDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtEndDate.Properties.MaskSettings.Set("mask", "dddd, MMMM d, yyy")
        Me.dtEndDate.Size = New System.Drawing.Size(294, 20)
        Me.dtEndDate.StyleController = Me.MainLayout
        Me.dtEndDate.TabIndex = 53
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.GreaterOrEqual
        CompareAgainstControlValidationRule1.Control = Me.dtStartDate
        CompareAgainstControlValidationRule1.ErrorText = "This value is not valid"
        CompareAgainstControlValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.dtEndDate, CompareAgainstControlValidationRule1)
        '
        'cmbClient
        '
        Me.cmbClient.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbClient.EditValue = ""
        Me.cmbClient.Location = New System.Drawing.Point(13, 29)
        Me.cmbClient.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbClient.Name = "cmbClient"
        Me.cmbClient.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbClient.Properties.Appearance.Options.UseForeColor = True
        Me.cmbClient.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbClient.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbClient.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbClient.Properties.NullText = ""
        Me.cmbClient.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cmbClient.Size = New System.Drawing.Size(590, 20)
        Me.cmbClient.StyleController = Me.MainLayout
        Me.cmbClient.TabIndex = 42
        Me.cmbClient.Tag = "ClientID"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn1, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.GridColumn18})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 933
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Client Head"
        Me.GridColumn1.FieldName = "ClientHeadName"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 87
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem3, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(616, 152)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.cmbClient
        Me.LayoutControlItem1.CustomizationFormText = "Customer :"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(594, 41)
        Me.LayoutControlItem1.Text = "Client Name :"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtEndDate
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(296, 82)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(298, 50)
        Me.LayoutControlItem6.Text = "End Date :"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.ddlInventoryType
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 41)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(594, 41)
        Me.LayoutControlItem3.Text = "Inventory Type :"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(97, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dtStartDate
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(296, 50)
        Me.LayoutControlItem2.Text = "Start Date :"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(97, 13)
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "ID"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Name"
        Me.GridColumn8.FieldName = "ClientName"
        Me.GridColumn8.MinWidth = 23
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        Me.GridColumn8.Width = 87
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Address"
        Me.GridColumn10.FieldName = "Address"
        Me.GridColumn10.MinWidth = 23
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        Me.GridColumn10.Width = 87
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Mobile#"
        Me.GridColumn11.FieldName = "MobileNo"
        Me.GridColumn11.MinWidth = 23
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 87
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Balance"
        Me.GridColumn18.FieldName = "Balance"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 5
        '
        'rfrmClientInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 208)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmClientInventoryReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client Inventory Report"
        CType(Me.dtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.ddlInventoryType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbClient.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents MainLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ddlInventoryType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents cmbClient As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
End Class
