using System;
using System.Text.RegularExpressions;

namespace LibraryForUnitTestingBasics
{
    public class UserManagerClass
    {
        public bool Add(string userId, string phone, string email)
        {
            if (userId.Length < 4)
            {
                throw new Exception("UserId должен быть больше 4 символов");
            }
            
            if (Regex.Match(phone, "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$").Success)
            {
                throw new Exception("Телефон должен содержать только цифры");
            }

            if (!email.Contains("@"))
            {
                throw new Exception("Ошибка в email адресе");
            }

            return true;
        }
    }
}
