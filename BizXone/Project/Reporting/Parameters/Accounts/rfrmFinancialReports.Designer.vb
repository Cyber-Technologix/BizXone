<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfrmFinancialReports
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
        Dim StubGlyphOptions1 As DevExpress.Utils.Drawing.StubGlyphOptions = New DevExpress.Utils.Drawing.StubGlyphOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmFinancialReports))
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.ddlReport = New DevExpress.XtraEditors.ImageComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.ddlReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.ddlReport)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.Root
        Me.MainLayout.Size = New System.Drawing.Size(388, 106)
        Me.MainLayout.TabIndex = 48
        Me.MainLayout.Text = "LayoutControl1"
        '
        'ddlReport
        '
        Me.ddlReport.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BehaviorManager1.SetBehaviors(Me.ddlReport, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.StubGlyphBehaviorSourceForImageComboBox), StubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior)})
        Me.ddlReport.EditValue = ""
        Me.ddlReport.Location = New System.Drawing.Point(12, 49)
        Me.ddlReport.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ddlReport.Name = "ddlReport"
        Me.ddlReport.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.ddlReport.Properties.Appearance.Options.UseForeColor = True
        Me.ddlReport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ddlReport.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ddlReport.Properties.PopupSizeable = True
        Me.ddlReport.Properties.Tag = ""
        Me.ddlReport.Size = New System.Drawing.Size(364, 20)
        Me.ddlReport.StyleController = Me.MainLayout
        Me.ddlReport.TabIndex = 50
        Me.ddlReport.Tag = "PeriodID"
        '
        'Root
        '
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(388, 106)
        Me.Root.Text = "All financial reports "
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ddlReport
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(368, 40)
        Me.LayoutControlItem1.Text = "Select report :"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(83, 13)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 40)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(368, 25)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(388, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 106)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlBottom.Size = New System.Drawing.Size(388, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 106)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(388, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 106)
        '
        'rfrmFinancialReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 162)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmFinancialReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Financial Reports"
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.ddlReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents barManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Commands As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ddlReport As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
End Class
