using demoexam.Models;
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
        public ChangePassword()
        {
            InitializeComponent();
            _userId = userId;
            private void BtnChangePassword_Click(object sender, RoutedEventArgs e)
            string currentPassword txtCurrentPassword.Password;
            string newPassword txthemPassword Password;
        string confirwNewPassword txtConfirm Password Password;
// Проверка на лустие поля
            if (string.IsNullOrWhiteSpace(currentPassword) ||
            string.IsNullOrihiteSpace(nesPassword) ||
            string. Iskill0rihiteSpace(confirmNewPassword)) {
                Messagellox.Show("Все поля обязательны для заполнения", паре "Ошибка", MessageBoxButton.OK, MessageBox Image Error);
                return;
            }

            if (newPassword confirsNewPassword) {
                Messagellox.Show("Новый пароль и подтверждение не совпадает", заран "Омибка", MessagelloxButton.OK, MessageBox Image Error);
        }
        try { }
var Umet user context Users FirstOrDefault(u.Id userId);
if (user nall)
NessageBox.Show(анибетист "Пользователь не найден.", за "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
return;

user.Password newPassword;

 if (user.Password currentPassword)
// Проверка текущего пароля
MessageBox.Show("Текущий пароль неверен", зар "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
return;
user.IsFirstlogin = false;
context SaveChanges();
        MessageBox.Show("Пароль успешно изменен", оці "Успех", RessageBoxButton.OK, MessageBoxImage.Information);
this.Close();
catch (Exception ex)
Messagebox.Show("Ошибка при изменении пароля: (ех. Message)", "Ошибка", MessageBoxButton.OK, MessageBoxImage Error);
    }
    }
}
