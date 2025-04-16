Imports DevExpress.XtraBars
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Reflection

Partial Public Class FrmRibbon

    Public Sub New()
        InitializeComponent()

        'Dim dataSource As BindingList(Of Customer) = GetDataSource()
        'bsiRecordsCount.Caption = "RECORDS : " & dataSource.Count
    End Sub
    Private Sub bbiPrintPreview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiPrintPreview.ItemClick
        GridMain.ShowRibbonPrintPreview()
    End Sub
    'Public Function GetDataSource() As BindingList(Of Customer)
    '    Dim result As New BindingList(Of Customer)()
    '    'result.Add(New Customer() With {.ID = 1, .Name = "ACME", .Address = "2525 E El Segundo Blvd", .City = "El Segundo", .State = "CA", .ZipCode = "90245", .Phone = "(310) 536-0611"})
    '    Return result
    'End Function

End Class
