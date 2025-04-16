Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout
Imports DevExpress.XtraData

Public Class frmAddProduct
    Dim tableModule As XtraTableModule
    Dim ViewQuery As String = "Select * from vwProducts"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        tableModule = New XtraTableModule(txtID, "ProductID") With {.Container = LayoutMain}
        Navigator.MergeCommandRibbon(CommandRibbon)

        AddHandler spnEqualToUnit.EditValueChanged, AddressOf Me.CalculateUnitCost
        AddHandler spnUnitRate.EditValueChanged, AddressOf Me.CalculateUnitCost
        AddHandler spnUnitCost.EditValueChanged, AddressOf Me.CalculateUnitRate

    End Sub

    Private Sub TxtName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtName.EditValueChanged
        If TxtName.EditValue Is Nothing Then
            GridView1.ActiveFilter.Clear()
        Else
            GridView1.ActiveFilterString = "[ProductName] LIKE '%" & TxtName.EditValue.ToString & "%'"
        End If
    End Sub

    Private Sub frmProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'MdiRibbon.Ribbon.MergeRibbon(CommandRibbon)
        'MdiRibbon.Ribbon.SelectPage(CommandRibbon.Pages(0))

        DBManger.XtraLoadDropDownData(cmbDepartment, "DepartmentID", "DepartmentName", "tblDepartments")
        DBManger.XtraLoadDropDownData(cmbManufacture, "ManufactureID", "ManufactureName", "tblManufacturers")
        DBManger.XtraLoadDropDownData(cmbRack, "RackID", "RackName", "tblRacks")
        DBManger.XtraLoadDropDownData(cmbPUnit, "UnitID", "UnitName", "tblUnits")
        DBManger.XtraLoadDropDownData(cmbLUnit, "UnitID", "UnitName", "tblUnits")
        DBManger.AutoCompleteCollection(txtNature, "tblProducts")
        RefreshView(sender, e)
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave
        DBManger.XtraFormClear(LayoutMain, Color.AliceBlue)
        If DBManger.isFetchedRecord(tableModule).Equals(False) Then
            DBManger.AutoNumber(txtID, tableModule)
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

                Case 103 'Refresh Command
                    DBManger.XtraFormRefresh(LayoutMain)
                    RefreshView(sender, e)

                Case 104 'Close Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

                Case 201 'Print Command
                    DBManger.ShowRibbonReport(Navigator, New rptProductAlphabeticList(), ViewQuery, If(e.Item.Id.Equals(202), True, False))
            End Select
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub cmbManufacture_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles cmbManufacture.ButtonClick

        Select Case e.Button.Index
            Case 1
                Dim Manufacture As New PopupAddData("ManufactureName", "tblManufacturers")
                If XtraDialog.Show(Manufacture, "Add New Manufacture", MessageBoxButtons.OKCancel) = DialogResult.OK Then Manufacture.AddRecord()
            Case 2
                DBManger.XtraLoadDropDownData(cmbManufacture, "ManufactureID", "ManufactureName", "tblManufacturers")
        End Select

    End Sub
    Private Sub cmbDepartment_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles cmbDepartment.ButtonClick
        Select Case e.Button.Index
            Case 1
                frmDepartment.ShowDialog()
            Case 2
                DBManger.XtraLoadDropDownData(cmbDepartment, "DepartmentID", "DepartmentName", "tblDepartments")
        End Select
    End Sub

    Private Sub cmbRack_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles cmbRack.ButtonClick
        Select Case e.Button.Index
            Case 1
                Dim Manufacture As New PopupAddData("RackName", "tblRacks")
                If XtraDialog.Show(Manufacture, "Add New Rack", MessageBoxButtons.OKCancel) = DialogResult.OK Then Manufacture.AddRecord()
            Case 2
                DBManger.XtraLoadDropDownData(cmbManufacture, "RackID", "RackName", "tblRacks")
        End Select
    End Sub

    Private Sub txtBarcode_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles txtBarcode.ButtonClick
        Select Case e.Button.Index
            Case 0
                txtBarcode.EditValue = ProjectResources.GetProductBarcode(txtID.EditValue.ToString)
        End Select
    End Sub

    Private Sub GridButtonBarcode_ButtonClick(sender As Object, e As Controls.ButtonPressedEventArgs) Handles GridButtonBarcode.ButtonClick
        Dim ProductID As Integer = DBManger.GetXtraGridColumnValue(GridMain, "ProductID")
        Dim Balance As Integer = DBManger.GetXtraGridColumnValue(GridMain, "Balance")
        Dim PrintLabele As New PopupPrintLabel(ProductID, Balance)
        If XtraDialog.Show(PrintLabele, "Print Labels", MessageBoxButtons.OKCancel) = DialogResult.OK Then PrintLabele.ShowPreview()
    End Sub


    Private Sub RefreshView(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtID.Focus()
        txtID_Leave(sender, e)
        DBManger.XtraGridLoadDataAsync(GridMain, ViewQuery)
    End Sub

    Private Sub CalculateUnitCost()
        If spnEqualToUnit.Value > 0 AndAlso spnUnitRate.Value > 0 Then
            spnUnitCost.Value = spnUnitRate.Value / spnEqualToUnit.Value
        End If
    End Sub

    Private Sub CalculateUnitRate()

        If spnEqualToUnit.Value > 0 AndAlso spnUnitCost.Value > 0 Then
            spnUnitRate.Value = spnEqualToUnit.Value * spnUnitCost.Value
        End If
    End Sub
End Class


