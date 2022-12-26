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

namespace dz_ColorViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CustomColorList colorList;
        private Color color;
        public MainWindow()
        {
            InitializeComponent();
            colorList = new CustomColorList();
            listBoxColor.ItemsSource = colorList;
        }

        private void slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void btnAddColor_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
