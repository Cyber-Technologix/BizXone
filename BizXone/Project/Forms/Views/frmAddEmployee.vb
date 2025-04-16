Imports DevExpress.XtraEditors
Imports DevExpress.XtraData
Imports DevExpress.XtraEditors.Controls

Public Class frmAddEmployee
    Dim intigration As Boolean = False
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = "Select * from vwEmployees"


    Public Enum EmployeeStatus
        Salaried = 1
        Commission = 2
        Terminated = 3
        OnLeave = 4
    End Enum

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Navigator.MergeCommandRibbon(CommandRibbon)
        tableModule = New XtraTableModule(txtID, "EmployeeID") With {.Container = LayoutMain}
    End Sub


    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged
        If txtName.EditValue = Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[Name] LIKE '%" & txtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EmployeeGenderPopulate(ddlGender)
        ddlJobStatus.Properties.Items.AddEnum(Of EmployeeStatus)()
        DBManger.XtraLoadDropDownData(cmbDepartment, "DepartmentID", "DepartmentName", "tblDepartments")
        RefreshView(sender, e)
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If Not DBManger.isFetchedRecord(tableModule) Then
            DBManger.AutoNumber(txtID, tableModule)
            intigration = True
        Else
            intigration = False
            txtFinalPassword.EditValue = txtPassword.EditValue

            ddlJobStatus.GetEnumByValue(Of EmployeeStatus)
        End If
    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Try
            Select Case e.Item.Id

                Case 101      'Save Command
                    If Not dxValidationProvider.Validate Then Exit Sub
                    If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                        intigratedWithDevice()
                        DBManger.SaveRecord(tableModule)
                        RefreshView(sender, e)
                    End If

                Case 103      'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain)
                    RefreshView(sender, e)
                Case 22 'Close Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 201 'Print Command
                    'DatabaseManger.ShowRibbonReport(New rptClients, "Select * from vwClients where ClientTypeID in(1,2,3) ORDER BY TerritoryID, ClientTypeID, ClientID", False)
            End Select

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub intigratedWithDevice()

        If intigration Then

            If ObjDeviceHandler.PushUserDataToDevice(txtID.EditValue, txtName.EditValue, txtPassword.EditValue) Then
                XtraMessageBox.Show("The user account has been added to the device.", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If

            'ObjDeviceHandler.Disconnect()

        End If

    End Sub

    Private Shared Sub EmployeeGenderPopulate(ByVal edit As ImageComboBoxEdit)
        edit.Properties.Items.Clear()
        edit.Properties.Items.Add(New ImageComboBoxItem("Male", "Male", Nothing))
        edit.Properties.Items.Add(New ImageComboBoxItem("Female", "Female", Nothing))
    End Sub

    Private Sub imgPhoto_EditValueChanged(sender As Object, e As EventArgs) Handles imgPhoto.EditValueChanged
        If imgPhoto.Image Is Nothing Then imgPhoto.Image = My.Resources.Resources.EE_Picture
    End Sub

    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
    End Sub
End Class