using System;
using System.Windows;

namespace Wpf_CustomInputDialog.Dialog.SignatureViewer
{
    /// <summary>
    /// Interaction logic for SignatureViewer.xaml
    /// </summary>
    /// https://www.wpf-tutorial.com/dialogs/creating-a-custom-input-dialog/
    public partial class SignatureViewer : Window, IDisposable
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
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        public void Dispose()
        {
            //https://stackoverflow.com/a/568436/2193439
            //this?.Dispose();
            this.Close();
        }

        public string Answer
        {
            get { return txtAnswer.Text; }
        }
    }
}
