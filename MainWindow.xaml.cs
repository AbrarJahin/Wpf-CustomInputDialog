using System.Windows;
using Wpf_CustomInputDialog.Dialog.SignatureViewer;

namespace Wpf_CustomInputDialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            SignatureViewer inputDialog = new SignatureViewer("Please enter your name:", "John Doe");
            if (inputDialog.ShowDialog() == true)
                lblName.Text = inputDialog.Answer;
            else
                lblName.Text = "No Data Inserted";
            inputDialog.Close();
        }
    }
}
