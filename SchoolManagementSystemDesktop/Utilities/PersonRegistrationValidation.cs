using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystemDesktop.Utilities {
    public class PersonRegistrationValidation {
        private StringBuilder _message;
        private readonly ICheckDuplicateService _duplicateService;

        public PersonRegistrationValidation(ICheckDuplicateService duplicateService) {
            _message = new StringBuilder();
            _duplicateService = duplicateService;
        }

        public void UpdateMessageBuilder(string message) => _message.AppendLine(message);

        public StringBuilder GetMessageBuilder() => _message;

        public void ClearMessageBuilder() => _message.Clear();

        public bool ValidateFirstname(string firstname) {
            if (string.IsNullOrWhiteSpace(firstname)) {
                _message.AppendLine("Firstname is required.");
                return false;
            }

            return true;
        }

        public bool ValidateLastname(string lastname) {
            if (string.IsNullOrWhiteSpace(lastname)) {
                _message.AppendLine("Lastname is required.");
                return false;
            }

            return true;
        }

        public bool ValidatePhoneNumber(string phoneNumber) {
            if (string.IsNullOrWhiteSpace(phoneNumber)) {
                _message.AppendLine("Phone number is required.");
                return false;
            } else if (!phoneNumber.StartsWith("5")) {
                _message.AppendLine("Phone number must start with the digit 5.");
                return false;
            } else if (!phoneNumber.All(char.IsDigit)) {
                _message.AppendLine("Phone number must contain only digits.");
                return false;
            } else if (phoneNumber.Length != 8) {
                _message.AppendLine("Phone number must be exactly 8 characters long.");
                return false;
            }

            return true;
        }

        public bool ValidateEmail(string email) {
            if (string.IsNullOrWhiteSpace(email)) {
                _message.AppendLine("Email is required.");
                return false;
            } else {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(email, pattern)) {
                    _message.AppendLine("Invalid email format.");
                    return false;
                }
            }

            return true;
        }

        public bool ValidateAddress(string address) {
            if (string.IsNullOrWhiteSpace(address)) {
                _message.AppendLine("Address is required.");
                return false;
            }

            return true;
        }

        public bool ValidateUsername(string username) {
            if (string.IsNullOrWhiteSpace(username)) {
                _message.AppendLine("Username is required");
                return false;
            }

            if (!_duplicateService.CheckDuplicateUsername(username)) {
                _message.AppendLine("Username already exists");
                return false;
            }
            
            return true;
        }

        public bool ValidatePassword(string password) {
            if (string.IsNullOrWhiteSpace(password)) {
                _message.AppendLine("Password cannot be empty");
                return false;
            }

            if (password.Length < 6 || password.Length > 12) {
                _message.AppendLine("Password must be between 6 and 12 characters.");
                return false;
            }

            if (!Regex.IsMatch(password, @"[A-Z]")) {
                _message.AppendLine("Password must contain at least one uppercase letter.");
                return false;
            }

            if (!Regex.IsMatch(password, @"[a-z]")) {
                _message.AppendLine("Password must contain at least one lowercase letter.");
                return false;
            }

            if (!Regex.IsMatch(password, @"\d")) {
                _message.AppendLine("Password must contain at least one digit.");
                return false;
            }
            
            return true;
        }
    }
}
