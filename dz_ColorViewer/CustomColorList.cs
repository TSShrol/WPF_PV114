using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace dz_ColorViewer
{
    public class CustomColorList: ObservableCollection<CustomColor>
    {
        public CustomColorList() {
            this.Add(new CustomColor("#1686B6", new SolidColorBrush(Color.FromArgb(22, 134, 182, 255))));
            this.Add(new CustomColor("#9A503A", new SolidColorBrush(Color.FromArgb(154, 80, 58, 255))));
        }
    }
}
