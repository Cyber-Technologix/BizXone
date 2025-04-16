Imports System.ComponentModel
Imports System.Threading
Imports DevExpress.XtraData
Public Class MdiDashboard

    'Private timer As New Timer()
    Dim rnd As New Random
    Dim myFiles As New List(Of String)
    Dim Path = Windows.Forms.Application.StartupPath() & "\images"
    Dim addNewTask As frmTask
    Public Sub New()
        InitializeComponent()
        'worker = New BackgroundWorker()

        CalendarControl1.DateTime = Date.Now
        CalendarControl1.CalendarIndent = 10

        BackgroundAutoUpdate()
        DPTasks.Controls.Add(New UserTasksControl(DBManger, XtraAuthenticator) With {.Dock = DockStyle.Fill})
        addNewTask = New frmTask(DBManger, XtraAuthenticator)
    End Sub

    Private Sub DockPanel4_Resize(sender As Object, e As EventArgs) Handles DPCalender.Resize
        CalendarControl1.CalcBestSize()
    End Sub

    Private Sub MdiDashBoard_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        myFiles.AddRange(My.Computer.FileSystem.GetFiles(Path).ToArray)
        PictureEdit1.Image = Image.FromFile(myFiles(rnd.Next(0, myFiles.Count)))
    End Sub


    Private Sub DPTasks_CustomButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles DPTasks.CustomButtonClick

        If (e.Button Is DPTasks.CustomHeaderButtons(0)) Then
            addNewTask.ShowDialog()
        End If


    End Sub

    Private Sub UpdateClock()
        Dim result = "<b>" & Date.Now.ToLongTimeString() & "</b><br><size=10>" & Date.Now.ToLongDateString()

        If labelControl1.InvokeRequired Then
            ' Invoke required, so we are in a different thread
            labelControl1.Invoke(Sub() labelControl1.Text = result)
        Else
            labelControl1.Text = result
        End If
    End Sub

    Public Sub BackgroundAutoUpdate()

        Dim worker As New BackgroundWorker

        AddHandler worker.DoWork, Sub(sender, e)
                                      Dim bgWorker As BackgroundWorker = TryCast(sender, BackgroundWorker)

                                      While Not bgWorker.CancellationPending

                                          UpdateClock()
                                          Thread.Sleep(1000)
                                      End While
                                  End Sub

        worker.WorkerSupportsCancellation = True
        worker.RunWorkerAsync()
        'worker.CancelAsync()

    End Sub

End Class