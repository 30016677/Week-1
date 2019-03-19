using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************");
            Console.WriteLine("****Week 3 Loops****");
            Console.WriteLine("********************");

            /*for loops
             
            int limit = 10;

            for(int counter = 1; counter <= limit; counter++)
            {
                Console.WriteLine("Loop " + counter);
            }

            Console.ReadLine();
            */

            /*While Loops
            Console.Write("would you like to enter the matrix? (Y/N): ");
            string input = Console.ReadLine().ToLower();

            while (input == "y")
            {
                Console.WriteLine("you are now inside the matrix.");
                Console.WriteLine("Would you like to stay inside the matrix? (Y/N):");
                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nYou have now passed the While loop");
            Console.ReadLine();
            */

            /*Do/While loop
            string input = "n";

            do
            {
                Console.WriteLine("you are now inside the loop.");
                Console.Write("Would you like to stay inside the loop? (Y/N):");
                input = Console.ReadLine().ToLower();

            } while (input != "n");

            Console.WriteLine("\nYou have now passed the do while loop");


            Console.ReadLine();
            */
            //**************LOOP EXERCISES*****************
            //  Task 1 
            /*

            //for
            Console.WriteLine("*****For loop*****");

            for (int i = 3; i<8; i++)
            {
                Console.WriteLine(i + "     " + i*10 + "     " + i*100 + "     " + i*1000);

            }

            //while
            Console.WriteLine("\n*****While loop*****");

            int w = 3;
            while(w < 8)
            {
                Console.WriteLine(w + "     " + w * 10 + "     " + w * 100 + "     " + w * 1000);
                w++;
            }

            //do while
            Console.WriteLine("\n*****Do While loop*****");

            int d = 3;
            do
            {
                Console.WriteLine(d + "     " + d * 10 + "     " + d * 100 + "     " + d * 1000);
                d++;
            } while (d < 8);



            Console.ReadLine();
            */
            /*
            // task 2
            Console.WriteLine("For Loop");
            Console.WriteLine("please enter a whole number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + num1 + " Times Tables.");

            for (int f=1; f<13; f++)
            {
                int answer = f * num1;
                Console.WriteLine(f + " x " + num1 + " = " + answer);
            }

            //while
            Console.WriteLine("\nplease enter another whole number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + num2 + " Times Tables.");

            int w = 1;
            while (w < 13)
            {
                int answer = w * num2;
                Console.WriteLine(w + " x " + num2 + " = " + answer);
                w++;
            }

            //do while
            Console.WriteLine("\nplease enter another whole number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" + num3 + " Times Tables.");

            int d = 1;
            do
            {
                int answer = d * num3;
                Console.WriteLine(d + " x " + num3 + " = " + answer);
                d++;
            } while (d < 13);


            Console.ReadLine();
            */
            //Task 3
            /*
            
            Console.WriteLine("Number     Square     Cube");
            Console.WriteLine("--------------------------");

            Console.WriteLine("\n for");

            for (int f = 0; f < 11; f++)
            {
                int squared = f * f;
                int cubed = f * f * f;
                Console.WriteLine(f + "          " + squared + "          " + cubed);
            }

            Console.WriteLine("\n while");
            int w = 0;
            while (w <11)
            {
                int squared = w * w;
                int cubed = w * w * w;
                Console.WriteLine(w + "          " + squared + "          " + cubed);
                w++;
            }

            Console.WriteLine("\n do while");
            int d = 0;
            do
            {
                int squared = d * d;
                int cubed = d * d * d;
                Console.WriteLine(d + "          " + squared + "          " + cubed);
                d++;
            } while (d < 11);

            Console.ReadLine();
            */

            //loops and ifs exercises
            //task 1
            
            Console.WriteLine("display odd numbers from 76 to 46 (descending):");
            //int start = 75;
            //int end = 47;

            int i = 75;
            while ( i >= 47){
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
                i--;
            }


            Console.WriteLine("\nend");
            Console.ReadLine();
            //i <= start &&

            //task 2
            //for loop
            /*
            Console.WriteLine("\n======For======");
            Console.WriteLine("\nPlease enter a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("\nhow many times would you like to repeat your symbol");
            int repeat = int.Parse(Console.ReadLine()); //user input

            for (int i = 0; i < repeat; i++)
            {
                Console.Write(symbol);
            }

            //while loop
            Console.WriteLine("\n======While======");
            Console.WriteLine("\nPlease enter a symbol:");
            symbol = Console.ReadLine();
            Console.WriteLine("\nhow many times would you like to repeat your symbol");
            repeat = int.Parse(Console.ReadLine()); //user input

            int counter = 0;
            while(counter < repeat)
            {
                Console.Write(symbol);
                counter++;
            }

            //do while
            Console.WriteLine("\n======Do while======");
            Console.WriteLine("\nPlease enter a symbol:");
            symbol = Console.ReadLine();
            Console.WriteLine("\nhow many times would you like to repeat your symbol");
            repeat = int.Parse(Console.ReadLine()); //user input

            counter= 0; //reset counter
            if (repeat > 0) { 
            do
            {
                Console.Write(symbol);
                counter++;
            } while (counter < repeat);
            }
            else if (repeat == 0)
            {
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error.");
            }

            Console.ReadLine();
            

            //task 3 
            /*
            string symbol = "#";
            //int width = 5;
            //int height = 8;

            Console.WriteLine("\nHere is a rectangle made of hashtags that is 5 by 8");

            for (int height = 0; height < 8; height++)
            {
                
                for (int width = 0; width < 5; width++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine("\r");
            }



            Console.ReadLine();
            */
        }
    }
}
