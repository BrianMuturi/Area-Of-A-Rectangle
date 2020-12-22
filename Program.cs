using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            double c = a * b;
            double area = c;
            Console.Write("The result is:" + c);
        }
    }
}
