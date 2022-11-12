using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistarUC8
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");
        Start:
            Console.WriteLine("Select Options Please :\n" +
                 "1)Enter Password Rule No. 4\n");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:

                    UserRegistration user7 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user7.ValidPasswordRule4();
                    break;



                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
            goto Start;
        }
    }


}