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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _04_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User AdminUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            AdminUser = new User()
            {
                Email = "example@example.com",
                AuthData = new AuthData()
                {
                    Login = "admin007",
                    Password = "qwerty007"
                },
                Age=19
            };

            this.DataContext = AdminUser;

        }

        public struct AuthData{
            public string Login { get; set; }
            public string Password { get; set; }
        }

        public class User { 
            public string Email { get; set; }
            public AuthData AuthData { get; set; }
            public int Age { get; set; }
             public override string ToString()
            {
                return $"User: {Email}, {AuthData.Login}\n"
                         +$"Password: {AuthData.Password.First()}{new string('#', AuthData.Password.Length-2)}{AuthData.Password.Last()}  " ;
            }
        }
    }
}
