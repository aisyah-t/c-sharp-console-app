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

            Console.WriteLine("There once was a boy named...");
            Console.ReadLine();

            Console.WriteLine("...He loved to...");
            Console.ReadLine();

            Console.WriteLine("...and he was an...");
            Console.ReadLine();

            Console.WriteLine("...One day he went to...");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("...and ended up...");
            Console.ReadLine();


            Console.ReadKey();
        }
    }
}
