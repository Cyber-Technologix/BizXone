Public Class TransactionData

    Public Property InvoiceNumber As String
    Public Property POSID As Integer
    Public Property Discount As Double
    Public Property TotalBillAmount As Double
    Public Property TotalQuantity As Double
    Public Property TotalSaleValue As Double
    Public Property TotalTaxCharged As Double
    Public Property Items As List(Of InvoiceItems)

    Public Property DateTime As Date = DateTime.Now
    Public Property FurtherTax As Double = 0
    Public Property InvoiceType As Integer = 1
    Public Property PaymentMode As Integer = 1
    Public Property USIN As String = "001897"
    Public Property RefUSIN As String = String.Empty
    Public Property BuyerName As String = String.Empty
    Public Property BuyerNTN As String = String.Empty
    Public Property BuyerCNIC As String = String.Empty
    Public Property BuyerPhoneNumber As String = String.Empty

End Class

Public Class InvoiceItems
    Public Property FurtherTax As Double = 0
    Public Property InvoiceType As Integer = 1
    Public Property PCTCode As String = "11001010"
    Public Property RefUSIN As String = String.Empty

    Public Property ItemCode As String
    Public Property ItemName As String
    Public Property Quantity As Double
    Public Property Discount As Double
    Public Property SaleValue As Double
    Public Property TaxCharged As Double
    Public Property TaxRate As Single
    Public Property TotalAmount As Double
End Class

