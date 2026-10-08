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

        class Task2
    {
        public static void Run()
        {
            Circle circle = new Circle();

            Console.WriteLine("PI: " + Circle.PI);
            Console.WriteLine("Radius: " + circle.Radius);
            Console.WriteLine("Area: " + circle.CalculateArea());
            Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());
        }
    }

        class Task3
    {
        public static void Run()
        {
            byte b = 200;
            short s = 30000;
            int i = 2000000;
            long l = 9000000000;
            float f = 3.14f;
            double d = 3.14159265;
            decimal m = 19.99m;
            char c = 'A';
            bool flag = true;

            string numberText = 42.ToString();
            double textNumber = double.Parse("3.14");

            Console.WriteLine("byte: " + b);
            Console.WriteLine("short: " + s);
            Console.WriteLine("int: " + i);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + m);
            Console.WriteLine("char: " + c);
            Console.WriteLine("bool: " + flag);
            Console.WriteLine("int 42 to string: " + numberText);
            Console.WriteLine("string 3.14 to double: " + textNumber);
        }
    }

        class Task4
    {
        public static void Run()
        {
            int[] numbers = { 7, 3, 9, 1, 5 };

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Position of 5: " + Array.IndexOf(numbers, 5));
        }
    }

        class Task5
    {
        public static void Run()
        {
            DateTime birthDate = new DateTime(2005, 5, 15);
            DateTime today = DateTime.Now;

            TimeSpan age = today - birthDate;
            int years = (int)age.TotalDays / 365;

            Console.WriteLine("Birthdate: " + birthDate);
            Console.WriteLine("Current date: " + today);
            Console.WriteLine("Age in years: " + years);
            Console.WriteLine("Birthdate + 10 days: " + birthDate.AddDays(10));
        }
    }

        class Task6
    {
        public static void Run()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Remove("Banana");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }

                Dictionary<int, string> fruitDict = new Dictionary<int, string>();
            fruitDict.Add(1, "Apple");
            fruitDict.Add(2, "Mango");
            fruitDict.Add(3, "Banana");
            fruitDict.Add(4, "Orange");

            foreach (var item in fruitDict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

                    static void Main(string[] args)
        {
            Task1.Run();
            Console.WriteLine();
            Task2.Run();
            Console.WriteLine();
            Task3.Run();
            Console.WriteLine();
            Task4.Run();
            Console.WriteLine();
            Task5.Run();
            Console.WriteLine();
            Task6.Run();
        }

            class Student
    {
        public string Name = "Sujal";
        public int Age = 20;

        public void Display()
        {
            Console.WriteLine("Student: " + Name + ", Age: " + Age);
        }
    }

        class Task7
    {
        public static void Run()
        {
            Student student = new Student();
            student.Display();
        }
    }

        class Rectangle
    {
        public double Length = 8;
        public double Width = 4;

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

        class Task8
    {
        public static void Run()
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Length: " + rectangle.Length);
            Console.WriteLine("Width: " + rectangle.Width);
            Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());
        }
    }

        class Temperature
    {
        public double ToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        public double ToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }

        class Task9
    {
        public static void Run()
        {
            Temperature temperature = new Temperature();

            Console.WriteLine("100 C in F: " + temperature.ToFahrenheit(100));
            Console.WriteLine("212 F in C: " + temperature.ToCelsius(212));
        }
    }

        class BankAccount
    {
        public double Balance = 1000;

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }
    }

        class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }


        class Task17
    {
        public static void Run()
        {
            MarksCalculator marks = new MarksCalculator();

            Console.WriteLine("Total marks: " + marks.GetTotal());
            Console.WriteLine("Average marks: " + marks.GetAverage());
        }
    }