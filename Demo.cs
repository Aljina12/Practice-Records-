
using System;

// Task 16: Shop
class Shop
{
    public string ItemName { get; set; } = "Pen";
    public decimal Price { get; set; } = 25m;
    public int Quantity { get; set; } = 5;

    public decimal CalculateTotal()
    {
        return Price * Quantity;
    }

    public decimal CalculateTax(decimal taxPercent)
    {
        return CalculateTotal() * taxPercent / 100;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("=== Shop Details ===");
        Console.WriteLine($"Item: {ItemName}");
        Console.WriteLine($"Price: Rs. {Price:F2}");
        Console.WriteLine($"Quantity: {Quantity}");
        Console.WriteLine($"Subtotal: Rs. {CalculateTotal():F2}");
        Console.WriteLine($"Tax (13%): Rs. {CalculateTax(13):F2}");
        Console.WriteLine(
            $"Total with Tax: Rs. {CalculateTotal() + CalculateTax(13):F2}");
    }
}

// Task 17: Marks Calculator
class MarksCalculator
{
    public string StudentName { get; set; } = "Sujal";
    public int Math { get; set; } = 85;
    public int Science { get; set; } = 78;
    public int English { get; set; } = 92;

    public int CalculateTotal()
    {
        return Math + Science + English;
    }

    public double CalculateAverage()
    {
        return CalculateTotal() / 3.0;
    }

    public string CalculateGrade()
    {
        double average = CalculateAverage();

        if (average >= 80)
            return "A";
        if (average >= 70)
            return "B";
        if (average >= 60)
            return "C";
        if (average >= 40)
            return "D";

        return "Fail";
    }

    public void DisplayResult()
    {
        Console.WriteLine("\n=== Student Result ===");
        Console.WriteLine($"Student: {StudentName}");
        Console.WriteLine($"Total: {CalculateTotal()} / 300");
        Console.WriteLine($"Average: {CalculateAverage():F2}%");
        Console.WriteLine($"Grade: {CalculateGrade()}");
    }
}

// Task 18: Number Checker
class NumberChecker
{
    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public int GetAbsoluteValue(int number)
    {
        return Math.Abs(number);
    }

    public void CheckNumber(int number)
    {
        Console.WriteLine("\n=== Number Checker ===");
        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Even: {IsEven(number)}");
        Console.WriteLine($"Prime: {IsPrime(number)}");
        Console.WriteLine($"Absolute Value: {GetAbsoluteValue(number)}");
    }
}

// Task 19: Greeting
class Greeting
{
    public string GetGreeting(string name, int hour)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "Please enter a valid name.";

        if (hour < 0 || hour > 23)
            return "Invalid hour. Enter a number from 0 to 23.";

        if (hour < 12)
            return $"Good morning, {name}!";

        if (hour < 17)
            return $"Good afternoon, {name}!";

        if (hour < 21)
            return $"Good evening, {name}!";

        return $"Good night, {name}!";
    }

    public void DisplayGreetings()
    {
        Console.WriteLine("\n=== Greeting Messages ===");
        Console.WriteLine(GetGreeting("Sujal", 9));
        Console.WriteLine(GetGreeting("Sujal", 14));
        Console.WriteLine(GetGreeting("Sujal", 19));
        Console.WriteLine(GetGreeting("Sujal", 22));
    }
}

// Task 20: Counter
class Counter
{
    public int Count { get; private set; }

    public void Increment(int amount = 1)
    {
        if (amount > 0)
            Count += amount;
    }

    public void Decrement(int amount = 1)
    {
        if (amount > 0)
            Count -= amount;
    }

    public void Reset()
    {
        Count = 0;
    }

    public void DisplayCount()
    {
        Console.WriteLine($"Current Count: {Count}");
    }
}

// Main Program
class Program
{
    static void Main()
    {
        Shop shop = new Shop();
        shop.DisplayDetails();

        MarksCalculator marks = new MarksCalculator();
        marks.DisplayResult();

        NumberChecker checker = new NumberChecker();
        checker.CheckNumber(17);

        Greeting greeting = new Greeting();
        greeting.DisplayGreetings();

        Console.WriteLine("\n=== Counter ===");

        Counter counter = new Counter();
        counter.DisplayCount();

        counter.Increment(5);
        counter.DisplayCount();

        counter.Decrement(2);
        counter.DisplayCount();

        counter.Reset();
        counter.DisplayCount();
    }
}
