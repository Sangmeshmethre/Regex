using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisterUC5
{
    internal class UserRegistration
    {
        public void ValidPasswordRule1()
        {
            Console.WriteLine("Please Enter Password Rule 1 :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-Z]{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 1 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 1 Invalid");
                Console.ResetColor();
            }
        }
    }
}
