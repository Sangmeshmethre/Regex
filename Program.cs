using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisterUC5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");
        Start:
            Console.WriteLine("Select Options Please :\n" +
                 "1)Enter Password Rule No. 1\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    UserRegistration user4 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user4.ValidPasswordRule1();
                    break;


                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
            goto Start;
        }
    }
}