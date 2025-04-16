Imports DevExpress.XtraSecure.Extensions

Public Class frmPassword
    Dim DefultPass As String
    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserName.EditValue = XtraAuthenticator.UserName
        txtPassword.EditValue = DBManger.XtraTableColumnValue("Password", String.Format("syUsers where UserID={0}", XtraAuthenticator.UserID)).ToString.ToDecrypt
        DefultPass = txtPassword.EditValue
    End Sub

    Private Sub CmdOk_Click(sender As Object, e As EventArgs) Handles CmdOk.Click

        DBManger.XtraShowRequiredError(MainLayout, "Empty or zero value not allowed", Color.Blue)

        If DBManger.isRequiredFieldEmpty(MainLayout, Color.Red) = True Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Required fields need to be filled out.", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If


        If DefultPass.Equals(txtPassNew.EditValue) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Please enter a different password. New password cannot be the same as the old password.", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        DBManger.XtraExecuteSQLQuery(String.Format("UPDATE syUsers SET Password='{0}', ShowPasswordMsg=0 WHERE UserID={1}", txtPassNew.EditValue.ToString.ToEncrypt, XtraAuthenticator.UserID))

        DevExpress.XtraEditors.XtraMessageBox.Show("Your password has been changed successfully", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            CmdOk.PerformClick()
        End If
    End Sub
End Class