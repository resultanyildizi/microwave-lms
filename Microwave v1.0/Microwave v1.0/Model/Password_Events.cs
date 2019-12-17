using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Microwave_v1._0.Model
{
    public class Password_Events
    {
       public static int GetPasswordStrength(string password)
        {
            int score = 0;
            if (String.IsNullOrEmpty(password.Trim())) return score = 0;
            if (MinimumLenght(password, 5)) return score = 0;
            if (HasLowerCaseLetter(password)) score++;
            if (HasUpperCaseLetter(password)) score++;
            if (HasDigit(password)) score++;
            if (HasSpecialChar(password)) score++;

            return score;
        }

        private static bool HasLowerCaseLetter(string password)
        {
            return password.Any(c => char.IsLower(c));
        }
        private static bool HasUpperCaseLetter(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }
        private static bool HasDigit(string password)
        {
            return password.Any(c => char.IsDigit(c));
        }
        private static bool MinimumLenght(string password, int min)
        {
            return password.Length <= min;
        }
        private static bool HasSpecialChar(string password)
        {
            return password.IndexOfAny("!@#$%^&*?_~-£().,".ToCharArray()) != -1;
        }
    }
}



