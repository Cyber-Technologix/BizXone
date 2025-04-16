Imports System.ComponentModel
Imports System.Threading
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors

Public Class frmAttendance

    Dim bgWorker As BackgroundWorker

    Public Enum EmployeeViews
        CardView = 1
        GridView = 2
        DeviceView = 3
        SystemView = 4
    End Enum
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bgWorker = New BackgroundWorker With {.WorkerSupportsCancellation = True}
        Navigator.MergeCommandRibbon(CommandRibbon)


        If ObjDeviceHandler.isConnected Then

            Dim strText = ObjDeviceHandler.FetchDeviceInfo().ToString
            Dim strArray() As String = Split(strText, ",")

            'Dim strText As String = Join(strArray, ",")  
            lblDeviceInfo.Caption = String.Concat(strArray(4), ", ", strArray(5))

        Else
            UserAlerts.AttendanceDeviceConnectedFailed()
            Navigator.ShowDashboard(GetType(MdiDashboard))
            Exit Sub
        End If
    End Sub

    Private Sub ShowAttendanceLogData()

        Dim dt As DataTable = ObjDeviceHandler.GetAttendanceLogData()

        If dt.Rows.Count > 0 Then
            DBManger.SQLServerBulkCopy(dt, "dwAttendanceLogs")
            ObjDeviceHandler.ClearGLog()
        End If

        Dim dtAttendance As DataTable = DBManger.XtraLoadDataTable("SELECT ID,Name,Mode,Dated,Checkin,Checkout,TotalHours,Status,StatusID FROM vwAttendanceLogs ORDER BY StatusID,ID")

        Dim AttendanceLogData = New BindingSource With {.DataSource = dtAttendance}

        LoadGrid(AttendanceLogData)

        bsiRecordsCount.Caption = "RECORDS :" & AttendanceLogData.Count
    End Sub

    Private Sub ShowEmployeeDashBoard(ShowView As EmployeeViews)
        Dim dt As DataTable = ObjDeviceHandler.GetAllRegisteredUserList()
        Dim dtEE As DataTable = DBManger.XtraLoadDataTable("Select * from vwEmployees")
        Dim dtview As DataTable = dtEE.Clone

        dt.Select.ForEach(Sub(row) dtEE.Select().Where(Function(r) r.Field(Of Integer)("EmployeeID") = row.Item("EnrollNumber")).ForEach(Sub(xrow) dtview.ImportRow(xrow)))

        Dim EmployeeDashBoard = New BindingSource With {.DataSource = dtview}

        Select Case ShowView
            Case EmployeeViews.CardView
                GridMain.MainView = EECardView
            Case EmployeeViews.GridView
                GridMain.MainView = EEGridView
            Case EmployeeViews.DeviceView
                GridMain.MainView = EEGridView
                EmployeeDashBoard = New BindingSource With {.DataSource = dt}
            Case EmployeeViews.SystemView
                GridMain.MainView = EEGridView
                EmployeeDashBoard = New BindingSource With {.DataSource = dtEE}
        End Select

        LoadGrid(EmployeeDashBoard)
        bgWorker.CancelAsync()
        bsiRecordsCount.Caption = "RECORDS :" & EmployeeDashBoard.Count
    End Sub

    Private Sub LoadGrid(dt As Object)
        Try
            If GridMain.InvokeRequired Then
                GridMain.Invoke(Sub()
                                    EEGridView.Columns.Clear()
                                    GridMain.DataSource = Nothing
                                    GridMain.DataSource = dt
                                    GridMain.MainView = gvAttendance
                                End Sub)
            Else
                EEGridView.Columns.Clear()
                GridMain.DataSource = Nothing
                GridMain.DataSource = dt
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub AutoUpdateAttendanceLogData()

        AddHandler bgWorker.DoWork, Sub(sender, e)

                                        While Not bgWorker.CancellationPending
                                            ShowAttendanceLogData()
                                            Thread.Sleep(3000)
                                        End While
                                    End Sub



        AddHandler bgWorker.RunWorkerCompleted, Sub(sender, e)
                                                    If e.Cancelled Then
                                                        ' Handle the cancellation if needed
                                                    End If
                                                End Sub

        '' Enable cancellation support and set worker properties
        'worker.WorkerSupportsCancellation = True

        ' Only start a new worker if it is not already busy
        If Not bgWorker.IsBusy Then
            bgWorker.RunWorkerAsync()
        Else
            ' Handle the case where the worker is already busy
            ' You may choose to cancel the current worker before starting a new one
            bgWorker.CancelAsync()
        End If
    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Select Case e.Item.Id

            Case 102
                AutoUpdateAttendanceLogData()
            Case 103 'Close Command
                bgWorker.CancelAsync()
                Navigator.ShowDashboard(GetType(MdiDashboard))
            Case 201 'Print Command

            Case 1001
                ShowEmployeeDashBoard(EmployeeViews.CardView)
            Case 1002
                ShowEmployeeDashBoard(EmployeeViews.GridView)
            Case 1003
                ShowEmployeeDashBoard(EmployeeViews.DeviceView)
            Case 1004
                ShowEmployeeDashBoard(EmployeeViews.SystemView)
        End Select
    End Sub

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowEmployeeDashBoard(EmployeeViews.CardView)
    End Sub
End Class

