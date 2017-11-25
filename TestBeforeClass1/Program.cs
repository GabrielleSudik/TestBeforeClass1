using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { //test run before class

            Console.WriteLine("What's your favorite numnber?");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.WriteLine($"Your favorite number is {number}, {name}!");

            Console.ReadLine();
        }
    }
}
