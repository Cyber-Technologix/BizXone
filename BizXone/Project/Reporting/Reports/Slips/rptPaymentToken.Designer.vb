<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptPaymentToken
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
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptPaymentToken))
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrReportInfo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrReportName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TitleHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrDeveloper = New DevExpress.XtraReports.UI.XRRichText()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0!
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TransactionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 13.95833!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrDeveloper})
        Me.BottomMargin.HeightF = 25.29233!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.ReportFooter.HeightF = 29.16695!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.StylePriority.UseBorders = False
        '
        'xrLabel1
        '
        Me.xrLabel1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 2.999974!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(305.1496!, 21.4166!)
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "Thank you"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrReportInfo, Me.XrLogo})
        Me.ReportHeader.HeightF = 72.66677!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrReportInfo
        '
        Me.XrReportInfo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 52.54176!)
        Me.XrReportInfo.Name = "XrReportInfo"
        Me.XrReportInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrReportInfo.SizeF = New System.Drawing.SizeF(305.1496!, 17.70833!)
        Me.XrReportInfo.StylePriority.UseTextAlignment = False
        Me.XrReportInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrReportName})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrReportName
        '
        Me.XrReportName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrReportName.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrReportName.Name = "XrReportName"
        Me.XrReportName.StylePriority.UseBorders = False
        Me.XrReportName.StylePriority.UseFont = False
        Me.XrReportName.StylePriority.UseTextAlignment = False
        Me.XrReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrReportName.Weight = 0.67644498203645742R
        '
        'XrLogo
        '
        Me.XrLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrLogo.ImageSource"))
        Me.XrLogo.LocationFloat = New DevExpress.Utils.PointFloat(106.375!, 0!)
        Me.XrLogo.Name = "XrLogo"
        Me.XrLogo.Scripts.OnBeforePrint = "XrLogo_BeforePrint"
        Me.XrLogo.SizeF = New System.Drawing.SizeF(60.58334!, 48.33334!)
        Me.XrLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'TitleHeader
        '
        Me.TitleHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrBarCode1, Me.xrTable2})
        Me.TitleHeader.HeightF = 139.7493!
        Me.TitleHeader.Name = "TitleHeader"
        '
        'xrBarCode1
        '
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InventoryID]")})
        Me.xrBarCode1.Font = New DevExpress.Drawing.DXFont("Tahoma", 10.0!)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(88.29168!, 35.66669!)
        Me.xrBarCode1.Module = 4.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.ShowText = False
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(108.0332!, 100.9161!)
        Me.xrBarCode1.StylePriority.UseFont = False
        Me.xrBarCode1.StylePriority.UsePadding = False
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        Me.xrBarCode1.Symbology = QrCodeGenerator1
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'xrTable2
        '
        Me.xrTable2.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(305.1496!, 35.66668!)
        Me.xrTable2.StylePriority.UseTextAlignment = False
        Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'tableRow2
        '
        Me.tableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell4})
        Me.tableRow2.Name = "tableRow2"
        Me.tableRow2.Weight = 0.8799998540463897R
        '
        'tableCell4
        '
        Me.tableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EntryDate]")})
        Me.tableCell4.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.tableCell4.Multiline = True
        Me.tableCell4.Name = "tableCell4"
        Me.tableCell4.StylePriority.UseFont = False
        Me.tableCell4.StylePriority.UsePadding = False
        Me.tableCell4.StylePriority.UseTextAlignment = False
        Me.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell4.TextFormatString = "Date/ Time: {0:dd/MM/yyyy HH:mm:ss}"
        Me.tableCell4.Weight = 2.0R
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell2})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 0.8799998540463897R
        '
        'tableCell2
        '
        Me.tableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EmployeeName]")})
        Me.tableCell2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.tableCell2.Multiline = True
        Me.tableCell2.Name = "tableCell2"
        Me.tableCell2.StylePriority.UseFont = False
        Me.tableCell2.StylePriority.UsePadding = False
        Me.tableCell2.StylePriority.UseTextAlignment = False
        Me.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell2.TextFormatString = "Employee: {0}"
        Me.tableCell2.Weight = 2.0R
        '
        'XrDeveloper
        '
        Me.XrDeveloper.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrDeveloper.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrDeveloper.Name = "XrDeveloper"
        Me.XrDeveloper.SerializableRtfString = resources.GetString("XrDeveloper.SerializableRtfString")
        Me.XrDeveloper.SizeF = New System.Drawing.SizeF(306.1496!, 16.00002!)
        Me.XrDeveloper.StylePriority.UseFont = False
        '
        'rptPaymentToken
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.ReportHeader, Me.TitleHeader})
        Me.DisplayName = "Roll Paper"
        Me.DrawGrid = False
        Me.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0!, 0!, 13.95833!, 25.29233!)
        Me.PageHeight = 540
        Me.PageWidth = 310
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom
        Me.RequestParameters = False
        Me.RollPaper = True
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.ShowPreviewMarginLines = False
        Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Version = "24.1"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {XrWatermark1})
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrReportInfo As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrReportName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents TitleHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrDeveloper As DevExpress.XtraReports.UI.XRRichText
End Class
