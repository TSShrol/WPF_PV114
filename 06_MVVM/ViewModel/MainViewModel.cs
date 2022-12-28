using _06_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _06_MVVM.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly ICollection<Contact> contacts=new ObservableCollection<Contact>();
        private Contact selectedContact;
        //Приватні поля команд
        private RelayCommand copyCommand;

        public MainViewModel() {
            contacts.Add(new Contact { Name = "Bogdan", Surname = "Slonetc", Age = 24, Phone = "+3805647474", IsMale = true });
            contacts.Add(new Contact { Name = "Maksim", Surname = "Prymak", Age = 18, Phone = "+38056434374", IsMale = true });

            copyCommand = new RelayCommand((obj)=>CopyContact(), IsSeletedContact);

        }

        

        //Додамо властивості привєязки команд
        public ICommand CopyCmd => copyCommand;

        //Додаємо властивості для привязки на вікні
        public IEnumerable<Contact> Contacts {
            get => contacts;
        }
        
        
        private bool IsSeletedContact(object obj)
        {
            return SelectedContact!= null;
        }
        private void CopyContact()
        {
            if (SelectedContact != null)
            {
                Contact newContact = new Contact
                {
                    Name = SelectedContact.Name,
                    Surname = SelectedContact.Surname,
                    Age = SelectedContact.Age,
                    Phone = SelectedContact.Phone,
                    IsMale = SelectedContact.IsMale
                };
                contacts.Add(newContact);
            }
        }

        public Contact SelectedContact{ 
            get=>selectedContact;
            set {
                selectedContact = value;
                OnPropertyChanged();
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

