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
            /*
            int loop = 1;
           
            while (loop == 1)
            {
                Console.WriteLine("\nEnter a number");
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
            */

            //Topic 3 task 5
            /*
            double pin;
            double pinCheck;
            //bool loop = true;

            //while (loop == true)
            //{
                
                Console.WriteLine("Please enter your new PIN:");
                pin = double.Parse(Console.ReadLine());

                if (pin > 0 && pin <10000)
                {
                    Console.WriteLine("Please re enter your new PIN:");
                    pinCheck = double.Parse(Console.ReadLine());

                    if (pinCheck == pin)
                    {
                        Console.WriteLine("Your PIN has been set!");
                    }
                    else
                    {
                        Console.WriteLine("Error. Your PIN numbers did not match.");
                        
                    }
                }
                else
                {
                    Console.WriteLine("This PIN number is not within the right parameters. Please try again");

                }

            //}


            Console.ReadLine();
            */

            //topic 3 task 6
            /*
            string letter1;
            string letter2;
            string letter3;

            Console.WriteLine("Think of a palindrome.");
            Console.WriteLine("what is the first letter?");
            letter1 = Console.ReadLine();
            Console.WriteLine("what is the second letter?");
            letter2 = Console.ReadLine();
            Console.WriteLine("what is the third letter?");
            letter3 = Console.ReadLine();

            if (letter1 == letter3)
            {

            
                if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u")
                {
                    Console.WriteLine("Well done, your word is a palindrome!");

                }
                else
                {
                    Console.WriteLine("Error, that is not an actual word");
                    
                }
                
            }
            else
            {
                Console.WriteLine("Sorry, your word is not a palindrome");
            }


            Console.ReadLine();
            */

            //Switches ex 1
            /*
            string answer;
            bool bool1 = false;

            Console.WriteLine("Can you guess my favourite bird out of these options:");
            Console.WriteLine("Pigeon, Kiwi, Sparrow, Hawk.");

            while (bool1 == false) // loop until correct answer is given
            { 
            answer = Console.ReadLine().ToLower(); //read users input and covert to lowercase

                switch (answer)
                {
                    case "pigeon":
                    case "sparrow":
                    case "hawk":
                        Console.WriteLine("Wrong"); //for wrong answers
                        break;

                    case "kiwi":
                        Console.WriteLine("Correct!"); //for correct answer
                        bool1 = true; //end loop
                        break;

                    default:
                        Console.WriteLine("That wasn't an option");
                        break;
                }

            }
            Console.ReadLine();
            */

            //switches ex 2
            /*
            double applePrice = 1.25;
            double bananaPrice = 3.15;
            double kiwifruitPrice = 4.65;
            double orangePrice = 2.75;
            bool loop = false;

            Console.WriteLine("Enter the name of your fruit");
            Console.WriteLine("I only know four fruits: apple, banana, kiwifruit, orange");

            while (loop == false)
            {
                string fruit = Console.ReadLine().ToLower();

                switch (fruit)
                {
                    case "apple":
                        Console.WriteLine("The price of apples is $" + applePrice);
                        break;
                    case "banana":
                        Console.WriteLine("The price of bananas is $" + bananaPrice);
                        break;
                    case "kiwifruit":
                        Console.WriteLine("The price of kiwifruit is $" + kiwifruitPrice);
                        break;
                    case "orange":
                        Console.WriteLine("The price of oranges is $" + orangePrice);
                        break;
                    default:
                        Console.WriteLine("i don't know the price of that furit sorry.");
                        break;


                }
            }
            Console.ReadLine();
            */

            //switches ex 3
            double answer;

            Console.WriteLine("******************");
            Console.WriteLine("****CALCULATOR****");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine("Please enter your first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the operator you wish to use. eg + - * /");
            string operator1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number");
            double num2 = double.Parse(Console.ReadLine());

            switch (operator1)
            {
                case "+":
                    answer = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + answer.ToString());
                    break;
                case "-":
                    answer = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + answer.ToString());
                    break;
                case "*":
                    answer = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + answer.ToString());
                    break;
                case "/":
                    answer = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " = " + answer.ToString());
                    break;
                default:
                    Console.WriteLine("unexpected input");
                    break;
            }
            



            Console.ReadLine();
        }
    }
}
