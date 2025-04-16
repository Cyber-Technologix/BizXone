Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraData
Imports DevExpress.XtraEditors

Public Class frmViewer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Navigator.MergeCommandRibbon(CommandRibbon)
    End Sub


    Private Sub CommandRibbon_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles CommandRibbon.ItemClick
        Try
            Select Case e.Item.Id

                Case 101 'Save Command


                Case 102 'Delete Command

                Case 103 'Refresh Command
                    'DatabaseManger.XtraFormRefresh(LayoutMain)

                Case 22 'Refresh Command
                    Navigator.ShowDashboard(GetType(MdiDashboard))

            End Select

        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtDistributor As DataTable = DBManger.XtraLoadDataTable("SELECT  DISTINCT  DistributorName FROM tblDocumentXML")

        cmbDistributor.Properties.DataSource = dtDistributor
        cmbDistributor.Properties.DisplayMember = "DistributorName"
        cmbDistributor.Properties.ValueMember = "DistributorName"

        'loadViewData()
    End Sub

    Private Sub loadViewData()

        Select Case TabMain.SelectedPageIndex
            Case 0
                DBManger.XtraGridLoadData(GridPriceView, "EXEC spProductPriceView")
            Case 1
                Dim dtEXP As DataTable = DBManger.XtraLoadDataTable("EXEC spProductExpiringView")
                If dtEXP Is Nothing Or dtEXP.Rows.Count.Equals(0) Then Exit Select
                dtEXP.Columns.Add(New DataColumn("Stock", GetType(String)))
                dtEXP.AsEnumerable.ForEach(Sub(row)
                                               row.Item("Stock") = XtraHelper.ConvertToPacksAndLooseUnits(row.Item("Balance"), row.Item("EqualToUnit"), row.Item("UnitName"), row.Item("LUnitName"))
                                           End Sub)
                dtEXP.Columns.Remove("EqualToUnit")
                GridExpring.DataSource = dtEXP

        End Select

    End Sub

    Private Sub TabMain_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles TabMain.SelectedPageChanged
        loadViewData()
    End Sub

    Private Sub cmbDistributor_EditValueChanged(sender As Object, e As EventArgs) Handles cmbDistributor.EditValueChanged
        Dim dtDocumentList As DataTable = DBManger.XtraLoadDataTable(String.Format("SELECT * FROM tblDocumentXML WHERE DistributorName='{0}'", cmbDistributor.EditValue.ToString))
        lstDocment.DataSource = dtDocumentList
        lstDocment.DisplayMember = "EntryDate"
        lstDocment.ValueMember = "TransactionID"

    End Sub

    Private Sub lstDocment_SelectedValueChanged(sender As Object, e As EventArgs) Handles lstDocment.SelectedValueChanged
        If lstDocment.SelectedValue Is Nothing Then Exit Sub
        Dim xmlData As String = DBManger.XtraLoadDataTable(String.Format("SELECT DataFile FROM tblDocumentXML WHERE TransactionID={0}", lstDocment.SelectedValue)).AsEnumerable.Select(Function(row) row.Item("DataFile")).ToList(0)
        Dim dt As DataTable = Nothing
        GridViewPdf.Columns.Clear()
        GridPdf.DataSource = dt.GetDataTableFromXml(xmlData)
    End Sub


End Class