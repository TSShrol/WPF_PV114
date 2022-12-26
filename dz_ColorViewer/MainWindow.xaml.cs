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
            sliderAlpha.Value = 255;
            listBoxColor.ItemsSource = colorList;
        }

        private void slider_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var alpha =(byte)sliderAlpha.Value;
            var red = Convert.ToByte(sliderRed.Value);
            var green = (byte)sliderGreen.Value;
            var blue = (byte)sliderBlue.Value;
            color = Color.FromArgb(alpha, red, green, blue);
            ellipseColor.Fill =new SolidColorBrush(color);

        }

        private void btnAddColor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
