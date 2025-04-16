<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
    'Inherits DevExpress.XtraEditors.XtraForm
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim GridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
        Dim FormatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAttendance))
        Me.EECardView = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridMain = New DevExpress.XtraGrid.GridControl()
        Me.gvAttendance = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EEGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CommandRibbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiEmployee = New DevExpress.XtraBars.BarButtonItem()
        Me.popEmployee = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiActivities = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.lblDeviceInfo = New DevExpress.XtraBars.BarStaticItem()
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.bsiRecordsCount = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.EECardView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EEGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EECardView
        '
        Me.EECardView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.EECardView.GridControl = Me.GridMain
        Me.EECardView.Name = "EECardView"
        Me.EECardView.OptionsBehavior.FieldAutoHeight = True
        Me.EECardView.OptionsView.ShowQuickCustomizeButton = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "EmployeeID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.UnboundDataType = GetType(String)
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Photo"
        Me.GridColumn2.FieldName = "Photo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ShowCaption = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 9
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Name"
        Me.GridColumn3.FieldName = "Name"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "DOB"
        Me.GridColumn4.FieldName = "BrithDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Email"
        Me.GridColumn5.FieldName = "Email"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Mobile"
        Me.GridColumn6.FieldName = "MobilePhone"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Home"
        Me.GridColumn7.FieldName = "HomePhone"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "DOH"
        Me.GridColumn8.FieldName = "HireDate"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Title"
        Me.GridColumn9.FieldName = "JobTitle"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Department"
        Me.GridColumn10.FieldName = "DepartmentName"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        '
        'GridMain
        '
        Me.GridMain.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.EECardView
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.gvAttendance
        GridLevelNode2.RelationName = "Level2"
        Me.GridMain.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GridMain.Location = New System.Drawing.Point(0, 126)
        Me.GridMain.MainView = Me.EEGridView
        Me.GridMain.Name = "GridMain"
        Me.GridMain.Size = New System.Drawing.Size(1246, 605)
        Me.GridMain.TabIndex = 5
        Me.GridMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAttendance, Me.EEGridView, Me.EECardView})
        '
        'gvAttendance
        '
        Me.gvAttendance.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        GridFormatRule1.ApplyToRow = True
        GridFormatRule1.Column = Me.GridColumn19
        GridFormatRule1.Description = Nothing
        GridFormatRule1.Name = "CheckIN"
        FormatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue1.PredefinedName = "Green Text"
        FormatConditionRuleValue1.Value1 = CType(1, Short)
        GridFormatRule1.Rule = FormatConditionRuleValue1
        GridFormatRule2.ApplyToRow = True
        GridFormatRule2.Column = Me.GridColumn19
        GridFormatRule2.Description = Nothing
        GridFormatRule2.Name = "CheckOUT"
        FormatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
        FormatConditionRuleValue2.PredefinedName = "Red Text"
        FormatConditionRuleValue2.Value1 = CType(0, Short)
        GridFormatRule2.Rule = FormatConditionRuleValue2
        Me.gvAttendance.FormatRules.Add(GridFormatRule1)
        Me.gvAttendance.FormatRules.Add(GridFormatRule2)
        Me.gvAttendance.GridControl = Me.GridMain
        Me.gvAttendance.Name = "gvAttendance"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "ID"
        Me.GridColumn11.FieldName = "ID"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Name"
        Me.GridColumn12.FieldName = "Name"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 1
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Mode"
        Me.GridColumn13.FieldName = "Mode"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Dated"
        Me.GridColumn14.FieldName = "Dated"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Check IN"
        Me.GridColumn15.FieldName = "Checkin"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 4
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Check OUT"
        Me.GridColumn16.FieldName = "Checkout"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 5
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "TotalHours"
        Me.GridColumn17.FieldName = "TotalHours"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 6
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Status"
        Me.GridColumn18.FieldName = "Status"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 7
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "StatusID"
        Me.GridColumn19.FieldName = "StatusID"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'EEGridView
        '
        Me.EEGridView.GridControl = Me.GridMain
        Me.EEGridView.Name = "EEGridView"
        Me.EEGridView.OptionsView.RowAutoHeight = True
        Me.EEGridView.OptionsView.ShowFooter = True
        Me.EEGridView.OptionsView.ShowGroupPanel = False
        '
        'CommandRibbon
        '
        Me.CommandRibbon.ExpandCollapseItem.Id = 0
        Me.CommandRibbon.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.CommandRibbon.ExpandCollapseItem, Me.bbiEmployee, Me.bbiActivities, Me.bbiClose, Me.lblDeviceInfo, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.CommandRibbon.Location = New System.Drawing.Point(0, 0)
        Me.CommandRibbon.MaxItemId = 26
        Me.CommandRibbon.Name = "CommandRibbon"
        Me.CommandRibbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.CommandRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.CommandRibbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.CommandRibbon.Size = New System.Drawing.Size(1246, 126)
        Me.CommandRibbon.StatusBar = Me.ribbonStatusBar
        Me.CommandRibbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiEmployee
        '
        Me.bbiEmployee.ActAsDropDown = True
        Me.bbiEmployee.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.bbiEmployee.Caption = "Employees"
        Me.bbiEmployee.DropDownControl = Me.popEmployee
        Me.bbiEmployee.Id = 101
        Me.bbiEmployee.ImageOptions.Image = CType(resources.GetObject("bbiEmployee.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiEmployee.ImageOptions.LargeImage = CType(resources.GetObject("bbiEmployee.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiEmployee.Name = "bbiEmployee"
        '
        'popEmployee
        '
        Me.popEmployee.ItemLinks.Add(Me.BarButtonItem4)
        Me.popEmployee.ItemLinks.Add(Me.BarButtonItem3)
        Me.popEmployee.ItemLinks.Add(Me.BarButtonItem1)
        Me.popEmployee.ItemLinks.Add(Me.BarButtonItem2)
        Me.popEmployee.Name = "popEmployee"
        Me.popEmployee.Ribbon = Me.CommandRibbon
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "All Employess"
        Me.BarButtonItem4.Id = 1004
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Device Users"
        Me.BarButtonItem3.Id = 1003
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Dashboard View"
        Me.BarButtonItem1.Id = 1001
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Information View"
        Me.BarButtonItem2.Id = 1002
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'bbiActivities
        '
        Me.bbiActivities.Caption = "Activities"
        Me.bbiActivities.Id = 102
        Me.bbiActivities.ImageOptions.Image = CType(resources.GetObject("bbiActivities.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiActivities.ImageOptions.LargeImage = CType(resources.GetObject("bbiActivities.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiActivities.Name = "bbiActivities"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Close"
        Me.bbiClose.Id = 103
        Me.bbiClose.ImageOptions.Image = CType(resources.GetObject("bbiClose.ImageOptions.Image"), System.Drawing.Image)
        Me.bbiClose.ImageOptions.LargeImage = CType(resources.GetObject("bbiClose.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.bbiClose.Name = "bbiClose"
        '
        'lblDeviceInfo
        '
        Me.lblDeviceInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblDeviceInfo.Caption = "Status"
        Me.lblDeviceInfo.Id = 20
        Me.lblDeviceInfo.ImageOptions.Image = CType(resources.GetObject("lblDeviceInfo.ImageOptions.Image"), System.Drawing.Image)
        Me.lblDeviceInfo.Name = "lblDeviceInfo"
        Me.lblDeviceInfo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.MergeOrder = 0
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "Attendance"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.AllowTextClipping = False
        Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiEmployee)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiActivities)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.bbiClose)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.Text = "Tasks"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.bsiRecordsCount)
        Me.ribbonStatusBar.ItemLinks.Add(Me.lblDeviceInfo)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 704)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.CommandRibbon
        Me.ribbonStatusBar.Size = New System.Drawing.Size(1246, 27)
        '
        'bsiRecordsCount
        '
        Me.bsiRecordsCount.Caption = "RECORDS : 0"
        Me.bsiRecordsCount.Id = 15
        Me.bsiRecordsCount.Name = "bsiRecordsCount"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.GridMain)
        Me.Controls.Add(Me.CommandRibbon)
        Me.Name = "frmAttendance"
        Me.Size = New System.Drawing.Size(1246, 731)
        CType(Me.EECardView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EEGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandRibbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents CommandRibbon As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents bbiEmployee As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiActivities As DevExpress.XtraBars.BarButtonItem
    Private WithEvents bbiClose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private WithEvents ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridMain As DevExpress.XtraGrid.GridControl
    Friend WithEvents EEGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblDeviceInfo As DevExpress.XtraBars.BarStaticItem
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents bsiRecordsCount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents EECardView As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents popEmployee As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gvAttendance As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
End Class
