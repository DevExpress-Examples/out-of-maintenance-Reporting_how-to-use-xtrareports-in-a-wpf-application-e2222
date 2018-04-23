Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports DevExpress.Xpf.Themes
Imports DevExpress.Xpf.Printing
' ...

Namespace MinimalisticReportPreviewDemo
    Partial Public Class MainWindow
        Inherits Window
        Public Sub New()
            ThemeManager.ApplicationThemeName = "Azure"
            InitializeComponent()
        End Sub

        Private Sub ShowPreview(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim report As New XtraReport1()
            Dim model As New XtraReportPreviewModel(report)
            Dim window As New DocumentPreviewWindow() With {.Model = model}
            report.CreateDocument(False)
            window.Show()
        End Sub

    End Class
End Namespace
