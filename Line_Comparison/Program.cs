using System;

namespace Line_Comparison
{
    class Line
    {
        public int X1;
        public int X2;
        public int Y1;
        public int Y2;
        public double Length_of_first_line = 0;
        public int x1;
        public int x2;
        public int y1;
        public int y2;
        public double Length_of_second_line = 0;
        public void Calculation()
        {
            //UC1
            Console.WriteLine("Enter X1 for line 1 :"); // to take input from user for X1
            X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 for line 1 :"); // to take input from user for X2
            X2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 for line 1 :"); // to take input from user for Y1
            Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 for line 1 :"); // to take input from user for Y2
            Y2 = int.Parse(Console.ReadLine());
            Length_of_first_line = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine("Length of Line: " + Length_of_first_line);

            //UC2
            Console.WriteLine("Enter X1 for line 2 :"); // to take input from user for X1 for line 2
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 for line 2 :"); // to take input from user for X2 for line 2
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 for line 2 :"); // to take input from user for Y1 for line 2
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 for line 2 :"); // to take input from user for Y2 for line 2
            y2 = int.Parse(Console.ReadLine());
            Length_of_second_line = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line: " + Length_of_second_line);
        }
        public void Compare()
        {            
            if (Length_of_first_line == Length_of_second_line) // to compare both lines
            {
                Console.WriteLine("Length are equal");
            }
            //UC3
            else if (Length_of_first_line > Length_of_second_line)
            {
                Console.WriteLine("Line one is greater then Line two");
            }
            else
            {
                Console.WriteLine("Line one is less then Line two");
            }
            //0 = both the numbers are equal
            //1 = second number is smaller
            //-1 = first number is smaller
            Console.WriteLine("Return value (comparison) = " + Length_of_first_line.CompareTo(Length_of_second_line));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Line line = new Line();
            line.Calculation();
            line.Compare();            
        }
    }
}
