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
            Console.WriteLine("*******************************");
            Console.WriteLine("****Week 4 Algrebra/Methods****");
            Console.WriteLine("*******************************");

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
            /* extension1
            Console.WriteLine("extesnion1. solving the quadratic equation x^2+5x+6=0");
            int a = 1;
            int b = 5;
            int c = 6;
            int check = 0;

            Console.WriteLine($"a is {a}, b is {b}, c is {c}.");

            for(int i = 1; i <= c; i++) //find the multiples of C
            {
               
                    if (c % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                
            }
                
                                      
                    //if (i <= b && c % i == 0)
                   // {
                        
                        //    Console.WriteLine(i);
                        
                   // }
            Console.ReadLine();
            */

            //METHODS
            //exercise 1
            /*
            Console.WriteLine("\n Methods exercise 1");
            Console.Write("\nPlease enter a number:");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("The opposite of your number is: " + Opposite(input));
            
            Console.ReadLine();
            */
            //exercise 2
            /*
            Console.WriteLine("\nMethods - exercis 2");
            Console.Write("\nPlease enter your distance in miles: ");
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine(miles + " miles  is " + Kilometres(miles) + " in kilometres.");
            
            Console.ReadLine();
            */
            //exercise 3
            /*
            Console.WriteLine("Methods Exercise 3");
            Console.WriteLine("\nWhat is the radius of your circle?");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("the circumfrence of your circle is {0}" +
                " and the area of your circle is {1}", Circumference(r), Area(r));

            Console.ReadLine();
            */
            //exercise 4
            //Console.WriteLine("Methods Exercise 4");

            //Task 1 and 2
            
            Console.WriteLine("Methods Task 1 and 2");
            Console.WriteLine("\n This app will calculate you BMI");
            Console.Write("Please enter your weight in KG: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Please enter your Height in M: ");
            float height = float.Parse(Console.ReadLine());

            float bmi = Calculatebmi(weight, height); //bmi method

            Console.WriteLine("\nYour BMI is " + bmi);

            Console.WriteLine("You are " + CalculateCategory(bmi)); //call category method

            Console.ReadLine();
            
            //task 3
            
           // Console.WriteLine("Methods Task 3")

        }
        static int Opposite(int userInput) //methods exercise 1
        {
            return userInput * -1;
        }
        static double Kilometres(double userInput) //methods exercise 2
        {
            return userInput * 1.62137;
        }
        static double Circumference(double r) //methods exercise 3
        {
            return r * 2 * 3.1416;
        }
        static double Area(double r) //methods exercise 3
        {
            return r * r * 3.1416;
        }
        static float Calculatebmi(float w, float h)
        {
            return w / (h * h);
        }
        static string CalculateCategory(float bmiCat)
        {
            if (bmiCat < 18.5) { return "underweight"; }
            else if (bmiCat >= 18.5 && bmiCat < 25) { return "normal weight"; }
            else if (bmiCat >= 25 && bmiCat < 30) { return "overweight"; }
            else {return "obese"; }
        }
    }
}
