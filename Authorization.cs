using System.Text.RegularExpressions;

namespace RegularExpressions
{
    internal class Registration
    {
        private String login { get; set; }
        private String password { get; set; }
        private String email { get; set; }
        private String realname { get; set; }
        private String phoneNumber { get; set; }

        static public String IsLoginValid(String login)
        {
            if (!new Regex(@"[A-Z]|[a-z]").IsMatch(login)) return "Логин не содержит латинских символов.";
            else if (!new Regex(@"\S").IsMatch(login)) return "Логин не должен содержать пробелы.";
            // else if (!new Regex(@"\d").IsMatch(login)) return "Логин не содержит цифры.";
            return String.Empty;
        }
        static public String IsPasswordValid(String login)
        {
            // returns empty string if OK / else message
            if (!new Regex(@"\d").IsMatch(login)) // 
                return "В пароле не найдено цифр!";
            else if (!new Regex(@"[A-Z]").IsMatch(login))
                return "Пароль не содержит больших букв!";
            else if (!new Regex(@"[a-z]").IsMatch(login))
                return "Не содержит маленьких букв!";
            else if (login.Length < 6)
                return "Пароль должен содержать больше 6 символов!";
            else if (!new Regex(@"[\W_]").IsMatch(login))
                return "Пароль не содержит спец. символов!";
            return String.Empty;

        }
        static public Boolean IsEmailValid(String email)
        {
            return new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$").IsMatch(email);
        }
        static public Boolean IsRealnameValid(String realname)
        {
            Regex realnamePattern = new Regex(@"(^[A-ZА-Яa-zа-я]')?([A-ZА-Я][a-zа-я]+)(-[A-ZА-Я][a-zа-я]+)*( [A-Z][a-z]+)?( [A-ZА-Я][a-zа-я]+(-[A-ZА-Я][a-zа-я]+)?)?$");
            return realnamePattern.IsMatch(realname);
        }
        static public Boolean IsPhoneNumberValid(String phoneNumber)
        {
            Regex phoneValidation = new Regex(@"^(\+38)?(\(0[1-9]{1}\d{1}\)|0[1-9]{1}\d{1})\d([- ]?\d){6}$");
            if (phoneValidation.IsMatch(phoneNumber)) return true;
            else return false;
        }


        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Registration!");
            while (true)
            {
                Console.Write("1. Login: ");
                login = Console.ReadLine();
                String message = IsLoginValid(login);
                if(message == String.Empty)
                {
                    Console.WriteLine("Логин принят.");
                    break;
                }
                else Console.WriteLine(message);
            } 
            while(true)
            {
                Console.Write("2. Password: ");
                password = Console.ReadLine();
                String message = IsPasswordValid(password);
                if(message == String.Empty)
                {
                    Console.WriteLine("Пароль принят");
                    break;
                }
                else Console.WriteLine(message);   
            } 
            while (true)
            {
                Console.Write("3. Email (example@mail.org): ");
                String email = Console.ReadLine();
                if(IsEmailValid(email))
                {
                    Console.WriteLine("Почта принята.");
                    break;
                }
                else Console.WriteLine("Почта имеет недопустимый формат/такой почты не существует!");
                
            }
            while(true)
            {
                Console.WriteLine("4. Real name: (Name Surname / Name)");
                String realname = Console.ReadLine();
                if(IsRealnameValid(realname))
                {
                    Console.WriteLine("Имя принято.");
                    break;
                }
                else Console.WriteLine("Имя имеет недопустимый формат"); 
            }

        }


    }
}