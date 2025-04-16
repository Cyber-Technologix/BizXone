<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptBalanceSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptBalanceSheet))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrRunTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo3 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrDeveloper = New DevExpress.XtraReports.UI.XRRichText()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrReportInfo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrReportName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrPeriod = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GH_AccountHead = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 22.49997!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("HeadTypeID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("AccountTypeName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(4.999969!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(767.0!, 22.49997!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BorderColor = System.Drawing.Color.Silver
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrRunTotal})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBorderColor = False
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountName]")})
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell2.Weight = 4.9092729332635834R
        '
        'XrRunTotal
        '
        Me.XrRunTotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Balance]")})
        Me.XrRunTotal.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrRunTotal.Name = "XrRunTotal"
        Me.XrRunTotal.StylePriority.UseFont = False
        Me.XrRunTotal.StylePriority.UseTextAlignment = False
        Me.XrRunTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrRunTotal.TextFormatString = "{0:#,##0.00 Cr;#,##0.00 Dr}"
        Me.XrRunTotal.Weight = 1.3094110728295436R
        '
        'PageHeader
        '
        Me.PageHeader.BorderColor = System.Drawing.Color.Black
        Me.PageHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.PageHeader.HeightF = 28.79168!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseFont = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable3
        '
        Me.XrTable3.BackColor = System.Drawing.Color.White
        Me.XrTable3.BorderColor = System.Drawing.Color.Black
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.BorderWidth = 1.0!
        Me.XrTable3.ForeColor = System.Drawing.Color.White
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3.166667!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(772.0!, 25.0!)
        Me.XrTable3.StylePriority.UseBackColor = False
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseBorderWidth = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow4
        '
        Me.XrTableRow4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableRow4.BorderColor = System.Drawing.Color.White
        Me.XrTableRow4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell11, Me.XrTableCell17})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.StylePriority.UseBackColor = False
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell7.BorderColor = System.Drawing.Color.White
        Me.XrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell7.BorderWidth = 1.0!
        Me.XrTableCell7.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell7.ForeColor = System.Drawing.Color.White
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBackColor = False
        Me.XrTableCell7.StylePriority.UseBorderColor = False
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseForeColor = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "ID"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.43601892246741497R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell11.BorderColor = System.Drawing.Color.White
        Me.XrTableCell11.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell11.BorderWidth = 1.0!
        Me.XrTableCell11.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell11.ForeColor = System.Drawing.Color.White
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseBackColor = False
        Me.XrTableCell11.StylePriority.UseBorderColor = False
        Me.XrTableCell11.StylePriority.UseBorders = False
        Me.XrTableCell11.StylePriority.UseBorderWidth = False
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseForeColor = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Account Name"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 2.4573449579071189R
        '
        'XrTableCell17
        '
        Me.XrTableCell17.BorderWidth = 1.0!
        Me.XrTableCell17.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseBorderWidth = False
        Me.XrTableCell17.StylePriority.UseFont = False
        Me.XrTableCell17.Text = "Balance"
        Me.XrTableCell17.Weight = 0.76540373399689887R
        '
        'PageFooter
        '
        Me.PageFooter.BorderWidth = 1.0!
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo3, Me.XrDeveloper})
        Me.PageFooter.HeightF = 19.37504!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.StylePriority.UseBorderWidth = False
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'XrPageInfo3
        '
        Me.XrPageInfo3.Font = New DevExpress.Drawing.DXFont("Verdana", 6.0!)
        Me.XrPageInfo3.LocationFloat = New DevExpress.Utils.PointFloat(435.3751!, 0!)
        Me.XrPageInfo3.Name = "XrPageInfo3"
        Me.XrPageInfo3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo3.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo3.SizeF = New System.Drawing.SizeF(219.6249!, 16.00002!)
        Me.XrPageInfo3.StylePriority.UseFont = False
        Me.XrPageInfo3.StylePriority.UseTextAlignment = False
        Me.XrPageInfo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrPageInfo3.TextFormatString = "Date: {0:dddd, dd MMMM yyyy}"
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
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLogo, Me.XrTable6, Me.XrReportInfo})
        Me.ReportHeader.HeightF = 125.5833!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLogo
        '
        Me.XrLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrLogo.ImageSource"))
        Me.XrLogo.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 1.0!)
        Me.XrLogo.Name = "XrLogo"
        Me.XrLogo.SizeF = New System.Drawing.SizeF(71.0!, 65.00001!)
        Me.XrLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(86.00001!, 1.0!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9, Me.XrTableRow11, Me.XrTableRow10})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(455.6667!, 65.00001!)
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
        Me.XrHeading_1.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
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
        Me.XrHeading_2.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
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
        Me.XrHeading_3.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrHeading_3.Name = "XrHeading_3"
        Me.XrHeading_3.StylePriority.UseFont = False
        Me.XrHeading_3.Text = "PH NO."
        Me.XrHeading_3.Weight = 1.0R
        '
        'XrReportInfo
        '
        Me.XrReportInfo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 71.0!)
        Me.XrReportInfo.Name = "XrReportInfo"
        Me.XrReportInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6, Me.XrTableRow7})
        Me.XrReportInfo.SizeF = New System.Drawing.SizeF(773.6249!, 50.0!)
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
        Me.XrReportName.Font = New DevExpress.Drawing.DXFont("Tahoma", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrReportName.Name = "XrReportName"
        Me.XrReportName.StylePriority.UseBorders = False
        Me.XrReportName.StylePriority.UseFont = False
        Me.XrReportName.StylePriority.UseTextAlignment = False
        Me.XrReportName.Text = "Accounts Balance Sheet"
        Me.XrReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrReportName.Weight = 1.0R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrPeriod})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrPeriod
        '
        Me.XrPeriod.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPeriod.Name = "XrPeriod"
        Me.XrPeriod.StylePriority.UseFont = False
        Me.XrPeriod.StylePriority.UseTextAlignment = False
        Me.XrPeriod.Text = "XrPeriod"
        Me.XrPeriod.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrPeriod.Weight = 1.0R
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 2.041753!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'GH_AccountHead
        '
        Me.GH_AccountHead.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.GH_AccountHead.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("AccountTypeID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GH_AccountHead.HeightF = 28.74998!
        Me.GH_AccountHead.Name = "GH_AccountHead"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Verdana", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable4.ForeColor = System.Drawing.Color.Green
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(5.000003!, 3.250006!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(261.9027!, 22.49997!)
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseForeColor = False
        Me.XrTable4.StylePriority.UsePadding = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BorderColor = System.Drawing.Color.Silver
        Me.XrTableRow2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBorderColor = False
        Me.XrTableRow2.StylePriority.UseBorders = False
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.LightGray
        Me.XrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountTypeName]")})
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Verdana", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 2.08291612413972R
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("HeadID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 25.24999!
        Me.GroupHeader1.Level = 1
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrTable2
        '
        Me.XrTable2.ForeColor = System.Drawing.Color.Red
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(4.999971!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(766.9999!, 23.0!)
        Me.XrTable2.StylePriority.UseForeColor = False
        Me.XrTable2.StylePriority.UsePadding = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell4})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell9.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HeadName]")})
        Me.XrTableCell9.Font = New DevExpress.Drawing.DXFont("Tahoma", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 3.1793962199115295R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HeadTypeDesc]")})
        Me.XrTableCell4.Font = New DevExpress.Drawing.DXFont("Tahoma", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell4.ForeColor = System.Drawing.Color.Red
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseForeColor = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell4.Weight = 3.1793962199115295R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.GroupFooter1.HeightF = 24.58445!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrTable5
        '
        Me.XrTable5.BackColor = System.Drawing.Color.LightGray
        Me.XrTable5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable5.Font = New DevExpress.Drawing.DXFont("Verdana", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable5.ForeColor = System.Drawing.Color.Green
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(542.7915!, 2.0!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(229.2084!, 22.49997!)
        Me.XrTable5.StylePriority.UseBackColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseForeColor = False
        Me.XrTable5.StylePriority.UsePadding = False
        '
        'XrTableRow5
        '
        Me.XrTableRow5.BorderColor = System.Drawing.Color.Silver
        Me.XrTableRow5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell5})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.StylePriority.UseBorderColor = False
        Me.XrTableRow5.StylePriority.UseBorders = False
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Verdana", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Total :"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 1.4575739845157434R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Balance])")})
        Me.XrTableCell5.Font = New DevExpress.Drawing.DXFont("Verdana", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrTableCell5.Summary = XrSummary1
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell5.TextFormatString = "{0:#,##0.00 Cr;#,##0.00 Dr}"
        Me.XrTableCell5.Weight = 3.4766540737166842R
        '
        'rptBalanceSheet
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GH_AccountHead, Me.GroupHeader1, Me.GroupFooter1})
        Me.Bookmark = "Account Head Balance"
        Me.DrawGrid = False
        Me.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.Margins = New DevExpress.Drawing.DXMargins(25.0!, 25.0!, 25.0!, 25.0!)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 4.166667!
        Me.Version = "24.1"
        XrWatermark1.Id = "Watermark1"
        Me.Watermarks.AddRange(New DevExpress.XtraPrinting.Drawing.Watermark() {XrWatermark1})
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrRunTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
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
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrPeriod As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GH_AccountHead As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo3 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrDeveloper As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
End Class
