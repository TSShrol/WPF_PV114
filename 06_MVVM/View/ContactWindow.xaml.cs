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
using _06_MVVM.ViewModel;

namespace _06_MVVM.View
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        private MainViewModel viewModel = new MainViewModel();
        public ContactWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
