using System;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Themes;
using DevExpress.Xpf.Printing;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ThemeManager.ApplicationThemeName = "Azure";
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            Report report = new Report();
            XtraReportPreviewModel model = new XtraReportPreviewModel(report);
            DocumentPreviewWindow window = new DocumentPreviewWindow() { Model = model };
            report.CreateDocument(true);
            window.Show();
        }

    }
}
