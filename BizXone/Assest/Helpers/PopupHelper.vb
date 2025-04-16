Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraLayout
Imports DevExpress.XtraData.XtraDataTable

Public Class PopupHelper

End Class


Friend Class PopupPrintLabel
    Inherits XtraUserControl
    Private spnQuantity As New SpinEdit With {.ForeColor = Color.Blue}
    Private frmLayout As New LayoutControl() With {.Dock = DockStyle.Fill}

    Private Property Quantity As Integer
        Get
            Return spnQuantity.Value
        End Get
        Set(ByVal Value As Integer)
            spnQuantity.Value = Value
        End Set
    End Property

    Private Property ProductID As Integer

    Public Sub New(prodID As Integer, balance As Integer)
        spnQuantity.Properties.Mask.MaskType = MaskType.None
        frmLayout.AddItem("Quantity :", spnQuantity).TextVisible = True
        Me.Controls.Add(frmLayout)
        Me.Height = 60
        Me.Dock = DockStyle.Top
        Me.ProductID = prodID
        Quantity = balance
    End Sub

    Public Sub ShowPreview()

        If DBManger.isRequiredFieldEmpty(frmLayout, Color.Blue) Then
            XtraMessageBox.Show("Quantity is required!", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim dt As DataTable = DBManger.XtraLoadDataTable(String.Format("Select * from vwProducts where ProductID={0}", ProductID))
        Dim dtPrint As DataTable = dt.Clone
        Enumerable.Range(1, Quantity).ForEach(Sub() dtPrint.ImportRow(dt.Rows(0)))
        DBManger.ShowReportPreview(New rptProductLabelPrinting, dtPrint, False)
    End Sub

End Class



Friend Class PopupAddData
    Inherits XtraUserControl
    Private txtName As New TextEdit With {.ForeColor = Color.Blue}
    Private frmLayout As New LayoutControl() With {.Dock = DockStyle.Fill}

    Public ReadOnly Property Password() As String
        Get
            Return txtName.EditValue
        End Get
    End Property

    Public Sub New(ByVal fieldName As String, ByVal tableName As String)
        txtName.Tag = fieldName
        frmLayout.Tag = tableName
        frmLayout.AddItem("Name :", txtName).TextVisible = True
        txtName.Properties.CharacterCasing = CharacterCasing.Upper
        Me.Controls.Add(frmLayout)
        Me.Height = 60
        Me.Dock = DockStyle.Top
    End Sub

    Public Sub AddRecord()

        If DBManger.isRequiredFieldEmpty(frmLayout, Color.Blue) Then
            XtraMessageBox.Show("There are some required fields (MARDKED) are empty", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        DBManger.InsertRecord(frmLayout)
        DBManger.XtraFormRefresh(frmLayout)
        txtName.Focus()

    End Sub

End Class

Friend Class PopupAddPeriod
    Inherits XtraUserControl

    Private txtName As New TextEdit With {.ForeColor = Color.Blue, .Tag = "PeriodName"}
    Private dtStart As New DateEdit With {.ForeColor = Color.Blue, .Tag = "StartDate"}
    Private dtEnd As New DateEdit With {.ForeColor = Color.Blue, .Tag = "EndDate"}
    Private frmLayout As New LayoutControl() With {.Dock = DockStyle.Fill, .Tag = "syPeriods"}


    Public Sub New()

        frmLayout.AddItem("Name :", txtName).TextVisible = True
        frmLayout.AddItem("Start Date :", dtStart).TextVisible = True
        frmLayout.AddItem("End Date :", dtEnd).TextVisible = True
        txtName.Properties.CharacterCasing = CharacterCasing.Upper
        Me.Controls.Add(frmLayout)
        Me.Height = frmLayout.Height - 40
        Me.Dock = DockStyle.Top
    End Sub

    Public Sub AddRecord()

        If DBManger.isRequiredFieldEmpty(frmLayout, Color.Blue) Then
            XtraMessageBox.Show("There are some required fields (MARDKED) are empty", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        DBManger.InsertRecord(frmLayout)
        DBManger.XtraFormRefresh(frmLayout)
        txtName.Focus()

    End Sub

End Class
