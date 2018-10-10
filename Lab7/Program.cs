using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateName();
            ValidateEmail();
            ValidatePhone();
            ValidateDate();
        }

        //Method to validate names
        public static void ValidateName()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid Name: ");
                string userName = Console.ReadLine();

                //only alphabets, capital letter, max length of 30
                if (Regex.IsMatch(userName, @"^[A-Z][a-z]{1,29}$"))
                {

                    Console.WriteLine("That is a valid name.");
                    break;
                }
                else
                {
                    Console.WriteLine("That is NOT a valid name!");
                }
            }

        }

        //Method to validate emails
        public static void ValidateEmail()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid Email: ");
                string userEmail = Console.ReadLine();

                //alphanumeric between 5 and 30, no special characters, @ symbol, combo of alphanumeric between 5 and 10 with no special symbols, ., domain length of 2 or 3
                if (Regex.IsMatch(userEmail, @"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}.[a-z]{2,3}$"))
                {

                    Console.WriteLine("That is a valid email.");
                    break;
                }
                else
                {
                    Console.WriteLine("That is NOT a valid email!");
                }
            }
        }

        ////Method to validate phone numbers
        public static void ValidatePhone()
        { 
            while (true)
            {
                Console.WriteLine("Please enter a valid phone number: ");
                string userPhone = Console.ReadLine();

                //area code of 3 digits
                //-
                //3 digits
                //-
                //4 digits
                if (Regex.IsMatch(userPhone, @"^\d\d\d-\d\d\d-\d\d\d\d$"))
                {
                    Console.WriteLine("That is a valid phone number.");
                    break;
                }
                else
                {
                    Console.WriteLine("That is NOT a valid phone number!");
                }
            }
        }

        //Method to validate date
        public static void ValidateDate()
        {
            while (true)
            {
                Console.WriteLine("Please enter a valid date: ");
                string userDate = Console.ReadLine();

                //format dd/mm/yyyy
                if (Regex.IsMatch(userDate, @"^\d\d/\d\d/\d\d\d\d$"))
                {
                    Console.WriteLine("That is a valid date.");
                    break;
                }
                else
                {
                    Console.WriteLine("That is NOT a valid date!");
                }
            }
        }
    }
}
