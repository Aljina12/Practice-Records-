using System;
using System.Collections.Generic;
using System.Linq;

class Expense
{
    public string Description { get; set; }
    public string Category { get; set; }
    public decimal Amount { get; set; }

    public Expense(string description, string category, decimal amount)
    {
        Description = description;
        Category = category;
        Amount = amount;
    }
}

class ExpenseTracker
{
    private readonly List<Expense> expenses = new();

    public void AddExpense(string description, string category, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(description) ||
            string.IsNullOrWhiteSpace(category) ||
            amount <= 0)
        {
            Console.WriteLine("Please enter valid expense details.");
            return;
        }

        expenses.Add(new Expense(description, category, amount));
        Console.WriteLine("Expense added successfully.");
    }

    public void DisplayReport()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded.");
            return;
        }

        Console.WriteLine("\n--- Expense Report ---");

        foreach (Expense expense in expenses)
        {
            Console.WriteLine(
                $"{expense.Description} | {expense.Category} | Rs. {expense.Amount:F2}");
        }

        decimal total = expenses.Sum(e => e.Amount);

        Console.WriteLine($"\nTotal Expenses: Rs. {total:F2}");

        Console.WriteLine("\nSpending by Category:");

        var categoryTotals = expenses
            .GroupBy(e => e.Category, StringComparer.OrdinalIgnoreCase)
            .OrderByDescending(group => group.Sum(e => e.Amount));

        foreach (var group in categoryTotals)
        {
            Console.WriteLine(
                $"{group.Key}: Rs. {group.Sum(e => e.Amount):F2}");
        }

        Expense largest = expenses.OrderByDescending(e => e.Amount).First();

        Console.WriteLine(
            $"\nLargest Expense: {largest.Description} (Rs. {largest.Amount:F2})");
    }
}

class Program
{
    static void Main()
    {
        ExpenseTracker tracker = new ExpenseTracker();

        tracker.AddExpense("Lunch", "Food", 250m);
        tracker.AddExpense("Bus Fare", "Transport", 100m);
        tracker.AddExpense("Groceries", "Food", 800m);
        tracker.AddExpense("Notebook", "Education", 150m);

        tracker.DisplayReport();
    }
}