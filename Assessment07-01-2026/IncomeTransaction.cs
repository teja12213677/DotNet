public class IncomeTransaction : Transaction
{
    public string Source {get; set;}
     public IncomeTransaction(int id, DateTime date, decimal amount, string description, string source)
        : base(id, date, amount, description)
    {
        this.Source=source;
    }
    public override string GetSummary()
    {
        return $"Income Transaction: {Id}, Date: {Date.ToShortDateString()}, Amount: {Amount:C}, Description: {Description}, Category: {Source}";
    }
}