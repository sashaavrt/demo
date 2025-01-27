using demoexam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        private async void LoadUsers()
        {
            using (var context = new AverinaAContext())
            {
                var users = await context.Users.ToListAsync();
                Users.ItemsSource = users;
            }
        }
        private async void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var newUserWindow = new AddUserWindow();
            if (newUserWindow.ShowDialog() == true)
            {
                var newUser = newUserWindow.newUser;
                using (var context = new AverinaAContext())
                {
                    if (await context.Users.AnyAsync(u => u.Name == newUser.Name))
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        context.Users.Add(newUser);
                        await context.SaveChangesAsync();
                        LoadUsers();
                        MessageBox.Show("Пользователь успешно добавлен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
        }

        // Разблокировка пользователя
        private async void UnlockUser_Click(object sender, RoutedEventArgs e)
        {
            if (Users.SelectedItem is User selectedUser)
            {
                using (var context = new AverinaAContext())
                {
                    var user = await context.Users.FindAsync(selectedUser.Id);
                    if (user != null)
                    {
                        user.IsLocked = false;
                        user.LastLoginDate = null;
                        await context.SaveChangesAsync();
                        LoadUsers();
                        MessageBox.Show("Пользователь разблокирован.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя для разблокировки.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Сохранение изменений данных пользователей
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Users.ItemsSource is List<User> users)
            {
                using (var context = new AverinaAContext())
                {
                    context.UpdateRange(users);
                    await context.SaveChangesAsync();
                    LoadUsers();
                    MessageBox.Show("Изменения сохранены.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
