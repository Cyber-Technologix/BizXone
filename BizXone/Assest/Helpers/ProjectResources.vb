

Imports System.Threading
Imports BizXone.My
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraData


Friend Enum RecordStatus
    Active = 1
    Closed = 2
End Enum
Friend Enum DocumentKind
    Purchase = 1
    PurchaseReturn = 2
    Sale = 3
    SaleReturn = 4
    AccountTransaction = 5
    ClientTransaction = 6
    ReceiptTransaction = 7
    WarehouseTransaction = 8
End Enum

Friend Class ProjectResources

    Public Shared ReadOnly Property POSID As Integer
        Get
            Return _POSID
        End Get
    End Property

    Public Shared ReadOnly Property ActivePeriodID As Integer
        Get
            GetActivePeriod()
            Return _PeriodID
        End Get
    End Property

    Private Shared XAlerts As New AlertControl
    Private Shared _PeriodID, _POSID As Integer

    Public Shared Function AboutMe() As String
        'Return "©Software By Abid Munir, Cell: +923006753477, "2004- & Date.Now.Year
        Return "Zimli Tech, 03065454737, www.zimlitech.com"
    End Function
    Public Shared Sub ApplicationDefaultSkin()

        If My.Settings.Item("SkinName") Is Nothing Then
            UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
        Else
            UserLookAndFeel.Default.SetSkinStyle(My.Settings.Item("SkinName").ToString)
        End If
    End Sub
    Private Shared Sub GetActivePeriod()
        Dim Query As String = "SELECT PeriodID FROM syPeriods WHERE StatusID = 1"
        Dim PeriodID = DBManger.XtraLoadDataTable(Query).AsEnumerable.Select(Function(row) row.Item("PeriodID")).ToList(0)
        _PeriodID = PeriodID
    End Sub


    Public Shared Sub GetDefaultTeller(ByVal SpnTellerID As SpinEdit)
        If My.Settings.setTellerID.Equals(0) Then
            XtraMessageBox.Show("Please set the POS ID in the Settings!", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim Query As String = String.Format("SELECT * FROM tblTellers WHERE TellerID ={0}", CInt(My.Settings.setTellerID))
            Dim obj = DBManger.XtraLoadDataTable(Query).AsEnumerable.ToList

            SpnTellerID.EditValue = obj(0).ItemArray(0)
            _POSID = obj(0).ItemArray(1)
        End If
    End Sub



    Public Shared Function GetProductBarcode(ProductID As String) As String
        Dim Query As String = "SELECT TOP 1 WorkstationID FROM syWorkstations"
        Dim prifix As String = DBManger.XtraLoadDataTable(Query).AsEnumerable.Select(Function(row) row.Item("WorkstationID")).ToList(0)
        Dim code As String = XtraAutoNumber.GetNumberEAN13(prifix, ProductID)
        Return code
    End Function

    Public Shared Function GetInvoiceSearch(DocID As Integer, isHolds As Boolean) As Integer
        Dim Master, Detail As String

        Dim HoldValue = If(isHolds, 1, 0)
        Master = String.Format("Select DISTINCT  TransactionID,InventoryID as MerchandiseID,EntryDate as Dated,Format(cast(GETDATE() as datetime),'HH:mm:ss tt','en-us') as Time, ClientName,Description from vwInventory WHERE  DocID={0} AND isHold={1};", DocID, HoldValue)
        Detail = String.Format("Select DISTINCT TransactionID,ProductName,Quantity,Rate,Discount,Value,Discount,Amount from vwInventory WHERE  DocID={0} AND isHold={1};", DocID, HoldValue)

        Dim ds As DataSet = DBManger.XtraLoadDataSet(String.Concat(Master, Detail))
        ds.Relations.Add("Detail", ds.Tables("Table").Columns(0), ds.Tables("Table1").Columns(0))

        Return DBManger.XtraSearch(Of Int16)("Search", ds, 0)
    End Function

    Public Shared Function LoadProductData(WarehouseID As Integer) As DataTable
        Dim Query = String.Format("EXEC spProducts")
        Dim dt As DataTable = DBManger.XtraLoadDataTable(Query)
        dt.AddAutoIncrementColumn("ItemID")
        dt.Columns("ItemID").SetOrdinal(0)

        If WarehouseID <> 0 Then
            ' Use LINQ to filter instead of Select when dealing with empty results

            Dim filteredRows = dt.AsEnumerable().Where(Function(r) r.Field(Of Integer)("WHID") = WarehouseID)

            If dt.AsEnumerable().Where(Function(r) r.Field(Of Integer)("WHID") = WarehouseID).Any Then
                dt = dt.AsEnumerable().Where(Function(r) r.Field(Of Integer)("WHID") = WarehouseID).CopyToDataTable
            Else
                XtraMessageBox.Show("No Stock available in selected warehouse!", Windows.Forms.Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
        Return dt
    End Function
    Public Shared Function GetAllProductData() As Integer
        Dim Query = String.Format("SELECT ProductID,Barcode,ProductName,Nature,DepartmentName,ManufactureName,UnitCost,UnitPrice,Balance,isNarcotic,Status,EqualToUnit FROM vwProducts")
        Dim dt As DataTable = DBManger.XtraLoadDataTable(Query)
        Return DBManger.XtraSearch(Of Integer)("Product View", dt, 0)
    End Function
    Public Shared Function GetProductData(WarehouseID As Integer) As DataRow
        Dim dt As DataTable = LoadProductData(WarehouseID)
        Return DBManger.XtraSearch("Product View", dt)
    End Function

    Public Shared Sub DesignReport(ByVal logo As XRPictureBox, ByVal ParamArray HD() As XRTableCell)
        'GetHeading_1 Setting
        HD(0).Text = DBManger.GetSettingX(1, "CYBER TECHNOLOGIX")
        HD(0).Font = New Font(DBManger.GetSettingX(10, "Tahoma").ToString, DBManger.GetSettingX(101, 10), FontStyle.Regular)
        'Get Heading_2 Setting
        HD(1).Text = DBManger.GetSettingX(2, "Empowering businesses with smart and seamless transactions.")
        HD(1).Font = New Font(DBManger.GetSettingX(20, "Tahoma").ToString, DBManger.GetSettingX(201, 10), FontStyle.Regular)
        'Get Heading_3 Setting
        HD(2).Text = DBManger.GetSettingX(3, "2002-" & Date.Now.Year)
        HD(1).Font = New Font(DBManger.GetSettingX(30, "Tahoma").ToString, DBManger.GetSettingX(301, 10), FontStyle.Regular)
        logo.ImageUrl = Windows.Forms.Application.StartupPath & "\logo.png"
    End Sub
    Public Shared Sub ShowFontDialog(ByVal ButtonEdit As ButtonEdit)
        Dim dlg As New FontDialog
        If dlg.ShowDialog() = DialogResult.OK Then
            ButtonEdit.Font = dlg.Font
        End If
    End Sub

    Public Shared Sub ShowSplashScreen()
        Dim op As FluentSplashScreenOptions = New FluentSplashScreenOptions With {
            .Title = "Zim Biz",
            .Subtitle = "Empowering businesses with smart and seamless transactions.",
            .RightFooter = "Starting...",
            .LeftFooter = "Faazal Pharmacy & Mart.",
            .LoadingIndicatorType = FluentLoadingIndicatorType.Dots,
            .OpacityColor = Color.LightSkyBlue,
            .Opacity = 150
        }
        SplashScreenManager.ShowFluentSplashScreen(op, useFadeIn:=True, useFadeOut:=True)
        Thread.Sleep(2000)
        SplashScreenManager.CloseForm()
    End Sub
    Public Shared Sub XtraAlertShow(title As String, text As String)
        Dim info As New AlertInfo(title, text)
        XAlerts.Show(MdiRibbon, info)
    End Sub
End Class
