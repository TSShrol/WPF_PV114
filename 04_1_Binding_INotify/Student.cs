using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace _04_1_Binding_INotify
{
    public class Student : INotifyPropertyChanged
    {
        private string name;
        private int age;

        public string Name {
            get { return name; }
            set {
                name = value;

            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set {
                if (value > 0) age = value;
                else age = 1;
            }
        }
        public string FullInfo {  
            get { return $"{Name} has {Age} old"; }

          }
        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string propertyName=""){
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
