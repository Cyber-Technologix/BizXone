<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rfrmWarehouseStock
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
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmWarehouseStock))
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.cmbWarehouse = New DevExpress.XtraEditors.LookUpEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.cmbWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.cmbWarehouse)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup1
        Me.MainLayout.Size = New System.Drawing.Size(309, 91)
        Me.MainLayout.TabIndex = 47
        Me.MainLayout.Text = "LayoutControl1"
        '
        'cmbWarehouse
        '
        Me.cmbWarehouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbWarehouse.EditValue = ""
        Me.cmbWarehouse.EnterMoveNextControl = True
        Me.cmbWarehouse.Location = New System.Drawing.Point(12, 28)
        Me.cmbWarehouse.Name = "cmbWarehouse"
        Me.cmbWarehouse.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbWarehouse.Properties.Appearance.Options.UseForeColor = True
        Me.cmbWarehouse.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbWarehouse.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbWarehouse.Properties.NullText = ""
        Me.cmbWarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbWarehouse.Size = New System.Drawing.Size(285, 20)
        Me.cmbWarehouse.StyleController = Me.MainLayout
        Me.cmbWarehouse.TabIndex = 54
        Me.cmbWarehouse.Tag = "WarehouseID"
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank
        ConditionValidationRule1.ErrorText = " No warehouse selected "
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.dxValidationProvider.SetValidationRule(Me.cmbWarehouse, ConditionValidationRule1)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(309, 91)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 40)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(289, 31)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cmbWarehouse
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(289, 40)
        Me.LayoutControlItem2.Text = "Select Warehouse :"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(94, 13)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(309, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 91)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(309, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 91)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(309, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 91)
        '
        'rfrmWarehouseStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 147)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmWarehouseStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warehouse Stock Report"
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.cmbWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmbWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
