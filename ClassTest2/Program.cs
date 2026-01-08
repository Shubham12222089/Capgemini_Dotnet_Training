using System;
using System.Collections.Generic;

public interface IReportable
{
    string GetSummary();
}

public abstract class Transaction : IReportable
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public abstract string GetSummary();
}

public class IncomeTransaction : Transaction
{
    public string Source {get; set;}
    public override string GetSummary()
    {
        return $"INCOME : {Date.ToShortDateString()} | Amount: {Amount} | Description: {Description} | Source: {Source}";
    }
}

public class ExpenseTransaction : Transaction
{
    public string Category{get;set;}
    public override string GetSummary()
    {
        return $"EXPENSE : {Date.ToShortDateString()} | Amount: {Amount} | Description: {Description} | Category: {Category}";;
    }
}

public class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();

    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }

    public List<T> GetTransactionsByDate(DateTime date)
    {
        List<T> result = new List<T>();

        foreach (T t in transactions)
        {
            if (t.Date.Date == date.Date)
            {
                result.Add(t);
            }
        }
        return result;
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (T t in transactions)
        {
            total = total + t.Amount;
        }
        return total;
    }

    public List<T> GetAll()
    {
        return transactions;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();

        incomeLedger.AddEntry(new IncomeTransaction
        {
            Id = 1,
            Date = DateTime.Today,
            Amount = 500,
            Description = "Petty cash replenishment",
            Source = "Main Cash"
        });

        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        expenseLedger.AddEntry(new ExpenseTransaction
        {
            Id = 2,
            Date = DateTime.Today,
            Amount = 20,
            Description = "Bought stationery",
            Category = "Office"
        });

        expenseLedger.AddEntry(new ExpenseTransaction
        {
            Id = 3,
            Date = DateTime.Today,
            Amount = 15,
            Description = "Snacks for team",
            Category = "Food"
        });

        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpense = expenseLedger.CalculateTotal();

        Console.WriteLine($"Total Income: {totalIncome}");
        Console.WriteLine($"Total Expense: {totalExpense}");
        Console.WriteLine($"Net Balance: {totalIncome - totalExpense}");

        
        Console.WriteLine("\n -------Transaction Summary-------");
        List<Transaction> allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.GetAll());
        allTransactions.AddRange(expenseLedger.GetAll());

        foreach (var t in allTransactions)
        {
            Console.WriteLine(t.GetSummary());
        }
    }
}