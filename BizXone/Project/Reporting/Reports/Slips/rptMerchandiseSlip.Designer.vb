<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptMerchandiseSlip
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptMerchandiseSlip))
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.table1 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrReportInfo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrReportName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.TitleHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.barCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.table2 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.line2 = New DevExpress.XtraReports.UI.XRLine()
        Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.table3 = New DevExpress.XtraReports.UI.XRTable()
        Me.tableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.tableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.tableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrDeveloper = New DevExpress.XtraReports.UI.XRRichText()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table1})
        Me.Detail.HeightF = 16.41674!
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TransactionID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'table1
        '
        Me.table1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.table1.BorderColor = System.Drawing.Color.LightGray
        Me.table1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table1.Font = New DevExpress.Drawing.DXFont("Arial", 8.0!)
        Me.table1.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0!)
        Me.table1.Name = "table1"
        Me.table1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow4})
        Me.table1.SizeF = New System.Drawing.SizeF(306.1496!, 16.41674!)
        Me.table1.StylePriority.UseBorderColor = False
        Me.table1.StylePriority.UseBorders = False
        Me.table1.StylePriority.UseFont = False
        Me.table1.StylePriority.UsePadding = False
        '
        'tableRow4
        '
        Me.tableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell16, Me.tableCell7, Me.tableCell6, Me.tableCell5, Me.tableCell8})
        Me.tableRow4.Name = "tableRow4"
        Me.tableRow4.Weight = 11.5R
        '
        'tableCell16
        '
        Me.tableCell16.BorderColor = System.Drawing.Color.LightGray
        Me.tableCell16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell16.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
        Me.tableCell16.Font = New DevExpress.Drawing.DXFont("Arial", 7.0!)
        Me.tableCell16.Multiline = True
        Me.tableCell16.Name = "tableCell16"
        Me.tableCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.tableCell16.StylePriority.UseBorderColor = False
        Me.tableCell16.StylePriority.UseBorders = False
        Me.tableCell16.StylePriority.UseFont = False
        Me.tableCell16.StylePriority.UsePadding = False
        Me.tableCell16.StylePriority.UseTextAlignment = False
        Me.tableCell16.Text = "tableCell16"
        Me.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.tableCell16.Weight = 2.1742425522015267R
        '
        'tableCell7
        '
        Me.tableCell7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell7.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Rate]")})
        Me.tableCell7.Font = New DevExpress.Drawing.DXFont("Arial", 7.0!)
        Me.tableCell7.Name = "tableCell7"
        Me.tableCell7.StylePriority.UseBorders = False
        Me.tableCell7.StylePriority.UseFont = False
        Me.tableCell7.StylePriority.UseTextAlignment = False
        Me.tableCell7.Text = "xrTableCell1"
        Me.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell7.TextFormatString = "{0:0.00}"
        Me.tableCell7.Weight = 0.66677103574271313R
        '
        'tableCell6
        '
        Me.tableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")})
        Me.tableCell6.Font = New DevExpress.Drawing.DXFont("Arial", 7.0!)
        Me.tableCell6.Name = "tableCell6"
        Me.tableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100.0!)
        Me.tableCell6.StylePriority.UseBorders = False
        Me.tableCell6.StylePriority.UseFont = False
        Me.tableCell6.StylePriority.UsePadding = False
        Me.tableCell6.StylePriority.UseTextAlignment = False
        Me.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell6.TextFormatString = "{0:N0}"
        Me.tableCell6.Weight = 0.46479970992267627R
        '
        'tableCell5
        '
        Me.tableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]")})
        Me.tableCell5.Font = New DevExpress.Drawing.DXFont("Arial", 7.0!)
        Me.tableCell5.Multiline = True
        Me.tableCell5.Name = "tableCell5"
        Me.tableCell5.StylePriority.UseBorders = False
        Me.tableCell5.StylePriority.UseFont = False
        Me.tableCell5.StylePriority.UseTextAlignment = False
        Me.tableCell5.Text = "tableCell5"
        Me.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell5.TextFormatString = "{0:N0}"
        Me.tableCell5.Weight = 0.44041078088382213R
        '
        'tableCell8
        '
        Me.tableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell8.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]")})
        Me.tableCell8.Font = New DevExpress.Drawing.DXFont("Arial", 7.0!)
        Me.tableCell8.Name = "tableCell8"
        Me.tableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100.0!)
        Me.tableCell8.StylePriority.UseBorders = False
        Me.tableCell8.StylePriority.UseFont = False
        Me.tableCell8.StylePriority.UsePadding = False
        Me.tableCell8.StylePriority.UseTextAlignment = False
        Me.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell8.TextFormatString = "{0:0.00}"
        Me.tableCell8.Weight = 0.70996650684168616R
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
        Me.ReportFooter.HeightF = 35.12471!
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.StylePriority.UseBorders = False
        '
        'xrLabel1
        '
        Me.xrLabel1.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(8.100403!, 2.999974!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(298.1496!, 21.4166!)
        Me.xrLabel1.StylePriority.UseBorders = False
        Me.xrLabel1.StylePriority.UsePadding = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "Thank you"
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrReportInfo, Me.XrTable6, Me.XrLogo})
        Me.ReportHeader.HeightF = 117.2501!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrReportInfo
        '
        Me.XrReportInfo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 99.54176!)
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
        'XrTable6
        '
        Me.XrTable6.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 51.33333!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9, Me.XrTableRow11, Me.XrTableRow10})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(299.1496!, 44.16666!)
        Me.XrTable6.StylePriority.UseFont = False
        Me.XrTable6.StylePriority.UseTextAlignment = False
        Me.XrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrHeading_1})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Weight = 1.0R
        '
        'XrHeading_1
        '
        Me.XrHeading_1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!)
        Me.XrHeading_1.Name = "XrHeading_1"
        Me.XrHeading_1.StylePriority.UseFont = False
        Me.XrHeading_1.Text = "NATIONAL GARRSION CADET SCHOOL"
        Me.XrHeading_1.Weight = 1.0R
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrHeading_2})
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrHeading_2
        '
        Me.XrHeading_2.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!)
        Me.XrHeading_2.Name = "XrHeading_2"
        Me.XrHeading_2.StylePriority.UseFont = False
        Me.XrHeading_2.Text = "RAHIM YAR KHAN"
        Me.XrHeading_2.Weight = 1.0R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrHeading_3})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Weight = 1.0R
        '
        'XrHeading_3
        '
        Me.XrHeading_3.BorderColor = System.Drawing.Color.LightGray
        Me.XrHeading_3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrHeading_3.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!)
        Me.XrHeading_3.Name = "XrHeading_3"
        Me.XrHeading_3.StylePriority.UseBorderColor = False
        Me.XrHeading_3.StylePriority.UseBorders = False
        Me.XrHeading_3.StylePriority.UseFont = False
        Me.XrHeading_3.Text = "PH NO."
        Me.XrHeading_3.Weight = 1.0R
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
        Me.TitleHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2, Me.barCode1})
        Me.TitleHeader.HeightF = 76.37488!
        Me.TitleHeader.Level = 1
        Me.TitleHeader.Name = "TitleHeader"
        '
        'xrTable2
        '
        Me.xrTable2.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow2, Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(294.1496!, 35.66668!)
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
        'barCode1
        '
        Me.barCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.barCode1.AutoModule = True
        Me.barCode1.BorderWidth = 0!
        Me.barCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InventoryID]")})
        Me.barCode1.Font = New DevExpress.Drawing.DXFont("Arial", 6.0!)
        Me.barCode1.LocationFloat = New DevExpress.Utils.PointFloat(7.000001!, 39.99998!)
        Me.barCode1.Name = "barCode1"
        Me.barCode1.SizeF = New System.Drawing.SizeF(293.0!, 31.74989!)
        Me.barCode1.StylePriority.UseBorderWidth = False
        Me.barCode1.StylePriority.UseFont = False
        Me.barCode1.StylePriority.UsePadding = False
        Me.barCode1.StylePriority.UseTextAlignment = False
        Me.barCode1.Symbology = Code128Generator1
        Me.barCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.table2})
        Me.GroupHeader1.HeightF = 13.16674!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'table2
        '
        Me.table2.BorderColor = System.Drawing.Color.LightGray
        Me.table2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.table2.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0!)
        Me.table2.Name = "table2"
        Me.table2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.table2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow5})
        Me.table2.SizeF = New System.Drawing.SizeF(306.1496!, 13.16674!)
        Me.table2.StylePriority.UseBorderColor = False
        Me.table2.StylePriority.UseBorders = False
        Me.table2.StylePriority.UseFont = False
        '
        'tableRow5
        '
        Me.tableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell15, Me.tableCell9, Me.tableCell10, Me.tableCell11, Me.tableCell12})
        Me.tableRow5.Name = "tableRow5"
        Me.tableRow5.Weight = 1.0R
        '
        'tableCell15
        '
        Me.tableCell15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell15.Multiline = True
        Me.tableCell15.Name = "tableCell15"
        Me.tableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.tableCell15.StylePriority.UseBorders = False
        Me.tableCell15.StylePriority.UsePadding = False
        Me.tableCell15.StylePriority.UseTextAlignment = False
        Me.tableCell15.Text = "Product"
        Me.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell15.Weight = 2.4574359514031889R
        '
        'tableCell9
        '
        Me.tableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell9.Multiline = True
        Me.tableCell9.Name = "tableCell9"
        Me.tableCell9.StylePriority.UseBorders = False
        Me.tableCell9.StylePriority.UseTextAlignment = False
        Me.tableCell9.Text = "Rate"
        Me.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell9.Weight = 0.75361731815713706R
        '
        'tableCell10
        '
        Me.tableCell10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell10.Multiline = True
        Me.tableCell10.Name = "tableCell10"
        Me.tableCell10.StylePriority.UseBorders = False
        Me.tableCell10.StylePriority.UseTextAlignment = False
        Me.tableCell10.Text = "Qty"
        Me.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell10.Weight = 0.52533891296541868R
        '
        'tableCell11
        '
        Me.tableCell11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell11.Multiline = True
        Me.tableCell11.Name = "tableCell11"
        Me.tableCell11.StylePriority.UseBorders = False
        Me.tableCell11.StylePriority.UseTextAlignment = False
        Me.tableCell11.Text = "Dis"
        Me.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell11.Weight = 0.49777390810236766R
        '
        'tableCell12
        '
        Me.tableCell12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.tableCell12.Multiline = True
        Me.tableCell12.Name = "tableCell12"
        Me.tableCell12.StylePriority.UseBorders = False
        Me.tableCell12.StylePriority.UseTextAlignment = False
        Me.tableCell12.Text = "Amount"
        Me.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.tableCell12.Weight = 0.80243909961564674R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.line2, Me.label1, Me.xrBarCode1, Me.table3})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 93.49991!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'line2
        '
        Me.line2.BorderColor = System.Drawing.Color.LightGray
        Me.line2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.line2.ForeColor = System.Drawing.Color.LightGray
        Me.line2.LocationFloat = New DevExpress.Utils.PointFloat(1.0!, 0!)
        Me.line2.Name = "line2"
        Me.line2.SizeF = New System.Drawing.SizeF(308.1496!, 2.083333!)
        Me.line2.StylePriority.UseBorderColor = False
        Me.line2.StylePriority.UseBorderDashStyle = False
        Me.line2.StylePriority.UseForeColor = False
        '
        'label1
        '
        Me.label1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FBRCode]")})
        Me.label1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(106.375!, 75.12495!)
        Me.label1.Multiline = True
        Me.label1.Name = "label1"
        Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label1.SizeF = New System.Drawing.SizeF(198.7746!, 17.3749!)
        Me.label1.StylePriority.UseFont = False
        Me.label1.Text = "FBR Invoice #"
        Me.label1.TextFormatString = "FBR Invoice#:{0}"
        '
        'xrBarCode1
        '
        Me.xrBarCode1.AutoModule = True
        Me.xrBarCode1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FBRCode]")})
        Me.xrBarCode1.Font = New DevExpress.Drawing.DXFont("Tahoma", 10.0!)
        Me.xrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 4.708195!)
        Me.xrBarCode1.Module = 4.0!
        Me.xrBarCode1.Name = "xrBarCode1"
        Me.xrBarCode1.ShowText = False
        Me.xrBarCode1.SizeF = New System.Drawing.SizeF(96.57482!, 88.79172!)
        Me.xrBarCode1.StylePriority.UseFont = False
        Me.xrBarCode1.StylePriority.UsePadding = False
        Me.xrBarCode1.StylePriority.UseTextAlignment = False
        Me.xrBarCode1.Symbology = QrCodeGenerator1
        Me.xrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'table3
        '
        Me.table3.BorderColor = System.Drawing.Color.LightGray
        Me.table3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.table3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.table3.LocationFloat = New DevExpress.Utils.PointFloat(106.375!, 6.83326!)
        Me.table3.Name = "table3"
        Me.table3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.table3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.tableRow6, Me.tableRow7, Me.tableRow8})
        Me.table3.SizeF = New System.Drawing.SizeF(198.7746!, 65.62498!)
        Me.table3.StylePriority.UseBorderColor = False
        Me.table3.StylePriority.UseBorders = False
        Me.table3.StylePriority.UseFont = False
        '
        'tableRow6
        '
        Me.tableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell13, Me.tableCell14})
        Me.tableRow6.Name = "tableRow6"
        Me.tableRow6.Weight = 1.0R
        '
        'tableCell13
        '
        Me.tableCell13.Multiline = True
        Me.tableCell13.Name = "tableCell13"
        Me.tableCell13.StylePriority.UseTextAlignment = False
        Me.tableCell13.Text = "Total Amount :"
        Me.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell13.Weight = 2.0R
        '
        'tableCell14
        '
        Me.tableCell14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Amount])")})
        Me.tableCell14.Multiline = True
        Me.tableCell14.Name = "tableCell14"
        Me.tableCell14.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.tableCell14.Summary = XrSummary1
        Me.tableCell14.Text = "tableCell14"
        Me.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell14.TextFormatString = "{0:N2}"
        Me.tableCell14.Weight = 1.872898224861391R
        '
        'tableRow7
        '
        Me.tableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell19, Me.tableCell20})
        Me.tableRow7.Name = "tableRow7"
        Me.tableRow7.Weight = 1.0R
        '
        'tableCell19
        '
        Me.tableCell19.Multiline = True
        Me.tableCell19.Name = "tableCell19"
        Me.tableCell19.StylePriority.UseTextAlignment = False
        Me.tableCell19.Text = "Net Discount :"
        Me.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell19.Weight = 2.0R
        '
        'tableCell20
        '
        Me.tableCell20.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NetDiscount]")})
        Me.tableCell20.Multiline = True
        Me.tableCell20.Name = "tableCell20"
        Me.tableCell20.StylePriority.UseTextAlignment = False
        Me.tableCell20.Text = "tableCell20"
        Me.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell20.TextFormatString = "{0:N2}"
        Me.tableCell20.Weight = 1.872898224861391R
        '
        'tableRow8
        '
        Me.tableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.tableCell22, Me.tableCell23})
        Me.tableRow8.Name = "tableRow8"
        Me.tableRow8.Weight = 1.0R
        '
        'tableCell22
        '
        Me.tableCell22.Multiline = True
        Me.tableCell22.Name = "tableCell22"
        Me.tableCell22.StylePriority.UseTextAlignment = False
        Me.tableCell22.Text = "Net Amount :"
        Me.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell22.Weight = 2.0R
        '
        'tableCell23
        '
        Me.tableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NetValue]")})
        Me.tableCell23.Multiline = True
        Me.tableCell23.Name = "tableCell23"
        Me.tableCell23.StylePriority.UseTextAlignment = False
        Me.tableCell23.Text = "tableCell23"
        Me.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.tableCell23.TextFormatString = "{0:N2}"
        Me.tableCell23.Weight = 1.872898224861391R
        '
        'XrDeveloper
        '
        Me.XrDeveloper.Font = New DevExpress.Drawing.DXFont("Tahoma", 6.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrDeveloper.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrDeveloper.Name = "XrDeveloper"
        Me.XrDeveloper.SerializableRtfString = resources.GetString("XrDeveloper.SerializableRtfString")
        Me.XrDeveloper.SizeF = New System.Drawing.SizeF(305.1496!, 16.00002!)
        Me.XrDeveloper.StylePriority.UseFont = False
        '
        'rptMerchandiseSlip
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.ReportHeader, Me.TitleHeader, Me.GroupHeader1, Me.GroupFooter1})
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
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.table3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents table1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents TitleHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents barCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents table2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents line2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents label1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents table3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents tableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents tableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents tableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrReportInfo As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrReportName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrDeveloper As DevExpress.XtraReports.UI.XRRichText
End Class
