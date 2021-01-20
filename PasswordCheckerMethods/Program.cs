using System;
using System.Linq;

namespace PasswordCheckerMethods
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please input a password meeting the following conditions:");
            Console.WriteLine("1) The password must be more than 8 characters");
            string password = Console.ReadLine();

            bool longEnough = IsLongEnough(password);
            Console.WriteLine("Is the password greater than 8 characters: " + longEnough);

            bool IsntNull = IsNotNull(password);
            Console.WriteLine("The password is neither null nor empty: " + IsntNull);

            bool ContainsUppercase = IsUppercase(password);
            Console.WriteLine("The password has an uppercase character: " + ContainsUppercase);

            bool ContainsLowercase = IsLowercase(password);
            Console.WriteLine("The password contains a lowercase letter" + ContainsLowercase);

        }
        public static bool IsLongEnough(string input)
        {
            int len = input.Length;
            if (len > 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNotNull(string input)
        {
            if (input != "" && input != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool IsUppercase(string input)
        {
            if(input.Any(char.IsUpper))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsLowercase( string input)
        {
            if(input.Any(char.IsLower))
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