using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************");
            Console.WriteLine("****Week 4 Algrebra?****");
            Console.WriteLine("************************");

            //Question 1
            /*
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("\n\n\tQuestion 1");
                Console.WriteLine("\nPlease enter a letter and i will tell you if its a vowel or not.");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine(input + " is a vowel!");
                        break;
                    default:
                        Console.WriteLine(input + " is not a vowel!");
                        break;
                }
            }
            Console.ReadLine();
            */
            //question 2
            /*
            Console.WriteLine("Hello! I will calculate you BMI.");
            Console.Write("Please enter your weight in kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Please enter you height in cm: ");
            float height = (float.Parse(Console.ReadLine())) / 100;

            float bmi = weight / (height * height);

            Console.WriteLine("Your BMI is " + bmi);

            Console.ReadLine();
            */
            //question 3
            /*
            Console.WriteLine("------Question 3------");
            Console.WriteLine("\nthis app will calculate the sum of 20 numbers");
            for (int t = 1; t > 0; t++)
            {
                try
                {
                    float sum = 0;
                    
                    for (int i = 1; i < 21; i++)
                    {
                        Console.Write("Please enter number " + i + ": ");
                        sum += float.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nthe sum of your numbers is: " + sum);
                }
                catch
                {
                    Console.WriteLine("please enter valid numbers");
                }
            }

            Console.ReadLine();
            */
            /*
            Console.WriteLine("------Questrion 4------");
            Console.WriteLine("\nThis app will calculate the factorial of 10");
            double answer = 1;

            for(int i = 1; i <11; i++)
            {
                answer = answer * i;
            }

            Console.WriteLine("10 factorial is: " + answer);
            Console.WriteLine("press ENTER to quit");
            Console.ReadLine();
            */

            Console.WriteLine("extesnion1. solving the quadratic equation x^2+5x+6=0");
            int a = 1;
            int b = 5;
            int c = 6;
            int check = 0;

            Console.WriteLine($"a is {a}, b is {b}, c is {c}.");

            for(int i = 1; i < b+1; i++)
            {
                if (i <= b)
                {
                    
                    if (c % i == 0)
                    {

                    }
                }                      
                    //if (i <= b && c % i == 0)
                   // {
                        
                        //    Console.WriteLine(i);
                        
                   // }
                    
                
            }

            Console.ReadLine();

        }

    }
}
