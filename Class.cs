using System;

class Employee
{
    public string EmployeeName { get; set; } = "Sujal";
    public decimal BasicSalary { get; set; } = 30000m;
    public decimal BonusPercentage { get; set; } = 10m;

    public decimal CalculateBonus()
    {
        return BasicSalary * BonusPercentage / 100m;
    }

    public decimal CalculateTotalSalary()
    {
        return BasicSalary + CalculateBonus();
    }

    public void DisplaySalary()
    {
        Console.WriteLine("Employee Salary Details");
        Console.WriteLine("----------------------------");
        Console.WriteLine($"Employee: {EmployeeName}");
        Console.WriteLine($"Basic Salary: Rs. {BasicSalary:F2}");
        Console.WriteLine($"Bonus: Rs. {CalculateBonus():F2}");
        Console.WriteLine($"Total Salary: Rs. {CalculateTotalSalary():F2}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee();
        employee.DisplaySalary();
    }
}