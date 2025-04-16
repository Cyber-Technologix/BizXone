<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPassword))
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.MainLayout = New DevExpress.XtraLayout.LayoutControl()
        Me.CmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassNew = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.dxValidationProvider = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainLayout.SuspendLayout()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(15, 45)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.MaxLength = 30
        Me.txtPassword.Properties.NullText = "New Password"
        Me.txtPassword.Properties.NullValuePrompt = "Please Enter new Password"
        Me.txtPassword.Properties.UseSystemPasswordChar = True
        Me.txtPassword.Size = New System.Drawing.Size(333, 20)
        Me.txtPassword.StyleController = Me.MainLayout
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Tag = ""
        '
        'MainLayout
        '
        Me.MainLayout.Controls.Add(Me.CmdOk)
        Me.MainLayout.Controls.Add(Me.txtPassword)
        Me.MainLayout.Controls.Add(Me.txtUserName)
        Me.MainLayout.Controls.Add(Me.txtPassNew)
        Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayout.Location = New System.Drawing.Point(0, 0)
        Me.MainLayout.Name = "MainLayout"
        Me.MainLayout.Root = Me.LayoutControlGroup2
        Me.MainLayout.Size = New System.Drawing.Size(363, 184)
        Me.MainLayout.TabIndex = 0
        Me.MainLayout.Text = "LayoutControl2"
        '
        'CmdOk
        '
        Me.CmdOk.Location = New System.Drawing.Point(12, 150)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(111, 22)
        Me.CmdOk.StyleController = Me.MainLayout
        Me.CmdOk.TabIndex = 22
        Me.CmdOk.Text = "Create Password"
        '
        'txtUserName
        '
        Me.txtUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUserName.Enabled = False
        Me.txtUserName.EnterMoveNextControl = True
        Me.txtUserName.Location = New System.Drawing.Point(15, 15)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtUserName.Properties.MaxLength = 30
        Me.txtUserName.Size = New System.Drawing.Size(333, 20)
        Me.txtUserName.StyleController = Me.MainLayout
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Tag = ""
        '
        'txtPassNew
        '
        Me.txtPassNew.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassNew.EnterMoveNextControl = True
        Me.txtPassNew.Location = New System.Drawing.Point(15, 75)
        Me.txtPassNew.Name = "txtPassNew"
        Me.txtPassNew.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNew.Properties.Appearance.Options.UseFont = True
        Me.txtPassNew.Properties.MaxLength = 30
        Me.txtPassNew.Properties.NullText = "Confrim New Password"
        Me.txtPassNew.Properties.NullValuePrompt = "Please Enter new Password"
        Me.txtPassNew.Properties.UseSystemPasswordChar = True
        Me.txtPassNew.Size = New System.Drawing.Size(333, 20)
        Me.txtPassNew.StyleController = Me.MainLayout
        Me.txtPassNew.TabIndex = 2
        Me.txtPassNew.Tag = ""
        CompareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.NotEquals
        CompareAgainstControlValidationRule1.Control = Me.txtPassword
        CompareAgainstControlValidationRule1.ErrorText = "Confrim password not matched "
        Me.dxValidationProvider.SetValidationRule(Me.txtPassNew, CompareAgainstControlValidationRule1)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseTextOptions = True
        Me.LayoutControlGroup2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LayoutControlGroup2.CustomizationFormText = "LayoutControlGroup2"
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.EmptySpaceItem3})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(363, 184)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txtUserName
        Me.LayoutControlItem2.CustomizationFormText = "Company &Name:"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(343, 30)
        Me.LayoutControlItem2.Text = "&User Name :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txtPassword
        Me.LayoutControlItem3.CustomizationFormText = "&Address:"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(343, 30)
        Me.LayoutControlItem3.Text = "&Password :"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 90)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(343, 48)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtPassNew
        Me.LayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem1.CustomizationFormText = "&Address:"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(343, 30)
        Me.LayoutControlItem1.Text = "&Password :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.CmdOk
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(115, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(115, 138)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(113, 26)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(228, 138)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(115, 26)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 184)
        Me.Controls.Add(Me.MainLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = CType(resources.GetObject("frmPassword.IconOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainLayout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainLayout.ResumeLayout(False)
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dxValidationProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainLayout As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtPassNew As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents CmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents dxValidationProvider As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
End Class
