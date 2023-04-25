using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integers
            Console.WriteLine("Integer Methods");
            Console.WriteLine("15 + 88 is " + Calculate.Add(15, 88));
            Console.WriteLine("78 - 88 is " + Calculate.Sub(78, 88));
            Console.WriteLine("8 * 9 is " + Calculate.Mult(8, 9));
            Console.WriteLine("77 / 8 is " + Calculate.Div(77, 8));

            //Floats
            Console.WriteLine("\nFloats Methods");
            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.45f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));

        }
    }
}
