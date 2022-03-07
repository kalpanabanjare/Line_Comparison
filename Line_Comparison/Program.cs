using System;

namespace Line_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            //UC1
            Console.WriteLine("Enter X1 :"); // to take input from user for X1
            int X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 :"); // to take input from user for X2
            int X2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 :"); // to take input from user for Y1
            int Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 :"); // to take input from user for Y2
            int Y2 = int.Parse(Console.ReadLine());
            var Length_of_first_line = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Length of Line: " + Length_of_first_line);

            //UC2
            Console.WriteLine("Enter X1 for line 2 :"); // to take input from user for X1 for line 2
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 for line 2 :"); // to take input from user for X2 for line 2
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 for line 2 :"); // to take input from user for Y1 for line 2
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 for line 2 :"); // to take input from user for Y2 for line 2
            int y2 = int.Parse(Console.ReadLine());
            var Length_of_second_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line: " + Length_of_second_line);

            if (Length_of_first_line == Length_of_second_line) // to compare both lines
            {
                Console.WriteLine("Length are equal");
            }
            else
            {
                Console.WriteLine("Length are not equal");
            }
        }
    }
}
