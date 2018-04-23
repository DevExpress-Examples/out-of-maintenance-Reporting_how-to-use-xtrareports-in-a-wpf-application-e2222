Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI

Namespace MinimalisticReportPreviewDemo
	Public Class Report
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.nwindDataSet1 = New MinimalisticReportPreviewDemo.nwindDataSet()
            Me.productsTableAdapter = New MinimalisticReportPreviewDemo.nwindDataSetTableAdapters.ProductsTableAdapter()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
            Me.Detail.HeightF = 33.00001!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrLabel1
            '
            Me.xrLabel1.BookmarkParent = Me.xrLabel2
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "Products.ProductName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(408.3333!, 23.0!)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "xrLabel1"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'topMarginBand1
            '
            Me.topMarginBand1.HeightF = 48.0!
            Me.topMarginBand1.Name = "topMarginBand1"
            '
            'bottomMarginBand1
            '
            Me.bottomMarginBand1.HeightF = 48.0!
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            '
            'nwindDataSet1
            '
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'productsTableAdapter
            '
            Me.productsTableAdapter.ClearBeforeFill = True
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2})
            Me.ReportHeader.HeightF = 47.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'xrLabel2
            '
            Me.xrLabel2.Bookmark = "Home"
            Me.xrLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(222.9167!, 23.0!)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.Text = "A sample report"
            '
            'Report
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1, Me.ReportHeader})
            Me.Bookmark = "Table of Contents"
            Me.DataAdapter = Me.productsTableAdapter
            Me.DataMember = "Products"
            Me.DataSource = Me.nwindDataSet1
            Me.Margins = New System.Drawing.Printing.Margins(49, 51, 48, 48)
            Me.Version = "10.2"
            CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

	End Class
End Namespace