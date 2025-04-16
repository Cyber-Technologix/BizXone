Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Extensions

Public Class FBRTransaction


    Public Property FBRResponse As FBRInvoiceResponse

    '' Initialize FBR POS integration with appropriate API URL and API key******Sandbox******
    'Private apiUrl As String = "https://esp.fbr.gov.pk:8244/FBR/v1/api/Live/PostData" ' 
    'Private apiKey As String = "1298b5eb-b252-3d97-8622-a4a69d5bf818"

    Private apiUrl As String = "https://gw.fbr.gov.pk/imsp/v1/api/Live/PostData"
    Private apiKey As String = "ced0b21c-1576-32f4-a812-fca6317eb279"

    Dim fbrService As New FBRServiceApi(apiUrl, apiKey) '815223

    Public Function SendFBRTransaction(CounterPOSID As Integer, TInventoryID As Long) As Boolean

        Dim result As Boolean = False
        Dim Counter_POSID As Integer = My.Settings.setTellerID

        If Not My.Settings.isAllowFBR Then Exit Function

        Try

            Dim Query As String = String.Format("SELECT InventoryID as InvoiceNumber,ClientName as BuyerName,sum(Quantity) as TotalQuantity,sum(Amount) as TotalSaleValue,
		    NetDiscount as Discount, 0 as TotalTaxCharged,NetValue as TotalBillAmount  FROM vwInventory WHERE InventoryID={0}
		    Group by InventoryID ,ClientName,NetDiscount,NetValue;", TInventoryID)


            Dim dt = DBManger.XtraLoadDataTable(Query)

            Dim transaction As New TransactionData With {
                .POSID = CounterPOSID,
                .InvoiceNumber = dt.Rows(0)("InvoiceNumber").ToString,
                .BuyerName = dt.Rows(0)("BuyerName").ToString,
                .TotalQuantity = Convert.ToDouble(dt.Rows(0)("TotalQuantity")),
                .TotalSaleValue = Convert.ToDouble(dt.Rows(0)("TotalSaleValue")),
                .Discount = Convert.ToDouble(dt.Rows(0)("Discount")),
                .TotalTaxCharged = Convert.ToDouble(dt.Rows(0)("TotalTaxCharged")),
                .TotalBillAmount = Convert.ToDouble(dt.Rows(0)("TotalBillAmount")),
                .Items = TransactionItems(TInventoryID)
            }

            If fbrService.SendTransaction(transaction) Then
                FBRResponse = fbrService.ResultApi
                'XtraMessageBox.Show("Transaction sent successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                result = True
            Else
                XtraMessageBox.Show("Transaction to FBR was not successful!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return result
    End Function
    Private Function TransactionItems(TInventoryID As Long) As List(Of InvoiceItems)
        Dim lst As New List(Of InvoiceItems)()

        Dim Items As String = String.Format("SELECT ProductID AS ItemCode, ProductName AS ItemName, Quantity, Discount, Amount AS SaleValue, 0 TaxRate,0 TaxCharged, Amount as TotalAmount
            FROM   vwInventory WHERE InventoryID={0};", TInventoryID)

        Dim dtItems As DataTable = DBManger.XtraLoadDataTable(Items)

        dtItems.Select.ForEach(Sub(x)

                                   Dim objItem As New InvoiceItems With {
                                    .ItemCode = x.Item("ItemCode").ToString,
                                    .ItemName = x.Item("ItemName").ToString,
                                    .Quantity = Convert.ToDouble(x.Item("Quantity")),
                                    .Discount = Convert.ToDouble(x.Item("Discount")),
                                    .SaleValue = Convert.ToDouble(x.Item("SaleValue")),
                                    .TaxRate = Convert.ToInt32(x.Item("TaxRate")),
                                    .TaxCharged = Convert.ToDouble(x.Item("TaxCharged")),
                                    .TotalAmount = Convert.ToDouble(x.Item("TotalAmount"))}
                                   lst.Add(objItem)

                               End Sub)


        Return lst
    End Function

End Class
