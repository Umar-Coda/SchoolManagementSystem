using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SchoolManagementSystemDesktop.Utilities;
using SchoolManagementSystemDesktop.ViewModels;

namespace SchoolManagementSystemDesktop.Views.CreateForms {
    public partial class CreateCoordinator : Form {
        private readonly CoordinatorController _coordinatorController;
        private PersonRegistrationValidation _validator;

        private string firstname;
        private string lastname;
        private DateTime birthDate;
        private string phoneNumber;
        private string email;
        private string address;
        private string username;
        private string password;

        public CreateCoordinator(PersonRegistrationValidation validator,
            CoordinatorController coordinatorController) {
            InitializeComponent();
            
            _validator = validator;
            _coordinatorController = coordinatorController;
        }

        private void lblFirstname_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        // Register Button Event
        private void button1_Click(object sender, EventArgs e) {
            if (!InputValidation()) {
                MessageBox.Show(_validator.GetMessageBuilder().ToString());
                _validator.ClearMessageBuilder();
            } else {
                //DataBinding();
                string gender = GetGender();
                var result = _coordinatorController.CreateCoordinator(firstname, lastname, gender, birthDate,
                    phoneNumber, email, address, DateTime.Now, username, password, DateTime.Now);

                MessageBox.Show(result.Message);
            }
        }

        //private void DataBinding() {
        //    txtFirstname.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Firstname), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtLastname.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Lastname), false, DataSourceUpdateMode.OnPropertyChanged);

        //    radioMaleBtn.DataBindings.Add(new Binding("Checked", _registerCoordViewModel, 
        //        "Gender", true, DataSourceUpdateMode.OnPropertyChanged));

        //    radioMaleBtn.DataBindings[0].Format += (s, e) => e.Value = (string)e.Value! == "Male";
        //    radioMaleBtn.DataBindings[0].Parse += (s, e) => { if ((bool)e.Value!) e.Value = "Male"; };

        //    radioFemaleBtn.DataBindings.Add(new Binding("Checked", _registerCoordViewModel,
        //        "Gender", true, DataSourceUpdateMode.OnPropertyChanged));

        //    radioFemaleBtn.DataBindings[0].Format += (s, e) => e.Value = (string)e.Value! == "Female";
        //    radioFemaleBtn.DataBindings[0].Parse += (s, e) => { if ((bool)e.Value!) e.Value = "Female"; };

        //    txtBirthDate.DataBindings.Add("Value", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.BirthDate), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtPhoneNumber.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.PhoneNumber), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtEmail.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Email), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtAddress.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Address), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtUsername.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Username), false, DataSourceUpdateMode.OnPropertyChanged);

        //    txtPassword.DataBindings.Add("Text", _registerCoordViewModel,
        //        nameof(_registerCoordViewModel.Password), false, DataSourceUpdateMode.OnPropertyChanged);   
        //}

        private bool InputValidation() {
            firstname = txtFirstname.Text;
            lastname = txtLastname.Text;
            birthDate = txtBirthDate.Value;
            phoneNumber = txtPhoneNumber.Text;
            email = txtEmail.Text;
            address = txtAddress.Text;
            username = txtUsername.Text;
            password = txtPassword.Text;

            return _validator.ValidateFirstname(firstname) && _validator.ValidateLastname(lastname)
                && _validator.ValidatePhoneNumber(phoneNumber) && _validator.ValidateEmail(email)
                && _validator.ValidateAddress(address) && ValidateGender()
                && _validator.ValidateUsername(username) && _validator.ValidatePassword(password);
        }

        private string GetGender() {
            if (radioMaleBtn.Checked)
                return "Male";

            return "Female";
        }

        private bool ValidateGender() {
            bool isValid = true;

            if (!radioMaleBtn.Checked && !radioFemaleBtn.Checked) {
                _validator.UpdateMessageBuilder("Gender is required");
                isValid = false;
            }

            return isValid;
        } 
    }
}
