using System;

namespace OOP1Laba_greeting
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string my_name;
            Console.WriteLine("Please, write your name:");
            my_name = Console.ReadLine();
            Console.WriteLine("Hello, {0}", my_name);
        }
    }
}
