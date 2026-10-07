Console.Write("Choose a day (1-3): ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}

using System;
using System.Collections.Generic;

namespace csharp
{
    class Task1
    {
        public static void Run()
        {
            string userName = "Sujal";
            int luckyNumber = 7;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Task1.Run();
        }
    }
}

    class Circle
    {
        public const double PI = 3.14;
        public double Radius = 5;

        public double CalculateArea()
        {
            return PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }
    }