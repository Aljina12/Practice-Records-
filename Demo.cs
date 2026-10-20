using System;

// Task 21: Employee Salary Calculator
class Employee
{
    public string Name { get; set; } = "Sujal";
    public decimal BasicSalary { get; set; } = 30000m;
    public decimal Allowance { get; set; } = 5000m;
    public decimal TaxRate { get; set; } = 10m;

    public decimal CalculateGrossSalary()
    {
        return BasicSalary + Allowance;
    }

    public decimal CalculateTax()
    {
        return CalculateGrossSalary() * TaxRate / 100;
    }

    public decimal CalculateNetSalary()
    {
        return CalculateGrossSalary() - CalculateTax();
    }

    public void DisplayDetails()
    {
        Console.WriteLine("=== Employee Salary Details ===");
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine($"Basic Salary: Rs. {BasicSalary:F2}");
        Console.WriteLine($"Allowance: Rs. {Allowance:F2}");
        Console.WriteLine($"Gross Salary: Rs. {CalculateGrossSalary():F2}");
        Console.WriteLine($"Tax: Rs. {CalculateTax():F2}");
        Console.WriteLine($"Net Salary: Rs. {CalculateNetSalary():F2}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.DisplayDetails();
    }
}

using System;

// Task 22: Electricity Bill Calculator
class ElectricityBill
{
    public string CustomerName { get; set; } = "Sujal";
    public int UnitsConsumed { get; set; } = 150;

    public decimal CalculateBill()
    {
        int units = UnitsConsumed;
        decimal bill = 0;

        if (units < 0)
        {
            return -1;
        }

        if (units <= 20)
        {
            bill = units * 4;
        }
        else if (units <= 50)
        {
            bill = (20 * 4) + ((units - 20) * 7);
        }
        else if (units <= 100)
        {
            bill = (20 * 4) + (30 * 7) + ((units - 50) * 8.5m);
        }
        else
        {
            bill = (20 * 4) + (30 * 7) + (50 * 8.5m)
                   + ((units - 100) * 10);
        }

        return bill;
    }

    public void DisplayBill()
    {
        Console.WriteLine("=== Electricity Bill ===");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Units Consumed: {UnitsConsumed}");

        decimal bill = CalculateBill();

        if (bill < 0)
        {
            Console.WriteLine("Invalid units consumed.");
            return;
        }

        Console.WriteLine($"Total Bill: Rs. {bill:F2}");
    }
}

class Program
{
    static void Main()
    {
        ElectricityBill electricityBill = new ElectricityBill();
        electricityBill.DisplayBill();
    }
}

using System;

// Task 23: Bank Account Management
class BankAccount
{
    public string AccountHolder { get; set; } = "Sujal";

    public decimal Balance { get; private set; } = 10000m;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited: Rs. {amount:F2}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
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
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Current Balance: Rs. {Balance:F2}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        Console.WriteLine("=== Bank Account Management ===");

        account.DisplayBalance();

        Console.WriteLine();

        account.Deposit(5000m);
        account.Withdraw(2000m);

        Console.WriteLine();

        account.DisplayBalance();
    }
}