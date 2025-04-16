Imports DevExpress.XtraData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewer))
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains1 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains2 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule3 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains3 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule4 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains4 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule5 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains5 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule6 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains6 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule7 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains7 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule8 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains8 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule9 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains9 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule10 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains10 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule11 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains11 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Dim GridFormatRule12 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleContains12 As DevExpress.XtraEditors.FormatConditionRuleContains = New DevExpress.XtraEditors.FormatConditionRuleContains()
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiPrintPreview = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.TabWarehouse = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GridWarehouse = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabExpiry = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GridExpring = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPrice = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.GridPriceView = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabMain = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabOCR = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.TablePanel1 = New DevExpress.Utils.Layout.TablePanel()
        Me.lstDocment = New DevExpress.XtraEditors.ListBoxControl()
        Me.GridPdf = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPdf = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbDistributor = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabWarehouse.SuspendLayout()
        CType(Me.GridWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabExpiry.SuspendLayout()
        CType(Me.GridExpring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPrice.SuspendLayout()
        CType(Me.GridPriceView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMain.SuspendLayout()
        Me.TabOCR.SuspendLayout()
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TablePanel1.SuspendLayout()
        CType(Me.lstDocment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDistributor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CommandRibbon
        '
        Me.CommandRibbon.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(35, 30, 35, 30)
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiRefresh, Me.bbiPrintPreview, Me.BarButtonItem1})
        Me.CommandRibbon.Location = New System.Drawing.Point(0, 0)
        Me.CommandRibbon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CommandRibbon.MaxItemId = 23
        Me.CommandRibbon.Name = "CommandRibbon"
        Me.CommandRibbon.OptionsMenuMinWidth = 385
        Me.CommandRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.CommandRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.CommandRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.Size = New System.Drawing.Size(1400, 126)
        Me.CommandRibbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        'bbiPrintPreview
        '
        Me.bbiPrintPreview.Caption = "Print Preview"
        Me.bbiPrintPreview.Id = 201
        Me.bbiPrintPreview.ImageOptions.Image = CType(resources.GetObject("bbiPrintPreview.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiPrintPreview.ImageOptions.LargeImage = CType(resources.GetObject("bbiPrintPreview.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiPrintPreview.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.bbiPrintPreview.Name = "bbiPrintPreview"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Close"
        Me.BarButtonItem1.Id = 22
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F4)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Analysis"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiRefresh)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Commands"
        '
        'TabWarehouse
        '
        Me.TabWarehouse.Caption = "Warehouse"
        Me.TabWarehouse.Controls.Add(Me.GridWarehouse)
        Me.TabWarehouse.ImageOptions.Image = CType(resources.GetObject("TabWarehouse.ImageOptions.Image"), System.Drawing.Image)
        Me.TabWarehouse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabWarehouse.Name = "TabWarehouse"
        Me.TabWarehouse.Size = New System.Drawing.Size(1400, 491)
        '
        'GridWarehouse
        '
        Me.GridWarehouse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWarehouse.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridWarehouse.Location = New System.Drawing.Point(0, 0)
        Me.GridWarehouse.MainView = Me.GridView3
        Me.GridWarehouse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridWarehouse.Name = "GridWarehouse"
        Me.GridWarehouse.Size = New System.Drawing.Size(1400, 491)
        Me.GridWarehouse.TabIndex = 67
        Me.GridWarehouse.TabStop = False
        Me.GridWarehouse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Description = Nothing
        GridFormatRule1.Name = "Closed Account"
        FormatConditionRuleContains1.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        FormatConditionRuleContains1.Appearance.Options.UseFont = True
        FormatConditionRuleContains1.PredefinedName = "Red Fill"
        FormatConditionRuleContains1.Values = CType(resources.GetObject("FormatConditionRuleContains1.Values"), System.Collections.IList)
        GridFormatRule1.Rule = FormatConditionRuleContains1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Description = Nothing
        GridFormatRule2.Name = "Transfered Account"
        FormatConditionRuleContains2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleContains2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleContains2.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains2.Appearance.Options.UseFont = True
        FormatConditionRuleContains2.Values = CType(resources.GetObject("FormatConditionRuleContains2.Values"), System.Collections.IList)
        GridFormatRule2.Rule = FormatConditionRuleContains2
        GridFormatRule3.ApplyToRow = True
        GridFormatRule3.Description = Nothing
        GridFormatRule3.Name = "Disabled Account"
        FormatConditionRuleContains3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleContains3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleContains3.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains3.Appearance.Options.UseFont = True
        FormatConditionRuleContains3.Values = CType(resources.GetObject("FormatConditionRuleContains3.Values"), System.Collections.IList)
        GridFormatRule3.Rule = FormatConditionRuleContains3
        Me.GridView3.FormatRules.Add(GridFormatRule1)
        Me.GridView3.FormatRules.Add(GridFormatRule2)
        Me.GridView3.FormatRules.Add(GridFormatRule3)
        Me.GridView3.GridControl = Me.GridWarehouse
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.OptionsEditForm.PopupEditFormWidth = 933
        Me.GridView3.OptionsFind.AlwaysVisible = True
        Me.GridView3.OptionsFind.ShowCloseButton = False
        Me.GridView3.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowFooter = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'TabExpiry
        '
        Me.TabExpiry.Caption = "Expiration"
        Me.TabExpiry.Controls.Add(Me.GridExpring)
        Me.TabExpiry.ImageOptions.Image = CType(resources.GetObject("TabExpiry.ImageOptions.Image"), System.Drawing.Image)
        Me.TabExpiry.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabExpiry.Name = "TabExpiry"
        Me.TabExpiry.Size = New System.Drawing.Size(1400, 491)
        '
        'GridExpring
        '
        Me.GridExpring.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridExpring.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridExpring.Location = New System.Drawing.Point(0, 0)
        Me.GridExpring.MainView = Me.GridView2
        Me.GridExpring.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridExpring.Name = "GridExpring"
        Me.GridExpring.Size = New System.Drawing.Size(1400, 491)
        Me.GridExpring.TabIndex = 66
        Me.GridExpring.TabStop = False
        Me.GridExpring.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        GridFormatRule4.ApplyToRow = True
        GridFormatRule4.Description = Nothing
        GridFormatRule4.Name = "Closed Account"
        FormatConditionRuleContains4.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        FormatConditionRuleContains4.Appearance.Options.UseFont = True
        FormatConditionRuleContains4.PredefinedName = "Red Fill"
        FormatConditionRuleContains4.Values = CType(resources.GetObject("FormatConditionRuleContains4.Values"), System.Collections.IList)
        GridFormatRule4.Rule = FormatConditionRuleContains4
        GridFormatRule5.ApplyToRow = True
        GridFormatRule5.Description = Nothing
        GridFormatRule5.Name = "Transfered Account"
        FormatConditionRuleContains5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleContains5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleContains5.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains5.Appearance.Options.UseFont = True
        FormatConditionRuleContains5.Values = CType(resources.GetObject("FormatConditionRuleContains5.Values"), System.Collections.IList)
        GridFormatRule5.Rule = FormatConditionRuleContains5
        GridFormatRule6.ApplyToRow = True
        GridFormatRule6.Description = Nothing
        GridFormatRule6.Name = "Disabled Account"
        FormatConditionRuleContains6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleContains6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleContains6.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains6.Appearance.Options.UseFont = True
        FormatConditionRuleContains6.Values = CType(resources.GetObject("FormatConditionRuleContains6.Values"), System.Collections.IList)
        GridFormatRule6.Rule = FormatConditionRuleContains6
        Me.GridView2.FormatRules.Add(GridFormatRule4)
        Me.GridView2.FormatRules.Add(GridFormatRule5)
        Me.GridView2.FormatRules.Add(GridFormatRule6)
        Me.GridView2.GridControl = Me.GridExpring
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsEditForm.PopupEditFormWidth = 933
        Me.GridView2.OptionsFind.AlwaysVisible = True
        Me.GridView2.OptionsFind.ShowCloseButton = False
        Me.GridView2.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowFooter = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Warehouse"
        Me.GridColumn1.FieldName = "WarehouseName"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 87
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Department"
        Me.GridColumn2.FieldName = "DepartmentName"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 87
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ProductI D"
        Me.GridColumn3.FieldName = "ProductID"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 87
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Barcode"
        Me.GridColumn4.FieldName = "Barcode"
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 87
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "ProductName"
        Me.GridColumn5.FieldName = "ProductName"
        Me.GridColumn5.MinWidth = 23
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 87
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "EXP Date"
        Me.GridColumn6.FieldName = "EXPDate"
        Me.GridColumn6.MinWidth = 23
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 87
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Balance"
        Me.GridColumn7.FieldName = "Balance"
        Me.GridColumn7.MinWidth = 23
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 87
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Stock"
        Me.GridColumn8.FieldName = "Stock"
        Me.GridColumn8.MinWidth = 23
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 87
        '
        'TabPrice
        '
        Me.TabPrice.Caption = "Product Costing"
        Me.TabPrice.Controls.Add(Me.GridPriceView)
        Me.TabPrice.Font = New System.Drawing.Font("Bahnschrift Condensed", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrice.ImageOptions.Image = CType(resources.GetObject("TabPrice.ImageOptions.Image"), System.Drawing.Image)
        Me.TabPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPrice.Name = "TabPrice"
        Me.TabPrice.Properties.AppearanceCaption.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPrice.Properties.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPrice.Properties.AppearanceCaption.Options.UseFont = True
        Me.TabPrice.Properties.AppearanceCaption.Options.UseForeColor = True
        Me.TabPrice.Size = New System.Drawing.Size(1400, 491)
        '
        'GridPriceView
        '
        Me.GridPriceView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPriceView.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridPriceView.Location = New System.Drawing.Point(0, 0)
        Me.GridPriceView.MainView = Me.GridView1
        Me.GridPriceView.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridPriceView.Name = "GridPriceView"
        Me.GridPriceView.Size = New System.Drawing.Size(1400, 491)
        Me.GridPriceView.TabIndex = 65
        Me.GridPriceView.TabStop = False
        Me.GridPriceView.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        GridFormatRule7.ApplyToRow = True
        GridFormatRule7.Description = Nothing
        GridFormatRule7.Name = "Closed Account"
        FormatConditionRuleContains7.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        FormatConditionRuleContains7.Appearance.Options.UseFont = True
        FormatConditionRuleContains7.PredefinedName = "Red Fill"
        FormatConditionRuleContains7.Values = CType(resources.GetObject("FormatConditionRuleContains7.Values"), System.Collections.IList)
        GridFormatRule7.Rule = FormatConditionRuleContains7
        GridFormatRule8.ApplyToRow = True
        GridFormatRule8.Description = Nothing
        GridFormatRule8.Name = "Transfered Account"
        FormatConditionRuleContains8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleContains8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleContains8.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains8.Appearance.Options.UseFont = True
        FormatConditionRuleContains8.Values = CType(resources.GetObject("FormatConditionRuleContains8.Values"), System.Collections.IList)
        GridFormatRule8.Rule = FormatConditionRuleContains8
        GridFormatRule9.ApplyToRow = True
        GridFormatRule9.Description = Nothing
        GridFormatRule9.Name = "Disabled Account"
        FormatConditionRuleContains9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleContains9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleContains9.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains9.Appearance.Options.UseFont = True
        FormatConditionRuleContains9.Values = CType(resources.GetObject("FormatConditionRuleContains9.Values"), System.Collections.IList)
        GridFormatRule9.Rule = FormatConditionRuleContains9
        Me.GridView1.FormatRules.Add(GridFormatRule7)
        Me.GridView1.FormatRules.Add(GridFormatRule8)
        Me.GridView1.FormatRules.Add(GridFormatRule9)
        Me.GridView1.GridControl = Me.GridPriceView
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsEditForm.PopupEditFormWidth = 933
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.ShowCloseButton = False
        Me.GridView1.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'TabMain
        '
        Me.TabMain.AllowHtmlDraw = False
        Me.TabMain.Controls.Add(Me.TabPrice)
        Me.TabMain.Controls.Add(Me.TabExpiry)
        Me.TabMain.Controls.Add(Me.TabWarehouse)
        Me.TabMain.Controls.Add(Me.TabOCR)
        Me.TabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMain.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabMain.Location = New System.Drawing.Point(0, 126)
        Me.TabMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText
        Me.TabMain.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabPrice, Me.TabExpiry, Me.TabWarehouse, Me.TabOCR})
        Me.TabMain.RegularSize = New System.Drawing.Size(1400, 524)
        Me.TabMain.SelectedPage = Me.TabPrice
        Me.TabMain.Size = New System.Drawing.Size(1400, 524)
        Me.TabMain.TabIndex = 2
        Me.TabMain.Text = "TabPane1"
        '
        'TabOCR
        '
        Me.TabOCR.Caption = "PDF Files View"
        Me.TabOCR.Controls.Add(Me.TablePanel1)
        Me.TabOCR.ImageOptions.Image = CType(resources.GetObject("TabOCR.ImageOptions.Image"), System.Drawing.Image)
        Me.TabOCR.Name = "TabOCR"
        Me.TabOCR.Size = New System.Drawing.Size(1400, 491)
        '
        'TablePanel1
        '
        Me.TablePanel1.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 89.96!), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15.04!)})
        Me.TablePanel1.Controls.Add(Me.lstDocment)
        Me.TablePanel1.Controls.Add(Me.GridPdf)
        Me.TablePanel1.Controls.Add(Me.cmbDistributor)
        Me.TablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TablePanel1.Location = New System.Drawing.Point(0, 0)
        Me.TablePanel1.Name = "TablePanel1"
        Me.TablePanel1.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26.0!), New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.0!)})
        Me.TablePanel1.Size = New System.Drawing.Size(1400, 491)
        Me.TablePanel1.TabIndex = 70
        Me.TablePanel1.UseSkinIndents = True
        '
        'lstDocment
        '
        Me.lstDocment.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDocment.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lstDocment.Appearance.Options.UseFont = True
        Me.lstDocment.Appearance.Options.UseForeColor = True
        Me.TablePanel1.SetColumn(Me.lstDocment, 1)
        Me.lstDocment.Location = New System.Drawing.Point(1196, 39)
        Me.lstDocment.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstDocment.Name = "lstDocment"
        Me.TablePanel1.SetRow(Me.lstDocment, 1)
        Me.lstDocment.Size = New System.Drawing.Size(189, 438)
        Me.lstDocment.TabIndex = 71
        '
        'GridPdf
        '
        Me.TablePanel1.SetColumn(Me.GridPdf, 0)
        Me.GridPdf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPdf.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridPdf.Location = New System.Drawing.Point(15, 39)
        Me.GridPdf.MainView = Me.GridViewPdf
        Me.GridPdf.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GridPdf.Name = "GridPdf"
        Me.TablePanel1.SetRow(Me.GridPdf, 1)
        Me.GridPdf.Size = New System.Drawing.Size(1173, 438)
        Me.GridPdf.TabIndex = 70
        Me.GridPdf.TabStop = False
        Me.GridPdf.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPdf})
        '
        'GridViewPdf
        '
        GridFormatRule10.ApplyToRow = True
        GridFormatRule10.Description = Nothing
        GridFormatRule10.Name = "Closed Account"
        FormatConditionRuleContains10.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        FormatConditionRuleContains10.Appearance.Options.UseFont = True
        FormatConditionRuleContains10.PredefinedName = "Red Fill"
        FormatConditionRuleContains10.Values = CType(resources.GetObject("FormatConditionRuleContains10.Values"), System.Collections.IList)
        GridFormatRule10.Rule = FormatConditionRuleContains10
        GridFormatRule11.ApplyToRow = True
        GridFormatRule11.Description = Nothing
        GridFormatRule11.Name = "Transfered Account"
        FormatConditionRuleContains11.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        FormatConditionRuleContains11.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatConditionRuleContains11.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains11.Appearance.Options.UseFont = True
        FormatConditionRuleContains11.Values = CType(resources.GetObject("FormatConditionRuleContains11.Values"), System.Collections.IList)
        GridFormatRule11.Rule = FormatConditionRuleContains11
        GridFormatRule12.ApplyToRow = True
        GridFormatRule12.Description = Nothing
        GridFormatRule12.Name = "Disabled Account"
        FormatConditionRuleContains12.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        FormatConditionRuleContains12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        FormatConditionRuleContains12.Appearance.Options.UseBackColor = True
        FormatConditionRuleContains12.Appearance.Options.UseFont = True
        FormatConditionRuleContains12.Values = CType(resources.GetObject("FormatConditionRuleContains12.Values"), System.Collections.IList)
        GridFormatRule12.Rule = FormatConditionRuleContains12
        Me.GridViewPdf.FormatRules.Add(GridFormatRule10)
        Me.GridViewPdf.FormatRules.Add(GridFormatRule11)
        Me.GridViewPdf.FormatRules.Add(GridFormatRule12)
        Me.GridViewPdf.GridControl = Me.GridPdf
        Me.GridViewPdf.Name = "GridViewPdf"
        Me.GridViewPdf.OptionsBehavior.ReadOnly = True
        Me.GridViewPdf.OptionsEditForm.PopupEditFormWidth = 933
        Me.GridViewPdf.OptionsFind.AlwaysVisible = True
        Me.GridViewPdf.OptionsFind.ShowCloseButton = False
        Me.GridViewPdf.OptionsMenu.ShowConditionalFormattingItem = True
        Me.GridViewPdf.OptionsView.ShowAutoFilterRow = True
        Me.GridViewPdf.OptionsView.ShowFooter = True
        Me.GridViewPdf.OptionsView.ShowGroupPanel = False
        Me.GridViewPdf.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'cmbDistributor
        '
        Me.cmbDistributor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablePanel1.SetColumn(Me.cmbDistributor, 0)
        Me.cmbDistributor.EditValue = ""
        Me.cmbDistributor.EnterMoveNextControl = True
        Me.cmbDistributor.Location = New System.Drawing.Point(15, 13)
        Me.cmbDistributor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbDistributor.Name = "cmbDistributor"
        Me.cmbDistributor.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.cmbDistributor.Properties.Appearance.Options.UseForeColor = True
        Me.cmbDistributor.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.cmbDistributor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDistributor.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cmbDistributor.Properties.NullText = ""
        Me.cmbDistributor.Properties.PopupView = Me.SearchLookUpEdit1View
        Me.TablePanel1.SetRow(Me.cmbDistributor, 0)
        Me.cmbDistributor.Size = New System.Drawing.Size(1173, 20)
        Me.cmbDistributor.TabIndex = 69
        Me.cmbDistributor.Tag = "DistributorName"
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsEditForm.PopupEditFormWidth = 933
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Distributor Name"
        Me.GridColumn10.FieldName = "DistributorName"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 0
        '
        'frmViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmViewer"
        Me.Size = New System.Drawing.Size(1400, 650)
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabWarehouse.ResumeLayout(False)
        CType(Me.GridWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabExpiry.ResumeLayout(False)
        CType(Me.GridExpring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPrice.ResumeLayout(False)
        CType(Me.GridPriceView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMain.ResumeLayout(False)
        Me.TabOCR.ResumeLayout(False)
        CType(Me.TablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TablePanel1.ResumeLayout(False)
        CType(Me.lstDocment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDistributor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents bbiRefresh As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bbiPrintPreview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TabWarehouse As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GridWarehouse As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabExpiry As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GridExpring As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabPrice As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GridPriceView As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabMain As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabOCR As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents cmbDistributor As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TablePanel1 As DevExpress.Utils.Layout.TablePanel
    Friend WithEvents GridPdf As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPdf As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lstDocment As DevExpress.XtraEditors.ListBoxControl
End Class
