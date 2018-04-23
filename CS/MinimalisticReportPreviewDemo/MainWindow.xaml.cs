using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
// ...

namespace MinimalisticReportPreviewDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            ApplicationThemeHelper.ApplicationThemeName = "Office2007Silver";
            InitializeComponent();
        }

        private void ShowPreview(object sender, RoutedEventArgs e) {
            Report report = new Report();
            DocumentPreviewWindow window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = report;
            report.CreateDocument(true);
            window.ShowDialog();
        }

    }
}
