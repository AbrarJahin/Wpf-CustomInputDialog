using System;
using System.Windows;

namespace Wpf_CustomInputDialog.Dialog.SignatureViewer
{
    /// <summary>
    /// Interaction logic for SignatureViewer.xaml
    /// </summary>
    /// https://www.wpf-tutorial.com/dialogs/creating-a-custom-input-dialog/
    public partial class SignatureViewer : Window
    {
        public SignatureViewer(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            lblQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }
    }
}
