using System.Windows;

namespace LoadFromFile {
   
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            Viewer.OpenDocument("..\\..\\Demo.pdf");
        }
    }
}
