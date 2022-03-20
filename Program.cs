using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            new Registration().Run();
        }

        static void Main3(string[] args)
        {
            String str;
            do
            {
                Console.WriteLine("Enter string: ");
                str = Console.ReadLine();
                //String message = IsPasswordValid(str);
                //Console.WriteLine(message == String.Empty ? "+" : message);
            } while (str != String.Empty);
        }

        static void Main2(string[] args)
        {
            Regex reg = new Regex(@"(^[A-ZА-Яa-zа-я]')?([A-ZА-Я][a-zа-я]+)(-[A-ZА-Я][a-zа-я]+)*( [A-Z][a-z]+)?$");
            
            String str;
            do
            {
                Console.WriteLine("Enter string: ");
                str = Console.ReadLine();
                Console.WriteLine(reg.IsMatch(str) ? "+" : "-");
            } while (str != String.Empty);
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Hello RegularExp");
            Regex digit = new Regex(@"\d");
            Regex nondigit = new Regex(@"\D");
            Regex space = new Regex(@"\s");
            Regex nonspace = new Regex(@"\S");
            Regex word = new Regex(@"\w");
            Regex nonword = new Regex(@"\W");
            Regex abc = new Regex(@"[abc]");
            Regex nonabc = new Regex(@"[^abc]");

            String str;
            do
            {
                Console.Write("Enter string: ");
                str = Console.ReadLine();
                #region digits
                if (digit.IsMatch(str))
                    Console.WriteLine("+ Contains digit(s)");
                else Console.WriteLine("- Contains no digit(s)");
                

                if (nondigit.IsMatch(str))
                    Console.WriteLine("+ Contains non-digit");
                else Console.WriteLine("- Contains no non-digit");
                #endregion

                #region space
                if (space.IsMatch(str))
                    Console.WriteLine("+ Contains space(s)");               
                else Console.WriteLine("- Contains no space(s)");
                
                if (nonspace.IsMatch(str))
                    Console.WriteLine("+ Contains non-space(s)");
                else Console.WriteLine("- Contains no non-space(s)");
                #endregion

                #region word
                if (word.IsMatch(str))
                    Console.WriteLine("+ Contains word-symbol(s)");
                else Console.WriteLine("- Contains no word-symbol(s)");

                if (nonword.IsMatch(str))
                    Console.WriteLine("+ Contains non-word-symbol(s)");
                else Console.WriteLine("- Contains no non-word-symbol(s)");
                #endregion
                #region groups
                if (abc.IsMatch(str))
                    Console.WriteLine("+ Contains abc group(s)");
                else Console.WriteLine("- Contains no abc group(s)");

                if (nonabc.IsMatch(str))
                    Console.WriteLine("+ Contains non-abc group(s)");
                else Console.WriteLine("- Contains no non-abc-group(s)");
                #endregion

            } while (str != String.Empty);

        }
    }
}