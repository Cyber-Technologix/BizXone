<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rfrmAccountLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rfrmAccountLedger))
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.dtStartDate = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.dtEndDate = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmbAccountsitem = New DevExpress.XtraLayout.LayoutControlItem()
        Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Commands = New DevExpress.XtraBars.Bar()
        Me.btnPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DxErrorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.cmbAccounts = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.dtStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtEndDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAccountsitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAccounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.dtStartDate)
        Me.MainLayout.Controls.Add(Me.dtEndDate)
        Me.MainLayout.Controls.Add(Me.cmbAccounts)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup1
        Me.MainLayout.Size = New System.Drawing.Size(586, 337)
        Me.MainLayout.TabIndex = 45
        '
        'dtStartDate
        '
        Me.dtStartDate.AutoSize = False
        Me.dtStartDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtStartDate.Location = New System.Drawing.Point(13, 70)
        Me.dtStartDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtStartDate.Name = "dtStartDate"
        Me.dtStartDate.Size = New System.Drawing.Size(278, 255)
        Me.dtStartDate.StyleController = Me.MainLayout
        Me.dtStartDate.TabIndex = 49
        '
        'dtEndDate
        '
        Me.dtEndDate.AutoSize = False
        Me.dtEndDate.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtEndDate.Location = New System.Drawing.Point(295, 70)
        Me.dtEndDate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dtEndDate.Name = "dtEndDate"
        Me.dtEndDate.Size = New System.Drawing.Size(278, 255)
        Me.dtEndDate.StyleController = Me.MainLayout
        Me.dtEndDate.TabIndex = 50
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.cmbAccountsitem})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(586, 337)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.dtStartDate
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "Start Date :"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 41)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(282, 276)
        Me.LayoutControlItem3.Text = "Start Date :"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtEndDate
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "End Date :"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(282, 41)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(282, 276)
        Me.LayoutControlItem4.Text = "End Date :"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(93, 13)
        '
        'cmbAccountsitem
        '
        Me.cmbAccountsitem.Control = Me.cmbAccounts
        Me.cmbAccountsitem.Location = New System.Drawing.Point(0, 0)
        Me.cmbAccountsitem.Name = "cmbAccountsitem"
        Me.cmbAccountsitem.Size = New System.Drawing.Size(564, 41)
        Me.cmbAccountsitem.Text = "&Select Account :"
        Me.cmbAccountsitem.TextLocation = DevExpress.Utils.Locations.Top
        Me.cmbAccountsitem.TextSize = New System.Drawing.Size(93, 13)
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
        Me.barDockControlTop.Size = New System.Drawing.Size(586, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 337)
        Me.barDockControlBottom.Manager = Me.barManager
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlBottom.Size = New System.Drawing.Size(586, 56)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 337)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(586, 0)
        Me.barDockControlRight.Manager = Me.barManager
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 337)
        '
        'DxErrorProvider
        '
        Me.DxErrorProvider.ContainerControl = Me
        '
        'cmbAccounts
        '
        Me.cmbAccounts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAccounts.EditValue = ""
        Me.cmbAccounts.Location = New System.Drawing.Point(13, 29)
        Me.cmbAccounts.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbAccounts.Name = "cmbAccounts"
        Me.cmbAccounts.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbAccounts.Properties.Appearance.Options.UseForeColor = True
        Me.cmbAccounts.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbAccounts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAccounts.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbAccounts.Properties.NullText = ""
        Me.cmbAccounts.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.cmbAccounts.Properties.Tag = ""
        Me.cmbAccounts.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cmbAccounts.Size = New System.Drawing.Size(560, 20)
        Me.cmbAccounts.StyleController = Me.MainLayout
        Me.cmbAccounts.TabIndex = 38
        Me.cmbAccounts.Tag = ""
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 933
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Account ID"
        Me.GridColumn1.FieldName = "AccountID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Account Name"
        Me.GridColumn8.FieldName = "AccountName"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Account Type"
        Me.GridColumn9.FieldName = "AccountTypeName"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Head Type"
        Me.GridColumn10.FieldName = "HeadTypeDesc"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Head Name"
        Me.GridColumn11.FieldName = "HeadName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Balance"
        Me.GridColumn12.FieldName = "CurrentBalance"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        '
        'rfrmAccountLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 393)
        Me.Controls.Add(Me.MainLayout)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rfrmAccountLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Ledger"
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.dtStartDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtEndDate.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAccountsitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAccounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbAccountsitem As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtStartDate As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents dtEndDate As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DxErrorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents cmbAccounts As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
End Class
