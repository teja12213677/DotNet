// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");it and Run your C# code using C# Online Compiler
using System;
public class Cabs{
    public string BookingID{set; get;}
    public string CabType {set; get;}
    public double Distance{set; get;}
    public int WaitingTime{set; get;}
    
}
public class CabDetails :Cabs

{
    public bool ValidateBookingID(){
        if(BookingID.Length != 6)
        return false;
        if(BookingID.StartsWith("AC@"))
        {
            string digits=BookingID.Substring(3);
        
        if(digits.Length == 3 && int.TryParse(digits, out _))
        return true;
    }
    return false;
    
}
public double CalculateFareAmount()
{
    double pricePerKm=0;
    if(CabType=="Hatchback")
    pricePerKm=10;
    else if(CabType=="Sedan")
    pricePerKm=20;
    else if(CabType=="SUV")
    pricePerKm=30;
    double waitingCharge=Math.Sqrt(WaitingTime);
    double fare=(Distance*pricePerKm)+waitingCharge;
    
    return Math.Floor(fare*100)/100;
}

}


public class Program{
    public static void Main(String[] args){
        
    CabDetails cab=new CabDetails();
    
    Console.WriteLine("ENter the booking id");
    cab.BookingID=Console.ReadLine();
    if(cab.ValidateBookingID())
    {
        Console.WriteLine("Enter the cab type ");
        cab.CabType=Console.ReadLine();
        
        Console.WriteLine("enter the distance in km");
        cab.Distance=double.Parse(Console.ReadLine());
        
        Console.WriteLine("enter the waiting time in minutes");
        cab.WaitingTime=int.Parse(Console.ReadLine());
        
        double fareAmount=cab.CalculateFareAmount();
        Console.WriteLine($"The fare amount is {fareAmount:F2}");
    }
    else{
        Console.WriteLine("Invalid booking id");
    }
    }
    
}

