<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rfrmProdLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmProdLedger))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtStartDate = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.dtEndDate = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.cmbProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.barDockControlTop.Size = New System.Drawing.Size(640, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 348)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlBottom.Size = New System.Drawing.Size(640, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 348)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(640, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 348)
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.cmbProduct)
        Me.MainLayout.Controls.Add(Me.dtStartDate)
        Me.MainLayout.Controls.Add(Me.dtEndDate)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup1
        Me.MainLayout.Size = New System.Drawing.Size(640, 348)
        Me.MainLayout.TabIndex = 48
        Me.MainLayout.Text = "LayoutControl1"
        '
        'cmbProduct
        '
        Me.cmbProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProduct.EditValue = ""
        Me.cmbProduct.EnterMoveNextControl = True
        Me.cmbProduct.Location = New System.Drawing.Point(13, 30)
        Me.cmbProduct.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbProduct.Properties.Appearance.Options.UseForeColor = True
        Me.cmbProduct.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProduct.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductID", "Product ID", 12, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name", 35, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.cmbProduct.Properties.NullText = ""
        Me.cmbProduct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbProduct.Size = New System.Drawing.Size(614, 20)
        Me.cmbProduct.StyleController = Me.MainLayout
        Me.cmbProduct.TabIndex = 53
        Me.cmbProduct.Tag = "ProductID"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = "Empty or Null not allowed"
        Me.dxValidationProvider.SetValidationRule(Me.cmbProduct, ConditionValidationRule1)
        '
        'dtStartDate
        '
        Me.dtStartDate.AutoSize = False
        Me.dtStartDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Location = New System.Drawing.Point(13, 72)
        Me.dtStartDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(303, 264)
        Me.dtStartDate.StyleController = Me.MainLayout
        Me.dtStartDate.TabIndex = 49
        '
        'dtEndDate
        '
        Me.dtEndDate.AutoSize = False
        Me.dtEndDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Location = New System.Drawing.Point(320, 71)
        Me.dtEndDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(307, 265)
        Me.dtEndDate.StyleController = Me.MainLayout
        Me.dtEndDate.TabIndex = 50
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(640, 348)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dtStartDate
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Start Date :"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(307, 286)
        Me.LayoutControlItem3.Text = "Start Date :"
        Me.LayoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
        Me.LayoutControlItem3.TextToControlDistance = 5
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtEndDate
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "End Date :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(307, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(311, 286)
        Me.LayoutControlItem4.Text = "End Date :"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(61, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbProduct
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(618, 42)
        Me.LayoutControlItem2.Text = "Select Product Name : "
        Me.LayoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(132, 13)
        Me.LayoutControlItem2.TextToControlDistance = 5
        '
        'rfrmProdLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 404)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmProdLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Ledger Report"
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.cmbProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtStartDate As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents dtEndDate As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
