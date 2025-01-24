using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using demoexam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
namespace demoexam
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

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = Username.Text;
            string password = Password.Password;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Значение обоих полей должны быть заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            login = login.Trim();
            password = password.Trim();

            using (var context = new AverinaAContext())
            {
                var user = await context.Users
                    .Where(u => u.Name == login && u.Password == password)
                    .FirstOrDefaultAsync();

                if (user == null)
                {
                    MessageBox.Show("Вы ввели неправильные логин и пароль. Проверьте введенные данные и попробуйте еще раз.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (user.IsLocked)
                    {
                        MessageBox.Show("Вы заблокированы. Обратитесь к администратору.", "Доступ запрещен", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    if (user.LastLoginDate.HasValue && (DateTime.Now - user.LastLoginDate.Value).TotalDays > 30 && user.Role != "admin")
                    {
                        user.IsLocked = true;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Ваша учетная запись заблокирована из-за длительного отсутствия входа. Обратитесь к администратору.", "Доступ запрещен", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    if (user.Password == password)
                    {
                        user.LastLoginDate = DateTime.Now;
                        user.FalledLoginAttempts = 0;
                        await context.SaveChangesAsync();
                        MessageBox.Show("Вы успешно авторизовались. Добро пожаловать!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                        if (user.IsFirstLogin)
                        {
                            ChangePassword changePassword = new ChangePassword(user.Id);
                            changePassword.Owner = this;
                            changePassword.ShowDialog();
                        }
                        else
                        {
                            if (user.Role == "admin")
                            {
                                AdminWindow adminWindow = new AdminWindow();
                                adminWindow.Show();
                            }
                            else
                            {
                                MainWindow userWindow = new MainWindow();
                                userWindow.Show();
                            }
                            this.Close();
                        }
                    }

                    else
                    {
                        user.FalledLoginAttempts++;
                        if (user.FalledLoginAttempts >= 3)
                        {
                            user.IsLocked = true;
                            MessageBox.Show("Вы заблокированы из-за 3 неудачных попыток входа. Обратитесь к администратору.", "Доступ запрещен", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        else
                        {
                            int attemptsLeft = 3 - user.FalledLoginAttempts;
                            MessageBox.Show($"Неправильный логин или пароль. Осталось попыток: {attemptsLeft}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                        await context.SaveChangesAsync();
                    }

                }
            }
        }
    }
}
