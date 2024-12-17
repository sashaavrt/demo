﻿using System.Diagnostics.Eventing.Reader;
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
            string password = Password.Text;

            if (login.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                MessageBox.Show("Значение обоих полей должны быть заполнены!");
                return;
            }
            login = login.Trim();
            password = password.Trim();

            using (var context = new AverinaAContext())
            {
                var user = await context.Users
                    .Where(u => u.Name == login && u.Password == password)
                    .FirstOrDefaultAsync();

                if (user != null)
                {
                    MessageBox.Show("Вы успешно авторизовались!");

                }
                else
                {
                    MessageBox.Show("Вы ввели неправильные логин и пароль. Проверьте введенные данные и попробуйте еще раз.");
                }
            }
        }
    }
}
