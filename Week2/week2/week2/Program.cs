using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            /*string UserName;
            int UserAge;
            string UserGender;
            string UserAddress;
            
            Console.WriteLine("Please enter your name");
            UserName = Console.ReadLine();
            Console.WriteLine("Hello there, {0}. How old are you?", UserName);
            UserAge = int.Parse(Console.ReadLine());
            Console.WriteLine("And your gender?");
            UserGender = Console.ReadLine();
            Console.WriteLine("And your address?");
            UserAddress = Console.ReadLine();

            Console.WriteLine("Hi {0}, you are a {1} year old {2} who lives at {3}.", UserName, UserAge, UserGender, UserAddress);
            Console.ReadLine();
            */

            /*
            double num1;
            double num2;
            double sum;
            double multiplied;
            double divided;
            double subtracted;

            Console.WriteLine("Give me a number!");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number!");
            num2 = double.Parse(Console.ReadLine());

            sum = num1 + num2; 
            multiplied = num1 * num2;
            divided = num1 / num2;
            subtracted = num1 - num2;
            // do the math

            Console.WriteLine(num1 + " + " + num2 + " = " + sum); 
            Console.WriteLine(num1 + " x " + num2 + " = " + multiplied);
            Console.WriteLine(num1 + " / " + num2 + " = " + divided);
            Console.WriteLine(num1 + " - " + num2 + " = " + subtracted);
            //display the math

            Console.ReadLine();
            */
            /*
            Console.WriteLine("Please enter your first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string LastName = Console.ReadLine();

            Console.WriteLine("your name is " + FirstName + " " + LastName);

            Console.ReadLine();
            */

            //Topic 3 task 1
            /*
            int i = 1;
            while (i == 1)//while loop so program desont have to be restarted
            {
                Console.WriteLine("Please enter a whole number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter another number");
                int num2 = int.Parse(Console.ReadLine());
                //get 2 numbers from users

                if (num1 < num2)
                {
                    Console.WriteLine(num2 + " is larger than " + num1);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine(num1 + " is larger than " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " and " + num2 + " are equal");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            */

            //Topic 3 task 2
            /*
            Random random = new Random();
            int myNum = random.Next(1, 10);
            int userNum;
            int i = 1;

            Console.WriteLine("I am thinking of a number between 1 and 10 inclusive. Can you guess my number?");


            while (i == 1)
            {
                userNum = int.Parse(Console.ReadLine());

                if (userNum == myNum)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    if (userNum < myNum)
                    {
                        Console.WriteLine("Wrong! go higher.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! go lower.");
                    }
                }


                
            }
            Console.ReadLine();
            */

            //topic 3 task 3
            /*
            int userMark;
            int i = 1;

            while (i == 1)
            {
                Console.WriteLine("\n\nEnter your mark out of 100");
                userMark = int.Parse(Console.ReadLine());

            
                if (userMark < 100 && userMark > 89)
                {
                    Console.WriteLine("Congrats! you got an A+");
                }
                else if (userMark < 90 && userMark > 79)
                {
                    Console.WriteLine("Congrats! you got an A");
                }
                else if (userMark < 80 && userMark > 69)
                {
                    Console.WriteLine("Congrats! you got a B+");
                }
                else if (userMark < 70 && userMark > 59)
                {
                    Console.WriteLine("Congrats! you got a B");
                }
                else if (userMark < 60 && userMark > 49)
                {
                    Console.WriteLine("Congrats! you got a C");
                }
                else if (userMark < 50 && userMark > 39)
                {
                    Console.WriteLine("Oh dear! you got a D");
                }
                else if (userMark < 49)
                {
                    Console.WriteLine("Oh dear! you got an f");
                }
                else
                {
                    Console.WriteLine("error");
                    
                }
            }
            
            Console.ReadLine();
            */

            //Topic 3 task 4
            int loop = 1;
           
            while (loop == 1)
            {
                Console.WriteLine("Enter a number");
                int i = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is an even number");

                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }

            Console.ReadLine();
        }
    }
}
