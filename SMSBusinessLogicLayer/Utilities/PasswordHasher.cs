using System.Text;
using System.Security.Cryptography;

namespace SMSBusinessLogicLayer.Utilities {
    /// <summary>
    /// Handle the hashing password
    /// </summary>
    public class PasswordHasher {
        public static string HashPassword(string password) {
            using (SHA256 sha256 = SHA256.Create()) {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        //public static bool VerifyPassword(string inputPassword, string storedHash) {
        //    string inputHash = HashPassword(inputPassword);
        //    return inputHash == storedHash;
        //}
    }
}
