using System;

class DaySelector
{
    public static void Run()
    {
        Console.Write("Choose a day (1-3): ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
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
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}

using System;

class BankAccount
{
    public decimal Balance { get; private set; } = 1000m;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited: Rs. {amount:F2}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        Balance -= amount;
        Console.WriteLine($"Withdrawn: Rs. {amount:F2}");
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: Rs. {Balance:F2}");
    }
}