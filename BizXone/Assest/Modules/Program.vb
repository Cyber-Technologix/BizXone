Imports System.Runtime.InteropServices
Imports DevExpress.XtraEditors
Imports Microsoft.Data.ConnectionUI
Imports DevExpress.XtraData
Imports DevExpress.XtraSecure
Imports HardwareHelper

Module Program

    <DllImport("user32.dll")>
    Private Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Integer
    End Function
    Private Function SetForegroundWindow(hWnd As IntPtr) As Integer
    End Function

    Public Property DocKind As DocumentKind

    Public scanner As New BarcodeScanner()
    Public Navigator As XtraModuleNavigator
    Public POS_transaction As New FBRTransaction()
    Public UserRoleManager As XtraUserRoleManagement
    Public ObjDeviceHandler As New AttendanceHelper("192.168.100.202", 4370)
    Public DBManger As New XtraDatabaseManger(XtraDatabase.MSSqlServerDatabase) With {.DataSource = My.Settings.DBConnectionString}
    Public XtraAuthenticator As New XtraUserAuthenticator(DBManger)
    Public Sub Main()

        If IsAppAlreadyRunning() Then Exit Sub

        ProjectResources.ShowSplashScreen()
        If LicenseValidation.LicenseValidation() Then ConnectDatabase()

        'Dim result = kk
    End Sub

    Private Sub ConnectDatabase()

        If Not DBManger.ConnectedSuccessfully Then

            Dim dbConnectionDialog As New DataConnectionDialog() With {.Text = Application.ProductName & " Data Source"}
            Dim dcs As New DataConnectionConfiguration(Nothing)
            dcs.LoadConfiguration(dbConnectionDialog)

            XtraMessageBox.Show("Data Source Not Found, Please Connect Database", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

            If DataConnectionDialog.Show(dbConnectionDialog) = DialogResult.OK Then

                'My.Settings.Item("DBConnectionString") = dbConnectionDialog.ConnectionString
                My.Settings.DBConnectionString = dbConnectionDialog.ConnectionString
                My.Settings.Save()
                dcs.SaveConfiguration(dbConnectionDialog)
            End If
            Application.ExitThread()
        Else
            Application.Run(New frmLogin())
            If XtraAuthenticator.isUserAuthenticated Then Application.Run(MdiRibbon)
        End If
    End Sub

    Private Function IsAppAlreadyRunning() As Boolean
        Dim isAlreadyRunning As Boolean = False
        Dim processes As Process() = Process.GetProcesses()
        Dim currentProcess As Process = Process.GetCurrentProcess()

        For Each process As Process In processes

            If currentProcess.Id <> process.Id Then

                If currentProcess.ProcessName = process.ProcessName Then
                    isAlreadyRunning = True
                    ShowWindow(process.MainWindowHandle, 9)
                    SetForegroundWindow(process.MainWindowHandle)
                    Exit For
                End If
            End If
        Next

        Return isAlreadyRunning
    End Function

End Module
