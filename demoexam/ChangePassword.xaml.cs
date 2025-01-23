using demoexam.Models;
using Microsoft.Identity.Client;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace demoexam
{
    /// <summary>
    /// Interaction logic for CangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        private readonly int _userId;
        public ChangePassword(int userId)
        {
            InitializeComponent();
            _userId = userId;

        }
        private void BtnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            string currentPassword = CurrentPawword.Password;
            string newPassword = NewPassword.Password;
            string confirwNewPassword = CheckPassword.Password;
            // Проверка на лустие поля
            if (string.IsNullOrWhiteSpace(currentPassword) ||
            string.IsNullOrWhiteSpace(newPassword) ||
            string.IsNullOrWhiteSpace(confirwNewPassword))
            {
                MessageBox.Show("Все поля обязательны для заполнения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (newPassword != confirwNewPassword)
            {
                MessageBox.Show("Новый пароль и подтверждение не совпадает", "Омибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            try
            {
                using (var context = new AverinaAContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Id == _userId);
                    if (user == null)
                    {
                        MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }


                    if (user.Password != currentPassword)
                    {
                        // Проверка текущего пароля
                        MessageBox.Show("Текущий пароль неверен", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    user.Password = newPassword;
                    user.IsFirstLogin = false;
                    context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении пароля: (ех. Message)", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
