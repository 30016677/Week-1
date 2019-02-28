using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string UserFirstName;
            string UserLastName;
            string UserAddress;
            int UserAge;
            int UserPin;

            Console.WriteLine("Hello!");
            Console.WriteLine();
            Console.WriteLine("Please enter your first name...");
            UserFirstName = Console.ReadLine();
            //ask user for their first name

           
            Console.WriteLine("Please enter your last name...");
            UserLastName = Console.ReadLine();
            //ask user for their last name

            Console.WriteLine("Please enter your address...");
            UserAddress = Console.ReadLine();
            //ask user for address

            Console.WriteLine("Please enter your age...");
            UserAge = int.Parse(Console.ReadLine());
            //ask user for age

            Console.WriteLine("Please enter your pin number...");
            UserPin = int.Parse(Console.ReadLine());
            //ask user for pin number

            Console.WriteLine();
            Console.WriteLine("Hi there, " + UserFirstName + " " + UserLastName + ". You live at {0}, and your age is {1}. Your pin number is {2}" , UserAddress, UserAge, UserPin);
            //display user input
            Console.WriteLine();
            Console.WriteLine("DON'T GIVE OUT YOUR PIN NUMBER TO ANYONE!");
            Console.WriteLine();

                */
            /*  */

            int num1;
            int num2;
            int sum1;
            decimal dec1;
            decimal dec2;
            decimal sum2;
            string string1;
            string string2;

            Console.ForegroundColor = ConsoleColor.Yellow;
                                   
            Console.WriteLine("Hello!");
            Console.WriteLine("give me a number");          
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me another number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            sum1 = num1 * num2; //do the math
                        
            Console.WriteLine(num1.ToString() + " times " + num2.ToString() + " is " + sum1.ToString()); //show the math
            Console.WriteLine();

            /*
            Console.WriteLine("give me a decimal number");
            dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Give me another decimal number");
            dec2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine();

            sum2 = dec1 + dec2; //do the math

            Console.WriteLine(dec1.ToString() + " plus " + dec2.ToString() + " is " + sum2.ToString()); //show the math
            */






            Console.ReadLine();
        }
    }
}
