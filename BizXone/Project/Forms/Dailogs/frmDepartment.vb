Imports DevExpress.XtraData

Public Class frmDepartment
    Dim tableModule As XtraTableModule
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "DepartmentID") With {.Container = LayoutMain}

    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged
        If txtName.EditValue = Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[DepartmentName] LIKE '%" & txtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmDepartments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(cmbSaleAccount, "AccountID", "AccountName", "tblAccounts where AccountTypeID NOT IN(24)")
        DBManger.XtraLoadDropDownData(cmbPurchaseAccount, "AccountID", "AccountName", "tblAccounts where AccountTypeID NOT IN(24)")
        DBManger.XtraGridLoadData(GridMain, "Select DepartmentID, DepartmentName from tblDepartments")
        txtID.Focus()
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If DBManger.isFetchedRecord(tableModule) = False Then
            DBManger.AutoNumber(txtID, tableModule)
        End If
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Select Case e.Item.Id
            Case 1      'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    DBManger.SaveRecord(tableModule)
                    DBManger.XtraGridLoadData(GridMain, "Select DepartmentID, DepartmentName from tblDepartments")
                    txtID.Focus()
                End If

            Case 2      'Refresh Command
                DBManger.XtraFormRefresh(LayoutMain)
                txtID.Focus()
                'MessageBox.Show(e.Item.Id)
        End Select
    End Sub
End Class