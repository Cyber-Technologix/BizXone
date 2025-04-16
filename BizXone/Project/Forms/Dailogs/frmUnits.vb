Imports DevExpress.Office.Utils
Imports DevExpress.XtraData

Public Class frmUnits
    Dim tableModule As XtraTableModule

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "UnitID") With {.Container = LayoutMain}

    End Sub
    Private Sub txtID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)

        If DBManger.isFetchedRecord(tableModule).Equals(False) Then
            DBManger.AutoNumber(txtID, tableModule)
        End If
    End Sub
    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.EditValueChanged
        If TxtName.EditValue Is Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[UnitName] LIKE '%" & TxtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmUnits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DBManger.XtraGridLoadData(GridMain, "Select UnitID, UnitName from tblUnits")
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        Select Case e.Item.Id
            Case 1      'Save Command
                If UserAlerts.onSaveRecordValidation(LayoutMain) Then
                    DBManger.SaveRecord(tableModule)
                    DBManger.XtraGridLoadData(GridMain, "Select UnitID, UnitName from tblUnits")
                    txtID.Focus()
                End If

            Case 2      'Refresh Command

                DBManger.XtraFormRefresh(LayoutMain)
                txtID.Focus()
                'MessageBox.Show(e.Item.Id)
        End Select

    End Sub
End Class