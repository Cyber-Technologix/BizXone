Imports DevExpress.Office.Utils
Imports DevExpress.XtraData

Public Class frmAddTellers
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = "Select TellerID,TellerName,POSID FROM tblTellers"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "TellerID") With {.Container = LayoutMain}

    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.EditValueChanged
        If TxtName.EditValue Is Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[TellerName] LIKE '%" & TxtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmTellers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraGridLoadData(GridMain, ViewQuery)
        DBManger.XtraLoadDropDownData(cmbAccountID, "AccountID", "AccountName", "tblAccounts where AccountTypeID IN(10)")
        txtID_Leave(sender, e)
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Select Case e.Item.Id
            Case 1      'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    DBManger.SaveRecord(tableModule)

                    txtID.Focus()
                    txtID_Leave(sender, e)
                End If

            Case 2      'Refresh Command

                DBManger.XtraFormRefresh(LayoutMain)
                txtID.Focus()
        End Select
        DBManger.XtraGridLoadData(GridMain, ViewQuery)
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If DBManger.isFetchedRecord(tableModule).Equals(False) Then
            DBManger.AutoNumber(txtID, tableModule)
        End If
    End Sub
End Class