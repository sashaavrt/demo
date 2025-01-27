using demoexam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace demoexam
{
    /// <summary>
    /// Interaction logic for AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        public AddUserWindow()
        {
            InitializeComponent();
        }

        public User newUser { get; internal set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newUsername = Username.Text;
            string newPassword = Password.Text;
            string newEmail = Email.Text;
            string newRole = Role.Text;
            // Проверка на лустие поля
            // Проверка на лустие поля
            if (string.IsNullOrWhiteSpace(newUsername) ||
            string.IsNullOrWhiteSpace(newPassword) ||
            string.IsNullOrWhiteSpace(newEmail) || string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                var newUser = new User { Name = newUsername, Password = newPassword, Email = newEmail, Role = newRole, IsFirstLogin = true, FalledLoginAttempts = 0, IsLocked = false, LastLoginDate=DateTime.Now};
                using (var context = new AverinaAContext())
                {
                    context.UpdateRange(newUser);
                    context.SaveChangesAsync();
                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }
    }
}
