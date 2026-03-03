using System.Text.RegularExpressions;

namespace AddressBookSystem.Utility
{
    internal static class ValidationHelper
    {
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z][a-zA-Z]{2,}$");
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^[6-9]\d{9}$");
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        public static bool IsValidZip(string zip)
        {
            return Regex.IsMatch(zip, @"^\d{6}$");
        }
    }
}

