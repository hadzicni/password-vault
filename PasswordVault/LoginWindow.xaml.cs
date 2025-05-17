using System.Windows;
using PasswordVault;

namespace PasswordVault
{
    public partial class LoginWindow : Window
    {
        private const string HardcodedHash = "123456"; // Wird ersetzt (z. B. mit Hash in Datei)

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string password = MasterPasswordBox.Password;
            if (password == "vault123") // später mit Hash vergleichen
            {
                var vault = new MainWindow(password);
                vault.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Falsches Master-Passwort.", "Zugriff verweigert", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
