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



            double num1;
            double num2;
            double num3;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.Write("Now input a number: ");

            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");

            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Now input a final number: ");

            num3 = Convert.ToDouble(Console.ReadLine());

            double averageOfThreeNumbers = (num1 + num2 + num3) / 3;

            Console.WriteLine("The average of the three numbers are: " + averageOfThreeNumbers);

            //Wait before closing
            Console.ReadKey();
        }
    }
}
