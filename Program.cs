using System;

namespace c_sharp_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "C# Console App";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 30;

            Console.WriteLine("Hello, what is your name?\nMy name is Mr Miyagi.");
            Console.ReadLine();

            Console.WriteLine("Nice to meet you!\nWhat's your favourite colour?");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cool! Mine is red.");

            Console.ReadKey();
        }
    }
}
