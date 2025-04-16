Imports DevExpress.XtraEditors
Imports DevExpress.XtraData

Public Class frmAddAccounts
    Dim MyVal As Integer

    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = "Select * from vwAccounts"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Navigator.MergeCommandRibbon(CommandRibbon)
        tableModule = New XtraTableModule(txtID, "AccountID") With {.Container = LayoutMain}
    End Sub
    Private Sub frmAccounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraLoadDropDownData(cmbACType, "AccountTypeID", "AccountTypeName", "tblAccountTypes")
        RefreshView(sender, e)
    End Sub

    Private Sub cmbACType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbACType.EditValueChanged
        MyVal = Val(cmbACType.EditValue)
        txtID.EditValue = Format(MyVal, "00") & "0000"

        If cmbACType.EditValue = Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[AccountID] LIKE '" & cmbACType.EditValue & "%'"
        End If
        Exit Sub
    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.EditValueChanged
        If txtName.EditValue = Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[AccountName] LIKE '%" & txtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If DBManger.isFetchedRecord(tableModule).Equals(False) Then
            txtID.EditValue = Format(MyVal, "00") & Format(DBManger.AutoNumber("Convert(int,right(AccountID,4))", "tblAccounts WHERE Convert(int,Left(AccountID,2)) =" & MyVal), "0000")
        End If
    End Sub

    Private Sub cmbACType_Leave(sender As Object, e As EventArgs) Handles cmbACType.Leave
        If DBManger.isFetchedRecord(tableModule).Equals(False) Then
            txtID.EditValue = Format(MyVal, "00") & Format(DBManger.AutoNumber("Convert(int,right(AccountID,4))", "tblAccounts WHERE Convert(int,Left(AccountID,2)) =" & MyVal), "0000")
        End If
    End Sub

    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick

        Try
            Select Case e.Item.Id

                Case 101 'Save Command

                    If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                        DBManger.SaveRecord(tableModule)
                        RefreshView(sender, e)
                    End If

                Case 102 'Delete Command

                Case 103 'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain)
                    RefreshView(sender, e)
                Case 22 'Refresh Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 201, 202 'Print Command
                    DBManger.ShowRibbonReport(Navigator, New rptAccountIndex, ViewQuery, If(e.Item.Id.Equals(202), True, False))
            End Select

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
    End Sub
End Class