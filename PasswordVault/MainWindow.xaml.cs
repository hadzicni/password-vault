using PasswordVault.Data;
using PasswordVault.Models;
using System.Collections.Generic;
using System.Windows;

namespace PasswordVault
{
    public partial class MainWindow : Window
    {
        private readonly string masterPassword;
        private List<PasswordEntry> entries = new();

        public MainWindow(string password)
        {
            InitializeComponent();
            masterPassword = password;
            LoadVault();
        }

        private void LoadVault()
        {
            entries = VaultStorage.Load(masterPassword);
            RefreshList();
        }

        private void RefreshList()
        {
            PasswordList.ItemsSource = null;
            PasswordList.ItemsSource = entries;
        }

        private void AddEntry_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text))
            {
                MessageBox.Show("Titel darf nicht leer sein.", "Hinweis", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var entry = new PasswordEntry
            {
                Title = TitleBox.Text.Trim(),
                Username = UsernameBox.Text.Trim(),
                Password = PasswordBox.Text.Trim(),
                Url = UrlBox.Text.Trim(),
                Note = NoteBox.Text.Trim()
            };

            entries.Add(entry);
            ClearInput();
            RefreshList();
        }
        private void PasswordList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (PasswordList.SelectedItem is PasswordEntry selected)
            {
                TitleBox.Text = selected.Title;
                UsernameBox.Text = selected.Username;
                PasswordBox.Text = selected.Password;
                UrlBox.Text = selected.Url;
                NoteBox.Text = selected.Note;
            }
        }

        private void DeleteEntry_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordList.SelectedItem is PasswordEntry selected)
            {
                entries.Remove(selected);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Bitte einen Eintrag auswählen.", "Hinweis", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            VaultStorage.Save(entries, masterPassword);
            MessageBox.Show("Daten wurden gespeichert.", "Erfolg", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ClearInput()
        {
            TitleBox.Text = "";
            UsernameBox.Text = "";
            PasswordBox.Text = "";
            UrlBox.Text = "";
            NoteBox.Text = "";
        }

        private void OpenInfo_Click(object sender, RoutedEventArgs e)
        {
            var info = new InfoWindow
            {
                Owner = this
            };
            info.ShowDialog();
        }

    }
}
