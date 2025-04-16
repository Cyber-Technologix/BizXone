<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProductStock
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptProductStock))
        Dim XrWatermark1 As DevExpress.XtraReports.UI.XRWatermark = New DevExpress.XtraReports.UI.XRWatermark()
        Me.XrAccountName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrAccountID = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrAccountTypeName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrHeadName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrStock = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrReportInfo = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrReportName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLogo = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable6 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrHeading_3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GrandTotal = New DevExpress.XtraReports.UI.FormattingRule()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrDeveloper = New DevExpress.XtraReports.UI.XRRichText()
        Me.ghDeparment = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XrAccountName
        '
        Me.XrAccountName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductName]")})
        Me.XrAccountName.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.XrAccountName.Name = "XrAccountName"
        Me.XrAccountName.StylePriority.UseFont = False
        Me.XrAccountName.StylePriority.UseTextAlignment = False
        Me.XrAccountName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrAccountName.Weight = 2.5695373753280331R
        '
        'XrTableCell13
        '
        Me.XrTableCell13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell13.BorderColor = System.Drawing.Color.White
        Me.XrTableCell13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell13.BorderWidth = 1.0!
        Me.XrTableCell13.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell13.ForeColor = System.Drawing.Color.White
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.StylePriority.UseBackColor = False
        Me.XrTableCell13.StylePriority.UseBorderColor = False
        Me.XrTableCell13.StylePriority.UseBorders = False
        Me.XrTableCell13.StylePriority.UseBorderWidth = False
        Me.XrTableCell13.StylePriority.UseFont = False
        Me.XrTableCell13.StylePriority.UseForeColor = False
        Me.XrTableCell13.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:$0.00}"
        Me.XrTableCell13.Summary = XrSummary1
        Me.XrTableCell13.Text = "Balance"
        Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell13.Weight = 0.75733384814881155R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BorderColor = System.Drawing.Color.Silver
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrAccountID, Me.XrAccountName, Me.XrAccountTypeName, Me.XrTableCell2, Me.XrHeadName, Me.XrStock})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBorderColor = False
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrAccountID
        '
        Me.XrAccountID.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ProductID]")})
        Me.XrAccountID.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrAccountID.Name = "XrAccountID"
        Me.XrAccountID.StylePriority.UseFont = False
        Me.XrAccountID.StylePriority.UseTextAlignment = False
        Me.XrAccountID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrAccountID.Weight = 0.52598508605017957R
        '
        'XrAccountTypeName
        '
        Me.XrAccountTypeName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UnitPrice]")})
        Me.XrAccountTypeName.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrAccountTypeName.Name = "XrAccountTypeName"
        Me.XrAccountTypeName.StylePriority.UseFont = False
        Me.XrAccountTypeName.StylePriority.UseTextAlignment = False
        Me.XrAccountTypeName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrAccountTypeName.TextFormatString = "{0:N2}"
        Me.XrAccountTypeName.Weight = 0.570291081375392R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReorderLevel]")})
        Me.XrTableCell2.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "XrTableCell2"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrTableCell2.Weight = 0.57029106555507447R
        '
        'XrHeadName
        '
        Me.XrHeadName.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Balance]")})
        Me.XrHeadName.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrHeadName.Name = "XrHeadName"
        Me.XrHeadName.StylePriority.UseFont = False
        Me.XrHeadName.StylePriority.UseTextAlignment = False
        Me.XrHeadName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrHeadName.TextFormatString = "{0:N0}"
        Me.XrHeadName.Weight = 0.57029106555507136R
        '
        'XrStock
        '
        Me.XrStock.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrStock.Multiline = True
        Me.XrStock.Name = "XrStock"
        Me.XrStock.StylePriority.UseFont = False
        Me.XrStock.StylePriority.UseTextAlignment = False
        Me.XrStock.Text = "XrStock"
        Me.XrStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrStock.Weight = 0.99928964448481783R
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
        'PageHeader
        '
        Me.PageHeader.BorderColor = System.Drawing.Color.Black
        Me.PageHeader.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.PageHeader.HeightF = 30.0!
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
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 3.999996!)
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
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell1, Me.XrTableCell13, Me.XrTableCell3})
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
        Me.XrTableCell7.Text = " ID"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell7.Weight = 0.52740655645570633R
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
        Me.XrTableCell11.Text = "Product Name"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 3.5833802887763326R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell12.BorderColor = System.Drawing.Color.White
        Me.XrTableCell12.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell12.BorderWidth = 1.0!
        Me.XrTableCell12.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell12.ForeColor = System.Drawing.Color.White
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBackColor = False
        Me.XrTableCell12.StylePriority.UseBorderColor = False
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseBorderWidth = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseForeColor = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "##,#.00"
        Me.XrTableCell12.Summary = XrSummary2
        Me.XrTableCell12.Text = "Price"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell12.Weight = 0.75733382879701883R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell1.BorderColor = System.Drawing.Color.White
        Me.XrTableCell1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.BorderWidth = 1.0!
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell1.ForeColor = System.Drawing.Color.White
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBackColor = False
        Me.XrTableCell1.StylePriority.UseBorderColor = False
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseBorderWidth = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseForeColor = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "Reorder"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.75733386303820516R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.XrTableCell3.BorderColor = System.Drawing.Color.White
        Me.XrTableCell3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.BorderWidth = 1.0!
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell3.ForeColor = System.Drawing.Color.White
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBackColor = False
        Me.XrTableCell3.StylePriority.UseBorderColor = False
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseBorderWidth = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseForeColor = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Remarks"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 1.3270355937379794R
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Transparent
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 22.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseBackColor = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(772.0!, 20.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UsePadding = False
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 25.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrReportInfo
        '
        Me.XrReportInfo.LocationFloat = New DevExpress.Utils.PointFloat(0!, 76.99998!)
        Me.XrReportInfo.Name = "XrReportInfo"
        Me.XrReportInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow6})
        Me.XrReportInfo.SizeF = New System.Drawing.SizeF(772.0!, 25.0!)
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
        Me.XrReportName.Text = "PRODUCT STOCK REPORT"
        Me.XrReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrReportName.Weight = 1.0R
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
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 25.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLogo, Me.XrTable6, Me.XrReportInfo})
        Me.ReportHeader.HeightF = 106.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLogo
        '
        Me.XrLogo.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("XrLogo.ImageSource"))
        Me.XrLogo.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 4.0!)
        Me.XrLogo.Name = "XrLogo"
        Me.XrLogo.Scripts.OnBeforePrint = "XrLogo_BeforePrint"
        Me.XrLogo.SizeF = New System.Drawing.SizeF(71.0!, 65.00001!)
        Me.XrLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrTable6
        '
        Me.XrTable6.LocationFloat = New DevExpress.Utils.PointFloat(101.6667!, 8.166666!)
        Me.XrTable6.Name = "XrTable6"
        Me.XrTable6.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9, Me.XrTableRow11, Me.XrTableRow10})
        Me.XrTable6.SizeF = New System.Drawing.SizeF(435.0!, 62.0!)
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
        'GrandTotal
        '
        Me.GrandTotal.Name = "GrandTotal"
        '
        'PageFooter
        '
        Me.PageFooter.BorderWidth = 1.0!
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrDeveloper, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 17.95832!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.StylePriority.UseBorderWidth = False
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'ghDeparment
        '
        Me.ghDeparment.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
        Me.ghDeparment.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("DepartmentID", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghDeparment.HeightF = 22.00001!
        Me.ghDeparment.Name = "ghDeparment"
        '
        'XrTable5
        '
        Me.XrTable5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrTable5.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.XrTable5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable5.BorderWidth = 0!
        Me.XrTable5.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.000014!)
        Me.XrTable5.Name = "XrTable5"
        Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5})
        Me.XrTable5.SizeF = New System.Drawing.SizeF(772.0!, 20.0!)
        Me.XrTable5.StylePriority.UseBackColor = False
        Me.XrTable5.StylePriority.UseBorderColor = False
        Me.XrTable5.StylePriority.UseBorders = False
        Me.XrTable5.StylePriority.UseBorderWidth = False
        Me.XrTable5.StylePriority.UseFont = False
        Me.XrTable5.StylePriority.UseForeColor = False
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 2.7878787878787881R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrTableCell5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrTableCell5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.BorderWidth = 2.0!
        Me.XrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DepartmentName]")})
        Me.XrTableCell5.Font = New DevExpress.Drawing.DXFont("Tahoma", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.XrTableCell5.StylePriority.UseBackColor = False
        Me.XrTableCell5.StylePriority.UseBorderColor = False
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.StylePriority.UseBorderWidth = False
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseForeColor = False
        Me.XrTableCell5.StylePriority.UsePadding = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "tableCell6"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell5.TextFormatString = "Department :{0}"
        Me.XrTableCell5.Weight = 317.26539980194832R
        '
        'rptProductStock
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.TopMarginBand1, Me.BottomMarginBand1, Me.ghDeparment})
        Me.Bookmark = "Chart of Account"
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
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrReportInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrDeveloper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrAccountName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrAccountID As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrAccountTypeName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrHeadName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrReportInfo As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrReportName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents GrandTotal As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ghDeparment As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLogo As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrTable6 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrHeading_3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrDeveloper As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrStock As DevExpress.XtraReports.UI.XRTableCell
End Class
