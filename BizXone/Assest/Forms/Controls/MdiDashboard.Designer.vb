<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MdiDashboard
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
        Dim CustomHeaderButtonImageOptions1 As DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions = New DevExpress.XtraBars.Docking.CustomHeaderButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiDashboard))
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.DPTasks = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel6_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DPClock = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.DPCalender = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.CalendarControl1 = New DevExpress.XtraEditors.Controls.CalendarControl()
        Me.LayoutMain = New DevExpress.XtraLayout.LayoutControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DPTasks.SuspendLayout()
        Me.panelContainer1.SuspendLayout()
        Me.DPClock.SuspendLayout()
        Me.DockPanel3_Container.SuspendLayout()
        Me.DPCalender.SuspendLayout()
        Me.DockPanel4_Container.SuspendLayout()
        CType(Me.CalendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutMain.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.Controller = Me.BarAndDockingController1
        Me.DockManager1.DockingOptions.ShowCaptionImage = True
        Me.DockManager1.Form = Me
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DPTasks, Me.panelContainer1})
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.AppearancesDocking.PanelCaption.Options.UseFont = True
        '
        'DPTasks
        '
        Me.DPTasks.Controls.Add(Me.DockPanel6_Container)
        CustomHeaderButtonImageOptions1.Image = CType(resources.GetObject("CustomHeaderButtonImageOptions1.Image"), System.Drawing.Image)
        Me.DPTasks.CustomHeaderButtons.AddRange(New DevExpress.XtraBars.Docking2010.IButton() {New DevExpress.XtraBars.Docking.CustomHeaderButton("Add Task", True, CustomHeaderButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, SerializableAppearanceObject1, Nothing, -1)})
        Me.DPTasks.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom
        Me.DPTasks.FloatSize = New System.Drawing.Size(192, 79)
        Me.DPTasks.FloatVertical = True
        Me.DPTasks.ID = New System.Guid("8022ea93-1746-4b80-8895-951c3f88df4f")
        Me.DPTasks.ImageOptions.Image = CType(resources.GetObject("DPTasks.ImageOptions.Image"), System.Drawing.Image)
        Me.DPTasks.Location = New System.Drawing.Point(0, 430)
        Me.DPTasks.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DPTasks.Name = "DPTasks"
        Me.DPTasks.OriginalSize = New System.Drawing.Size(505, 220)
        Me.DPTasks.Size = New System.Drawing.Size(1400, 220)
        Me.DPTasks.Text = "Task List"
        '
        'DockPanel6_Container
        '
        Me.DockPanel6_Container.Location = New System.Drawing.Point(3, 33)
        Me.DockPanel6_Container.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DockPanel6_Container.Name = "DockPanel6_Container"
        Me.DockPanel6_Container.Size = New System.Drawing.Size(1394, 184)
        Me.DockPanel6_Container.TabIndex = 0
        '
        'panelContainer1
        '
        Me.panelContainer1.Controls.Add(Me.DPClock)
        Me.panelContainer1.Controls.Add(Me.DPCalender)
        Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.panelContainer1.ID = New System.Guid("f993b29b-a4e3-4fff-b791-336556afe14c")
        Me.panelContainer1.Location = New System.Drawing.Point(1167, 0)
        Me.panelContainer1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelContainer1.Name = "panelContainer1"
        Me.panelContainer1.OriginalSize = New System.Drawing.Size(233, 200)
        Me.panelContainer1.Size = New System.Drawing.Size(233, 430)
        Me.panelContainer1.Text = "panelContainer1"
        '
        'DPClock
        '
        Me.DPClock.Controls.Add(Me.DockPanel3_Container)
        Me.DPClock.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.DPClock.FloatSize = New System.Drawing.Size(192, 30)
        Me.DPClock.ID = New System.Guid("c877ec74-22de-455c-a1af-7f249158f35e")
        Me.DPClock.ImageOptions.Image = CType(resources.GetObject("DPClock.ImageOptions.Image"), System.Drawing.Image)
        Me.DPClock.Location = New System.Drawing.Point(0, 0)
        Me.DPClock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DPClock.Name = "DPClock"
        Me.DPClock.Options.ShowCloseButton = False
        Me.DPClock.Options.ShowMaximizeButton = False
        Me.DPClock.Options.ShowMinimizeButton = False
        Me.DPClock.OriginalSize = New System.Drawing.Size(233, 102)
        Me.DPClock.Size = New System.Drawing.Size(233, 102)
        Me.DPClock.Text = "Clock"
        '
        'DockPanel3_Container
        '
        Me.DockPanel3_Container.Controls.Add(Me.labelControl1)
        Me.DockPanel3_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel3_Container.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DockPanel3_Container.Name = "DockPanel3_Container"
        Me.DockPanel3_Container.Size = New System.Drawing.Size(226, 72)
        Me.DockPanel3_Container.TabIndex = 0
        '
        'labelControl1
        '
        Me.labelControl1.AllowHtmlString = True
        Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelControl1.Appearance.ForeColor = System.Drawing.Color.DimGray
        Me.labelControl1.Appearance.Options.UseFont = True
        Me.labelControl1.Appearance.Options.UseForeColor = True
        Me.labelControl1.Appearance.Options.UseTextOptions = True
        Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelControl1.Location = New System.Drawing.Point(0, 0)
        Me.labelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(226, 72)
        Me.labelControl1.TabIndex = 2
        Me.labelControl1.Text = "labelControl1"
        '
        'DPCalender
        '
        Me.DPCalender.Controls.Add(Me.DockPanel4_Container)
        Me.DPCalender.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
        Me.DPCalender.FloatSize = New System.Drawing.Size(192, 62)
        Me.DPCalender.ID = New System.Guid("738b384f-0492-4937-b821-2c8fc902f64d")
        Me.DPCalender.ImageOptions.Image = CType(resources.GetObject("DPCalender.ImageOptions.Image"), System.Drawing.Image)
        Me.DPCalender.Location = New System.Drawing.Point(0, 102)
        Me.DPCalender.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DPCalender.Name = "DPCalender"
        Me.DPCalender.Options.ShowCloseButton = False
        Me.DPCalender.Options.ShowMaximizeButton = False
        Me.DPCalender.Options.ShowMinimizeButton = False
        Me.DPCalender.OriginalSize = New System.Drawing.Size(233, 328)
        Me.DPCalender.Size = New System.Drawing.Size(233, 328)
        Me.DPCalender.Text = "Calender"
        '
        'DockPanel4_Container
        '
        Me.DockPanel4_Container.Controls.Add(Me.CalendarControl1)
        Me.DockPanel4_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel4_Container.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DockPanel4_Container.Name = "DockPanel4_Container"
        Me.DockPanel4_Container.Size = New System.Drawing.Size(226, 299)
        Me.DockPanel4_Container.TabIndex = 0
        '
        'CalendarControl1
        '
        Me.CalendarControl1.AutoSize = False
        Me.CalendarControl1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalendarControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CalendarControl1.Location = New System.Drawing.Point(0, 0)
        Me.CalendarControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CalendarControl1.Name = "CalendarControl1"
        Me.CalendarControl1.Size = New System.Drawing.Size(226, 299)
        Me.CalendarControl1.TabIndex = 52
        '
        'LayoutMain
        '
        Me.LayoutMain.Controls.Add(Me.PictureEdit1)
        Me.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutMain.Location = New System.Drawing.Point(0, 0)
        Me.LayoutMain.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LayoutMain.Name = "LayoutMain"
        Me.LayoutMain.Root = Me.Root
        Me.LayoutMain.Size = New System.Drawing.Size(1167, 430)
        Me.LayoutMain.TabIndex = 5
        Me.LayoutMain.Text = "LayoutControl1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(13, 12)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(1141, 406)
        Me.PictureEdit1.StyleController = Me.LayoutMain
        Me.PictureEdit1.TabIndex = 5
        '
        'Root
        '
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1167, 430)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PictureEdit1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1145, 410)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'MdiDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutMain)
        Me.Controls.Add(Me.panelContainer1)
        Me.Controls.Add(Me.DPTasks)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MdiDashboard"
        Me.Size = New System.Drawing.Size(1400, 650)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DPTasks.ResumeLayout(False)
        Me.panelContainer1.ResumeLayout(False)
        Me.DPClock.ResumeLayout(False)
        Me.DockPanel3_Container.ResumeLayout(False)
        Me.DPCalender.ResumeLayout(False)
        Me.DockPanel4_Container.ResumeLayout(False)
        CType(Me.CalendarControl1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutMain.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DPClock As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DPCalender As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DPTasks As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel6_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents CalendarControl1 As DevExpress.XtraEditors.Controls.CalendarControl
    Friend WithEvents LayoutMain As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
End Class
