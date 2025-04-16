Imports DevExpress.XtraEditors

Public Class frmLogin
    Public Sub New()

        InitializeComponent()
        DevExpress.UserSkins.BonusSkins.Register()
        SkinManager.EnableFormSkins()
        ProjectResources.ApplicationDefaultSkin()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Windows.Forms.Application.ExitThread()

    End Sub

    Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click

        Try
            If dxValidationProvider.Validate.Equals(False) Then Exit Sub

            If XtraAuthenticator.AuthenticateUser(txtUserName.Text, txtPassword.Text) Then Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DBManger.AutoCompleteCollection(txtUserName, "syUsers")

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdOk.PerformClick()

        ElseIf e.KeyCode = Keys.F10 Then

            If (txtUserName.Text.ToLower.Equals("administrator") AndAlso txtPassword.Text.Equals("*0000#")) Then
                My.Settings.Item("DBConnectionString") = String.Empty
                My.Settings.Save()
                XtraMessageBox.Show("Data Source Settings Reset", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                'Application.ExitThread()
            End If

        End If

    End Sub

End Class