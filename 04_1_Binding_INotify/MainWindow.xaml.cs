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

namespace _04_1_Binding_INotify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student CurrentStudent { get; set; }
        ObservableCollection<Student> group;
        
        public MainWindow()
        {
            InitializeComponent();
            CurrentStudent = new Student()
            {
                Name = "Andriy",
                Age = 19
            };
            group = new ObservableCollection<Student> {
                CurrentStudent,
                new Student(){
                    Name="Olga",
                    Age=18
                }
            };
            groupStudents.Items.Clear();

            groupStudents.ItemsSource = group;
            //groupStudents.DisplayMemberPath = nameof(Student.Name);
            groupStudents.DisplayMemberPath = nameof(Student.FullInfo);
            // this.DataContext = CurrentStudent;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            group.Add(new Student() { Name=StudentName.Text, Age=Convert.ToInt32( StudentAge.Text) });
            MessageBox.Show($"{group.Last<Student>().Name} {group.Last<Student>().Age} ");
        }
    }
}
