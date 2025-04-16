
Imports Microsoft.SqlServer.Management.Smo
Imports System.IO
Imports DevExpress.XtraData

Public Class frmBackup
    Dim SQLBackupHandler As New SQLBackupHandler
    Dim BackUpDoneToday As Boolean = False
    Dim builder As New SqlClient.SqlConnectionStringBuilder(DBManger.DataSource)

    Private Sub cmdLoadServers_Click(sender As System.Object, e As System.EventArgs) Handles cmdLoadServers.Click

        Dim Handle = XtraOverlay.ShowOverlayProgressPanel(Me)
        Try

            Me.cmbServers.DataSource = XtraAsyncHelper.RunFunctionSync(Function() SQLBackupHandler.LoadServer())
            Me.cmbServers.DisplayMember = "ServerName"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            XtraOverlay.CloseOverlayProgressPanel(Handle)
        End Try
    End Sub


    Private Sub cmdLoadDatabases_Click(sender As System.Object, e As System.EventArgs) Handles cmdLoadDatabases.Click

        Dim Handle = XtraOverlay.ShowOverlayProgressPanel(Me)

        Try
            Me.cmbDatabases.Items.Clear()
            Me.cmbDatabases.Items.AddRange(SQLBackupHandler.LoadDatabases().ToArray)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            XtraOverlay.CloseOverlayProgressPanel(Handle)
        End Try
    End Sub

    Private Sub btnBackup_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBackup.ItemClick
        Try

            Cursor.Current = Cursors.WaitCursor()

            Dim dlgFolder As New FolderBrowserDialog()
            dlgFolder.ShowNewFolderButton = True

            If dlgFolder.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtBackupLocation.Text = dlgFolder.SelectedPath.ToString()

            End If



            Dim serverName As String = Me.cmbServers.Text
            Dim pathName As String = Me.txtBackupLocation.Text
            Dim databaseName As String = Me.cmbDatabases.Text


            Dim timeStamp As String = DateTime.Now.ToString("yyyyMMddhhmmss")

            Dim fileName As String = databaseName + "-" + timeStamp

            If Not Directory.Exists(Me.txtBackupLocation.Text) Then Directory.CreateDirectory(Me.txtBackupLocation.Text)
            fileName = Me.txtBackupLocation.Text + "\" + fileName

            Dim backupServer As New Server(serverName)
            Dim dataBackup As New Backup()

            dataBackup.Action = BackupActionType.Database
            dataBackup.Database = databaseName

            'set the devices: file, tape etc
            dataBackup.Devices.AddDevice(fileName, DeviceType.File)

            'progress meter stuff
            ' Initializing progress bar properties 
            pbrStatus.Properties.Step = 10
            pbrStatus.Properties.PercentView = True
            pbrStatus.Properties.Maximum = 100
            pbrStatus.Properties.Minimum = 0

            ''this gives the % complete by handling the event
            ''provided by SMO on the percent complete; we will
            ''update the progress meter in the event handler

            ''set the progress meter to 1% by default
            dataBackup.PercentCompleteNotification = 10
            AddHandler dataBackup.PercentComplete, AddressOf Me.BackupProgressEventHandler

            dataBackup.SqlBackup(backupServer)

            Me.txtStatus.Caption = "Backup of " & databaseName & " completed sucessfully"


        Catch exSMO As SmoException
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(exSMO.Message)
            Me.txtStatus.Caption = exSMO.Message

        Catch ex As Exception
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(ex.Message)
            Me.txtStatus.Caption = ex.Message
        Finally
            Me.pbrStatus.EditValue = 0
            Cursor.Current = Cursors.Default()

        End Try

    End Sub

    Private Sub cmdBackupLocation_Click(sender As System.Object, e As System.EventArgs)

        Try
            Me.Cursor = Cursors.WaitCursor


            Dim dlgFolder As New FolderBrowserDialog()
            dlgFolder.ShowNewFolderButton = True

            If dlgFolder.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtBackupLocation.Text = dlgFolder.SelectedPath.ToString()

            End If

        Catch eX As Exception
            MessageBox.Show(eX.Message)

        Finally
            Me.Cursor = Cursors.Default

        End Try
    End Sub

    Private Sub BackupProgressEventHandler(ByVal sender As System.Object, ByVal e As PercentCompleteEventArgs)
        'increase the progress bar up by the percent
        Me.pbrStatus.PerformStep()
        Me.pbrStatus.Update()

    End Sub



    Private Sub btnRestore_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRestore.ItemClick
        Dim res As New Restore

        Dim OpenFileDialog1 As New OpenFileDialog()

        Dim fileName As String
        Dim serverName As String = Me.cmbServers.Text
        Dim databaseName As String = Me.cmbDatabases.Text
        Dim restoreServer As New Server(serverName)

        Try


            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                fileName = OpenFileDialog1.FileName.ToString()

                res.Database = databaseName
                res.Action = RestoreActionType.Database
                res.Devices.AddDevice(fileName, DeviceType.File)

                'progress meter stuff
                ' Initializing progress bar properties 
                pbrStatus.Properties.Step = 10
                pbrStatus.Properties.PercentView = True
                pbrStatus.Properties.Maximum = 100
                pbrStatus.Properties.Minimum = 0

                ''set the progress meter to 1% by default
                res.PercentCompleteNotification = 1
                AddHandler res.PercentComplete, AddressOf Me.BackupProgressEventHandler
                res.SqlRestore(restoreServer)

                'MessageBox.Show("Restore of " + databaseName + " Complete", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtStatus.Caption = "Restore of " & databaseName & " completed successfully."
            End If
        Catch exSMO As SmoException
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(exSMO.Message)
            Me.txtStatus.Caption = exSMO.Message
        Catch ex As Exception
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(ex.Message)
            Me.txtStatus.Caption = ex.Message
        Finally
            Me.pbrStatus.EditValue = 0
            Cursor.Current = Cursors.Default()

        End Try
    End Sub

    Private Sub Backuprestore_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cmbServers.Text = builder("Data Source").ToString
        cmbDatabases.Text = builder("Initial Catalog").ToString
    End Sub


    Private Sub btnVerify_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVerify.ItemClick
        Dim res As New Restore



        Dim OpenFileDialog1 As New OpenFileDialog()

        Dim fileName As String
        Dim serverName As String = Me.cmbServers.Text
        Dim restoreServer As New Server(serverName)

        Try
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then


                fileName = OpenFileDialog1.FileName.ToString()

                res.Action = RestoreActionType.Database
                res.Devices.AddDevice(fileName, DeviceType.File)

                'progress meter stuff
                ' Initializing progress bar properties 
                pbrStatus.Properties.Step = 10
                pbrStatus.Properties.PercentView = True
                pbrStatus.Properties.Maximum = 100
                pbrStatus.Properties.Minimum = 0


                res.PercentCompleteNotification = 1
                AddHandler res.PercentComplete, AddressOf Me.BackupProgressEventHandler
                res.SqlVerify(restoreServer)

                Me.txtStatus.Caption = "Verification of " & fileName & " completed successfully."


            End If
        Catch exSMO As SmoException
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(exSMO.Message)
            Me.txtStatus.Caption = exSMO.Message
        Catch ex As Exception
            Me.pbrStatus.EditValue = 0
            'MessageBox.Show(ex.Message)
            Me.txtStatus.Caption = ex.Message
        Finally
            Me.pbrStatus.EditValue = 0
            Cursor.Current = Cursors.Default()

        End Try
    End Sub
End Class