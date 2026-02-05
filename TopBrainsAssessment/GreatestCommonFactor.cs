// See https://aka.ms/new-console-template for more information
using System;
public class Hello
{
    public static int GCD(int a, int b)
    {
        if(b==0)
        return a;
        
        return GCD(b, a%b);
    }
}
class GreatestCommonFactor
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Hello.GCD(45, 18));
        Console.WriteLine(Hello.GCD(10,20));
    }
}