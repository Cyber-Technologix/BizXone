Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net
Imports DevExpress.XtraEditors

Friend Class FBRServiceApi

    Private ReadOnly _httpclient As HttpClient
    Private ReadOnly _apiUrl As String
    Private ReadOnly _apiKey As String
    Public Property ResultApi As FBRInvoiceResponse

    ' Constructor to initialize HttpClient and API configurations
    Public Sub New(ByVal apiUrl As String, ByVal apiKey As String)
        _httpclient = New HttpClient()
        _apiUrl = apiUrl
        _apiKey = apiKey
    End Sub

    ' Method to send transaction data to FBR

    Public Function SendTransaction(ByVal transaction As TransactionData) As Boolean
        Try
            Dim requestContent As New StringContent(JsonConvert.SerializeObject(transaction), Encoding.UTF8, "application/json")
            _httpclient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", _apiKey)
            ServicePointManager.ServerCertificateValidationCallback = Function(sender, certificate, chain, sslPolicyErrors) True

            Dim response As HttpResponseMessage = _httpclient.PostAsync(_apiUrl, requestContent).Result

            ' Check if the response indicates success
            If response.IsSuccessStatusCode Then
                ' Process the response if needed
                Dim jsonResponse = response.Content.ReadAsStringAsync().Result
                ' Optionally deserialize the response to a response model
                ResultApi = JsonConvert.DeserializeObject(Of FBRInvoiceResponse)(jsonResponse)
                Return True
            Else
                ' Log or handle the error response
                Dim errorContent = response.Content.ReadAsStringAsync().Result

                XtraMessageBox.Show($"Error: {response.StatusCode} {errorContent}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            XtraMessageBox.Show(vbCrLf & ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Class


<Serializable>
Public Class FBRInvoiceResponse
    Public InvoiceNumber, Response, Code As String
End Class


'Sandbox URL
'https://esp.fbr.gov.pk:8244/FBR/v1/api/Live/PostData
'Production URL
'https://gw.fbr.gov.pk/imsp/v1/api/Live/PostData