Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class UserAlerts

    Private Shared RequiredFieldErrorText As String = "Empty or zero value not allowed"
    Private Shared RequiredFieldErrorMsg As String = "Please fill in all the mandatory fields before proceeding."
    Private Shared SaveRecordMsg As String = "The record has been successfully saved."

    Public Shared Function onSaveRecordValidation(ByVal FrmName As ContainerControl) As Boolean
        If DBManger.XtraShowRequiredError(FrmName, RequiredFieldErrorText, Color.Blue, ErrorType.Default) Then
            XtraMessageBox.Show(RequiredFieldErrorMsg, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function
    Public Shared Function onSaveRecordValidation(ByVal FrmName As ContainerControl, RequriedForeColor As Color) As Boolean
        If DBManger.XtraShowRequiredError(FrmName, RequiredFieldErrorText, RequriedForeColor, ErrorType.Default) Then
            XtraMessageBox.Show(RequiredFieldErrorMsg, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        Return True
    End Function
    Public Shared Sub ShowSaveRecordMsg()
        XtraMessageBox.Show(SaveRecordMsg, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub AttendanceDeviceConnectedFailed()
        Dim Msg = "Connection to the attendance device failed." & vbCrLf & "Please make sure the device is connected properly and try again." & vbCrLf & "If the issue persists, contact your administrator for assistance."
        XtraMessageBox.Show(Msg, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
