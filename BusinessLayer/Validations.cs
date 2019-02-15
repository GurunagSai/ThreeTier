using System;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class Validations
    {
        /// <summary>
        /// Validation of EmailId
        /// </summary>
        /// <param name="email">EmaiID</param>
        /// <returns>Valid emailId or not</returns>
        public static bool ValidateEmail(string email)
        {
            if (email.Contains(".com") & email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Validation of Password
        /// </summary>
        /// <param name="password">Password</param>
        /// <returns>Valid Password or not</returns>
        public static bool ValidatePassword(string password)
        {
            const int minLength = 8;
            const int maxLength = 15;

            if (password == null) throw new ArgumentNullException();

            bool meetsLengthRequirements = password.Length >= minLength && password.Length <= maxLength;
            bool hasUpperCaseLetter = false;
            bool hasLowerCaseLetter = false;
            bool hasDecimalDigit = false;

            if (meetsLengthRequirements)
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) hasUpperCaseLetter = true;
                    else if (char.IsLower(c)) hasLowerCaseLetter = true;
                    else if (char.IsDigit(c)) hasDecimalDigit = true;
                }
            }
            bool isValid = meetsLengthRequirements && hasUpperCaseLetter && hasLowerCaseLetter && hasDecimalDigit;
            return isValid;

        }
        /// <summary>
        /// Validity of name
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>valid name or not</returns>
        public static bool ValidateName(string name)
        {
            Regex regex = new Regex("[a-zA-Z]{3}");
            return regex.IsMatch(name);
        }
        /// <summary>
        /// checks password and conform password are same or not
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="conformPassword">conform password</param>
        /// <returns></returns>
        public static bool VerifyPassword(string password, string conformPassword)
        {
            if (password == conformPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
