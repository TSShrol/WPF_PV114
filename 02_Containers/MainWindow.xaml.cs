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

namespace _02_Containers
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

        private void Button_Click_Stack(object sender, RoutedEventArgs e)
        {
            StackPanelExample window = new StackPanelExample();
            window.Show();
        }

        private void Button_Click_Wrap(object sender, RoutedEventArgs e) => new WrapPanelExample().Show();

        private void Button_Click_Canvas(object sender, RoutedEventArgs e) => new CanvasExample().Show();
        private void Button_Click_Uniform(object sender, RoutedEventArgs e) => new UniformGridExample().Show();
        private void Button_Click_Dock(object sender, RoutedEventArgs e) => new DockPanelExample().Show();


        private void Button_Click_Page1(object sender, RoutedEventArgs e)
        {
            Page1 window = new Page1();
            window.Show();
        }
    }
}
