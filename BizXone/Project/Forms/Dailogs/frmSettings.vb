Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors.Controls
Public Class frmSettings
    Dim dtSettings As DataTable = DBManger.XtraLoadDataTable("Select * from sySettings")

    Private Sub TxtHeading_1_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles TxtHeading_1.ButtonClick
        ProjectResources.ShowFontDialog(TxtHeading_1)
    End Sub

    Private Sub TxtHeading_2_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles TxtHeading_2.ButtonClick
        ProjectResources.ShowFontDialog(TxtHeading_2)
    End Sub

    Private Sub TxtHeading_3_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles TxtHeading_3.ButtonClick
        ProjectResources.ShowFontDialog(TxtHeading_3)
    End Sub

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DBManger.XtraLoadDropDownData(ddlPeriod, "PeriodID", "PeriodName", "syPeriods")
        DBManger.XtraLoadDropDownData(ddlPOSID, "TellerID", "TellerName", "tblTellers")

        GetSettingValues()
    End Sub
    Public Sub SaveSettingValues()


        'Save Heading_1 Setting
        dtSettings.Select("ID=1").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_1.Text)
        dtSettings.Select("ID=10").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_1.Font.Name)
        dtSettings.Select("ID=101").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_1.Font.Size)
        ''Heading_2 Setting
        dtSettings.Select("ID=2").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_2.Text)
        dtSettings.Select("ID=20").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_2.Font.Name)
        dtSettings.Select("ID=201").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_2.Font.Size)
        ''Heading_3 Setting
        dtSettings.Select("ID=3").ToList().ForEach(Sub(row) row("Setting") = TxtHeading_3.Text)
        dtSettings.Select("ID=30").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_3.Font.Name)
        dtSettings.Select("ID=301").ToList().ForEach(Sub(row) row.Item("Setting") = TxtHeading_3.Font.Size)
        DBManger.SaveDataTable(dtSettings, "sySettings")


        My.Settings.isAllowFBR = tshFbrInvoiceing.IsOn
        My.Settings.setTellerID = CInt(ddlPOSID.EditValue)
        My.Settings.Save()
    End Sub
    Public Sub GetSettingValues()

        'GetHeading_1 Setting
        TxtHeading_1.Text = DBManger.GetSettingX(1, "XTRA TECHNOLOGIES DEVELOPER")
        TxtHeading_1.Font = New Font(DBManger.GetSettingX(10, "Tahoma").ToString, DBManger.GetSettingX(101, 10), FontStyle.Regular)
        'Get Heading_2 Setting
        TxtHeading_2.Text = DBManger.GetSettingX(2, "A Leading Software Organization")
        TxtHeading_2.Font = New Font(DBManger.GetSettingX(20, "Tahoma").ToString, DBManger.GetSettingX(201, 10), FontStyle.Regular)
        'Get Heading_3 Setting
        TxtHeading_3.Text = DBManger.GetSettingX(3, "2002-2010")
        TxtHeading_3.Font = New Font(DBManger.GetSettingX(30, "Tahoma").ToString, DBManger.GetSettingX(301, 10), FontStyle.Regular)

        ddlPeriod.SetEditValue(DBManger.XtraTableColumnValue("PeriodID", "SyPeriods where StatusID=1"))
        tshFbrInvoiceing.IsOn = My.Settings.isAllowFBR
        ddlPOSID.SetEditValue(My.Settings.setTellerID)
    End Sub

    Private Shared Sub AddNewSetting(ID As Int16, Setting As String)
        Dim dt As New DataTable
        Dim Cols As String() = {"ID", "Setting"}
        Cols.ToList().ForEach(Sub(x) dt.Columns.Add(x))
        dt.Rows.Add(ID, Setting)
    End Sub

    Private Sub barManager_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barManager.ItemClick
        If dxValidationProvider.Validate.Equals(False) Then Exit Sub

        Select Case e.Item.Id
            Case 1      'Save Command

                Select Case TabMain.SelectedTabPageIndex
                    Case 1
                        DBManger.XtraExecuteSQLQuery(String.Format("UPDATE SyPeriods SET StatusID=0;UPDATE SyPeriods SET StatusID=1 WHERE PeriodID={0}", ddlPeriod.EditValue))
                    Case Else
                        SaveSettingValues()
                End Select

        End Select
        XtraMessageBox.Show("Changes are successfully saved.", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub list_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If e.State = CheckState.Checked Then
            Dim list As CheckedListBoxControl = TryCast(sender, CheckedListBoxControl)
            Dim items As New List(Of CheckedListBoxItem)()
            For Each index As Integer In list.CheckedIndices
                If index = e.Index Then
                    Continue For
                End If
                items.Add(list.Items(index))
            Next index
            For Each item As CheckedListBoxItem In items
                item.CheckState = CheckState.Unchecked
            Next item
        End If
    End Sub

    Private Sub ddlPeriod_Popup(sender As Object, e As EventArgs) Handles ddlPeriod.Popup
        Dim list As CheckedListBoxControl = (TryCast(sender, IPopupControl)).PopupWindow.Controls.OfType(Of PopupContainerControl)().First().Controls.OfType(Of CheckedListBoxControl)().First()

        RemoveHandler list.ItemCheck, AddressOf list_ItemCheck
        AddHandler list.ItemCheck, AddressOf list_ItemCheck
    End Sub

    Private Sub ddlPeriod_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles ddlPeriod.ButtonClick
        Select Case e.Button.Index
            Case 1
                Dim Period As New PopupAddPeriod()
                If XtraDialog.Show(Period, "Add New  financial Period", MessageBoxButtons.OKCancel) = DialogResult.OK Then Period.AddRecord()
            Case 2
                DBManger.XtraLoadDropDownData(ddlPeriod, "PeriodID", "PeriodName", "syPeriods")
        End Select
    End Sub

    Private Sub ddlPOSID_Popup(sender As Object, e As EventArgs) Handles ddlPOSID.Popup
        Dim list As CheckedListBoxControl = (TryCast(sender, IPopupControl)).PopupWindow.Controls.OfType(Of PopupContainerControl)().First().Controls.OfType(Of CheckedListBoxControl)().First()
        RemoveHandler list.ItemCheck, AddressOf list_ItemCheck
        AddHandler list.ItemCheck, AddressOf list_ItemCheck
    End Sub

    Private Sub tshFbrInvoiceing_EditValueChanged(sender As Object, e As EventArgs) Handles tshFbrInvoiceing.EditValueChanged
        ddlPOSID.Enabled = If(tshFbrInvoiceing.IsOn, False, True)
    End Sub
End Class