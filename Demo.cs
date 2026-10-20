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