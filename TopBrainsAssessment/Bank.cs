using System;
public class Bank
{
    
public static int FinalBalance(int initialBalance, int[] transactions)
{
    long balance=initialBalance;
    
    foreach(var t in transactions)
    {
        if(t>=0)
        {
            balance=balance+t;
        }
        else
        {
            if(balance+t>=0)
            {
                balance=balance+t;
            }
        }
    }
    return (int)balance;
}
static void Main(string[] args)
{
    int initialBalance=100;
    int[] transactions={50, -20, -200, 30};
    int res=FinalBalance(initialBalance, transactions);
    Console.WriteLine("Final Balance: "+ res);
}
}