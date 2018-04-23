Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
' ...

Namespace MinimalisticReportPreviewDemo
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver"
            InitializeComponent()
        End Sub

        Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report As New Report()
            Dim window As New DocumentPreviewWindow()
            window.PreviewControl.DocumentSource = report
            report.CreateDocument(True)
            window.ShowDialog()
        End Sub

    End Class
End Namespace
