using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------Solving quadratic equations------\n\n");
            Console.WriteLine("example quadratic: x^2+7x+10=0\n");
            Console.Write("Enter your A value: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter your B value: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter your C value: ");
            double c = double.Parse(Console.ReadLine());
            //double x = 0;

            //----quadratic formula method----
            Console.WriteLine($"\nhere is your quadratic equation: {a}x^2 + {b}x +{c}.");

            //x = (-(b) + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
            // Console.WriteLine("\nthe positive solution for x is " + x); //math for positive solution

            //x = (-(b) - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a);
            //Console.WriteLine("the negative solution for x is " + x); //math for negative solution

            //------factorising method------
            //x^2+7x+10=0    x= -5, -2
            //double bTest;
            //double bTest1 = 0;
            //double bTest2 = 0;
            if (c < 0)//if c is positive
            {
                for (double i = (-1*c); i <= c; i--)//set i to c; while i is <= -ve of c; i++
                {
                    //for(double j = b; j <= (-1*b); j++)//find addends of b (7)
                    //{
                    for(double bTest1 = 0;)
                    {
                        if (c % i == 0) //find all whole multiples of c (10)
                        {
                            bTest1 = i;
                            Console.WriteLine(i);
                            //bTest(i); //test
                            i++;
                        }
                        if (c % i == 0) //find all whole multiples of c (10)
                        {
                            bTest2 = i;
                            Console.WriteLine(i);
                            //bTest(i); //test 
                        }
                        if (bTest1 * bTest2 == c && bTest1 + bTest2 == b)
                        {
                            Console.WriteLine("(x+" + bTest1 + ")(x+" + bTest2 + ")");
                        }
                    }
                    

                        
                    //}
                    

                }
            }
            //else if (c > 0)
            //{
              //  for (double i = c; i <= (-1 * c); i--)
                //{
                  //  if (c % i == 0)
                    //{
                      //  Console.WriteLine(i);

                    //}
               // }
            //}
            


            Console.ReadLine();
        }
        
    }
}
