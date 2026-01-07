public class ExpenseTransaction : Transaction
{
    public string Category {get; set;}
     public ExpenseTransaction(int id, DateTime date, decimal amount, string description, string category)
        : base(id, date, amount, description)
    {
        this.Category=category;
    }
    public override string GetSummary()
    {
        return $"Expense Transaction: {Id}, Date: {Date.ToShortDateString()}, Amount: {Amount:C}, Description: {Description}, Source: {Category}";
    }
} 