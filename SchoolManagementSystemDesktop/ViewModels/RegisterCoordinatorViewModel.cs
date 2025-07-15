using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystemDesktop.ViewModels {
    public class RegisterCoordinatorViewModel : RegisterPersonViewModel {
        private DateTime _hireDate;

        public DateTime HireDate {
            get => _hireDate;
            set { _hireDate = value; OnPropertyChanged(nameof(HireDate)); }
        }
    }
}
