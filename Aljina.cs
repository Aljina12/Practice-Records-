    class Counter
    {
        public int Count = 0;

        public void Increase()
        {
            Count = Count + 1;
        }

        public void Decrease()
        {
            Count = Count - 1;
        }

        public void Reset()
        {
            Count = 0;
        }
    }

        class Task20
    {
        public static void Run()
        {
            Counter counter = new Counter();

            counter.Increase();
            counter.Increase();
            counter.Increase();
            Console.WriteLine("After 3 increases: " + counter.Count);

            counter.Decrease();
            Console.WriteLine("After 1 decrease: " + counter.Count);

            counter.Reset();
            Console.WriteLine("After reset: " + counter.Count);
        }
    }

    using System;

class Program
{
    static void Main()
    {
        string name = "Sujal";
        int age = 21;
        string course = "C# Programming";

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Course: {course}");
    }
}

using System;

class Program
{
    static void Main()
    {
        const double PI = 3.14159;
        double radius = 5;

        double area = PI * radius * radius;
        double circumference = 2 * PI * radius;

        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Area: {area:F2}");
        Console.WriteLine($"Circumference: {circumference:F2}");
    }
}

using System;
using System.Linq;

class PasswordChecker
{
    public static string CheckStrength(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return "Invalid: Password cannot be empty.";
        }

        int score = 0;

        if (password.Length >= 8)
            score++;

        if (password.Any(char.IsUpper))
            score++;

        if (password.Any(char.IsLower))
            score++;

        if (password.Any(char.IsDigit))
            score++;

        if (password.Any(c => !char.IsLetterOrDigit(c)))
            score++;

        if (password.Length < 8)
            return "Weak: Use at least 8 characters.";

        if (score <= 2)
            return "Weak";

        if (score <= 4)
            return "Moderate";

        return "Strong";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Password Strength Checker ===");

        Console.Write("Enter a password: ");

        string password = Console.ReadLine() ?? "";

        string result = PasswordChecker.CheckStrength(password);

        Console.WriteLine($"Password Strength: {result}");
    }
}