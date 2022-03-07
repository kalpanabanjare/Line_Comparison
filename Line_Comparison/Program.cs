using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Enter X1 :"); // to take input from user for X1
            int X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 :"); // to take input from user for X2
            int X2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 :"); // to take input from user for Y1
            int Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 :"); // to take input from user for Y2
            int Y2 = int.Parse(Console.ReadLine());
            var Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Length of Line: " + Length);
        }
    }
}
