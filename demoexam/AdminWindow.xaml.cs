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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (var context = new AverinaAContext())
            {
                var query =
                from user in context.Users
                orderby user.Id
                select new { user.Name, user.Role, user.Email, user.IsLocked, user.IsFirstLogin, user.Password, user.FalledLoginAttempts, user.LastLoginDate};
                Users.ItemsSource = query.ToList();
            }
        }

       
    }
}
