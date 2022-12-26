using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace dz_ColorViewer
{
   public class CustomColor
    {
        public string Name { get; set; }
        public SolidColorBrush ColorElem { get; set; }
        public CustomColor() { }
        public CustomColor(string name, SolidColorBrush colorElem) {
            Name = name;
            ColorElem = colorElem;
        }
    }

}
