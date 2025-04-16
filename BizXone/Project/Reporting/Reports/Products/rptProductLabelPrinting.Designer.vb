<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptProductLabelPrinting
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProductLabelPrinting))
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.panel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrDeveloper = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.panel1})
        Me.Detail.HeightF = 70.83334!
        Me.Detail.MultiColumn.ColumnCount = 4
        Me.Detail.MultiColumn.ColumnWidth = 400.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        '
        'panel1
        '
        Me.panel1.BorderColor = System.Drawing.Color.LightGray
        Me.panel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.panel1.CanGrow = False
        Me.panel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1, Me.xrBarCode1, Me.xrLabel2})
        Me.panel1.LocationFloat = New DevExpress.Utils.PointFloat(0.999999!, 0!)
        Me.panel1.Name = "panel1"
        Me.panel1.SizeF = New System.Drawing.SizeF(188.4583!, 67.08333!)
        Me.panel1.StylePriority.UseBorderColor = False
        '
        'xrLabel1
        '
        Me.xrLabel1.BackColor = System.Drawing.Color.White
        Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel1.CanGrow = False
        Me.xrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "ProductName"), New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([CategoryID] % 2 == 0, Rgb(214,63,60), [CategoryID] == 0 Or [CategoryID] % 3 " &
                    "== 0, Rgb(100,150,194), Rgb(230,138,60))")})
        Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.0!)
        Me.xrLabel1.ForeColor = System.Drawing.Color.Black
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(3.000005!, 1.999998!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(125.4583!, 14.0!)
        Me.xrLabel1.StylePriority.UseBackColor = False
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseForeColor = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "xrLabel1"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrBarCode1
        '
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Barcode]")})
        Me.xrBarCode1.Font = New DevExpress.Drawing.DXFont("Arial", 6.0!)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(3.999995!, 19.00002!)
        Me.xrBarCode1.Module = 0.3937008!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(178.25!, 45.0!)
        Me.xrBarCode1.StylePriority.UseFont = False
        Me.xrBarCode1.StylePriority.UseForeColor = False
        Me.xrBarCode1.StylePriority.UsePadding = False
        Me.xrBarCode1.Symbology = EaN13Generator1
        '
        'xrLabel2
        '
        Me.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel2.CanGrow = False
        Me.xrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
        Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(128.4583!, 1.999998!)
        Me.xrLabel2.Multiline = True
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(53.79166!, 14.0!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.StylePriority.UseForeColor = False
        Me.xrLabel2.StylePriority.UsePadding = False
        Me.xrLabel2.StylePriority.UseTextAlignment = False
        Me.xrLabel2.Text = "xrLabel2"
        Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.xrLabel2.TextFormatString = "{0:N2}"
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrDeveloper, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 40.625!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'XrDeveloper
        '
        Me.XrDeveloper.Font = New DevExpress.Drawing.DXFont("Verdana", 6.0!)
        Me.XrDeveloper.LocationFloat = New DevExpress.Utils.PointFloat(5.0!, 0!)
        Me.XrDeveloper.Name = "XrDeveloper"
        Me.XrDeveloper.SerializableRtfString = resources.GetString("XrDeveloper.SerializableRtfString")
        Me.XrDeveloper.SizeF = New System.Drawing.SizeF(430.3751!, 16.00002!)
        Me.XrDeveloper.StylePriority.UseFont = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New DevExpress.Drawing.DXFont("Verdana", 6.0!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(435.3751!, 0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(219.6249!, 16.00002!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        Me.XrPageInfo2.StylePriority.UseTextAlignment = False
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo2.TextFormatString = "Date: {0:dddd, dd MMMM yyyy}"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New DevExpress.Drawing.DXFont("Verdana", 6.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(655.0!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(117.0!, 16.00002!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrPageInfo1.TextFormatString = "Page# {0} of {1}"
        '
        'rptProductLabelPrinting
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.DisplayName = "Label Report"
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Margins = New DevExpress.Drawing.DXMargins(25.0!, 25.0!, 50.0!, 40.625!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 10
        Me.SnapGridSize = 9.84252!
        Me.Version = "24.1"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {XrWatermark1})
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents panel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrDeveloper As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
End Class
