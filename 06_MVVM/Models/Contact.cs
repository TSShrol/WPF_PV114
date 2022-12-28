using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_MVVM.Models
{
    public class Contact:INotifyPropertyChanged
    {
        private string name;
        private string surname;
        private int age;
        private string phone;
        private bool isMale;

        public string Name
        {
            get { return name; }
            set {
                if (name != value) {
                    name = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Name)));
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(FullName)));
                }
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Surname)));
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(FullName)));
                }
            }
        }

        public String FullName => $"{Name} {Surname}";
        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Age)));
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(Phone)));
                }
            }
        }
        public bool IsMale
        {
            get { return isMale; }
            set
            {
                if (isMale != value)
                {
                    isMale = value;
                    OnPropertyChanged(new PropertyChangedEventArgs(nameof(IsMale)));
                }
            }
        }
        public string GenderName => IsMale ? "Male" : "Female";
        //Оголошення події оновлення властивості
        public event PropertyChangedEventHandler PropertyChanged;
        //Створення методу OnPropertyChanged для виклику події
        //в якості параметра буде використано імя властивості , що його викликала
        //protected void OnPropertyChanged([CallerMemberName]string name="") {
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        private void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
