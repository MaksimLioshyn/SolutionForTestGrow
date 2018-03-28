using System;
using System.Text.RegularExpressions;

namespace LibraryForUnitTestingBasics
{
    public class PasswordStrengthChekerClass
    {
        /// <summary>
        /// A value that defines the complexity of the user's password. 
        /// 1 point for length
        /// 1 point for the presence of a lowercase character
        /// 1 point for the presence of a symbol in uppercase
        /// 1 point for the number
        /// 1 point for the presence of a special symbol
        /// Max point 5.
        /// </summary>
        /// <param name="password">Password.</param>
        /// <returns>Password rating.</returns>
        public static int GetPasswordStrength(string password)
        {
            int result = 0;
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }

            if (Math.Max(password.Length, 7) > 7)
            {
                result++;
            }

            if (Regex.Match(password, "[a-z]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[A-Z]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[0-9]").Success)
            {
                result++;
            }

            if (Regex.Match(password, "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
            {
                result++;
            }

            return result;
        }
    }
}
