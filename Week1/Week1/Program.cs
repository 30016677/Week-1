using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Say hello
            Console.WriteLine("Hello!");
            //Console.ReadLine();

                       
            Console.Write("Please enter your age:");    //ask user for age
            int age = int.Parse(Console.ReadLine());    //parse user input and store as int age

            Console.Write("Please enter your name:");   //ask user for name
            string name = Console.ReadLine();           //store user's age as string age
            

            Console.WriteLine("Hi {0} You are {1} years old",name,age); //output user's name and age
            Console.ReadLine();
            

            
        }
    }
}
