// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
  
        public static double FeetToCentimeter(int feet)
        {
        double centimeter=feet*30.48;
        return Math.Round(centimeter, 2,MidpointRounding.AwayFromZero);
        
        }
        
    
}
class Fleet
{
    public static void Main(string[] args)
    {
       
       
        Console.WriteLine(HelloWorld.FeetToCentimeter(5).ToString("F2"));
        Console.WriteLine(HelloWorld.FeetToCentimeter(1).ToString("F2"));

    }
}