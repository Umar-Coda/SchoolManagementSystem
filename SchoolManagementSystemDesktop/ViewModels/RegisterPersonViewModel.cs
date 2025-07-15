using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemDesktop.ViewModels {
    public class RegisterPersonViewModel : INotifyPropertyChanged {
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private string _gender = string.Empty;
        private DateTime _birthDate = DateTime.Now;
        private string _phoneNumber = string.Empty;
        private string _email = string.Empty;
        private string _address = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;

        public string Firstname {
            get => _firstname;
            set { _firstname = value; OnPropertyChanged(nameof(Firstname)); }
        }

        public string Lastname {
            get => _lastname;
            set { _lastname = value; OnPropertyChanged(nameof(Lastname)); }
        }

        public string Gender {
            get => _gender;
            set { _gender = value; OnPropertyChanged(nameof(Gender)); }
        }

        public DateTime BirthDate {
            get => _birthDate;
            set { _birthDate = value; OnPropertyChanged(nameof(BirthDate)); }
        }

        public string PhoneNumber {
            get => _phoneNumber;
            set { _phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber)); }
        }

        public string Email {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string Address {
            get => _address;
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        public string Username {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Password {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
