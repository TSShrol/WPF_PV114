using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _04_2_Binding_Template
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> Users { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Users = new ObservableCollection<User>
            {
                new User{ Id=1, ImagePath=@"https://randomuser.me/api/portraits/women/60.jpg", FirstName="Andriana", LastName="Sokil"},
                new User{ Id=2, ImagePath=@"https://randomuser.me/api/portraits/men/60.jpg", FirstName="Andre", LastName="Sokil"},
                new User{ Id=3, ImagePath=@"https://randomuser.me/api/portraits/women/60.jpg", FirstName="Andriana", LastName="Yastrub"},
                new User{ Id=4, ImagePath=@"https://randomuser.me/api/portraits/men/60.jpg", FirstName="Igor", LastName="Mislivec"}
            };
             
            listUsers.Items.Clear();
            //звязування із xaml
            listUsers.ItemsSource = Users;
        }

        private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e) { 
            //User user = (User)listUsers.SelectedItem;
          //  MessageBox.Show(user.LastName);
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User
            {
                Id = Users.Count + 1,
                ImagePath = @"https://randomuser.me/api/portraits/men/60.jpg",
                FirstName=inputFirstName.Text,
                LastName=inputLastName.Text
            };
            Users.Add(newUser);
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            //if (listUsers.SelectedItem == null) return;
            if (listUsers.SelectedItem != null) {
                Users.Remove(listUsers.SelectedItem as User);
            }


        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (listUsers.SelectedItem != null)
            {
                var currentUser = listUsers.SelectedItem as User;
                currentUser.LastName = "None";
                currentUser.FirstName = "None";
                //Title = (listUsers.SelectedItem as User).LastName;
                Title = Users[listUsers.SelectedIndex].LastName;

            }

                       
        }
    }
}
