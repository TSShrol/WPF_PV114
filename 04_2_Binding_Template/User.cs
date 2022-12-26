using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_2_Binding_Template
{
    public class User:INotifyPropertyChanged
    {
        public int id;
        public string firstName;
        public string lastName;
        public string imagePath;
        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string FirstName {
            get => firstName;
            set
            {
                firstName = value;
                onPropertyChanged();
            }
        }
        public string LastName {
            get => lastName;
            set
            {
                lastName = value;
                onPropertyChanged();
            }
        }
        public string ImagePath {
            get => imagePath;
            set
            {
                imagePath = value;
                onPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
