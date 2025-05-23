using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public static class ContactValidator
    {
        // Проверка на обязательное заполнение полей "Имя", "Фамилия" и "Компания"
        public static bool ValidateRequiredFields(Contact contact, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(contact.FirstName) ||
                string.IsNullOrWhiteSpace(contact.LastName) ||
                string.IsNullOrWhiteSpace(contact.Company))
            {
                errorMessage = "Поля 'Имя', 'Фамилия' и 'Компания' обязательны к заполнению.";
                return false;
            }

            errorMessage = null;
            return true;
        }
        public static bool ValidateEmail(string email, out string errorMessage)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(email)) return true;

            try
            {
                var addr = new MailAddress(email);
                if (addr.Address == email)
                    return true;
            }
            catch
            {
                // Игнорируем исключение, просто возвращаем false
            }

            errorMessage = "Email указан в неверном формате.";
            return false;
        }
    }
}
