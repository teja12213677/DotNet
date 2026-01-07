// See https://aka.ms/new-console-template for more information
public interface IReportable
{
    string GetSummary();
}
public abstract class Transaction : IReportable
{
    public int Id{get; set;}
    public DateTime Date{get; set;}
    public decimal Amount {get; set;}
    public string Description {get; set;}

    public Transaction (int id, DateTime date, decimal amount, string description)
    {
        this.Id=id;
        this.Date=date;
        this.Amount=amount;
        this.Description=description;


    }
    public abstract string GetSummary();



}


public class Ledger<T> where T : Transaction
{
    internal List<T> transactions = new List<T>();
    public void AddTransaction(T transaction)
    {
        transactions.Add(transaction);
    }
    public void GetTransactionByDate(DateTime date)
    {
        var results = transactions.Where(t => t.Date.Date == date.Date);
        foreach (var transaction in results)
        {
            Console.WriteLine(transaction.GetSummary());
        }

    }
    public void CalculateTotal()
    {
        decimal total = transactions.Sum(t => t.Amount);
        Console.WriteLine($"Total Amount: {total:C}");


    }

}
class Program
{
    public static void Main(string[] args)    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        incomeLedger.AddTransaction(new IncomeTransaction(1, DateTime.Now, 1000m, "Salary", "Job"));
       incomeLedger.AddTransaction(new IncomeTransaction(2, DateTime.Now.AddDays(-1), 200m, "Freelance", "Side Job"));
       incomeLedger.AddTransaction(new IncomeTransaction(3, DateTime.Now, 800m, "Trading", "Payment"));

        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();
        expenseLedger.AddTransaction(new ExpenseTransaction(1, DateTime.Now, 150m, "Groceries", "Supermarket"));
        expenseLedger.AddTransaction(new ExpenseTransaction(2, DateTime.Now.AddDays(-1), 50m, "Transport", "Bus"));



        Console.WriteLine("Income Transactions on Today:");
        incomeLedger.GetTransactionByDate(DateTime.Now);
        incomeLedger.CalculateTotal();

        Console.WriteLine("\nExpense Transactions on Today:");
        expenseLedger.GetTransactionByDate(DateTime.Now);
        expenseLedger.CalculateTotal();

        foreach (var transaction in incomeLedger.transactions)
        {
            Console.WriteLine(transaction.GetSummary());
        }
    }
}

