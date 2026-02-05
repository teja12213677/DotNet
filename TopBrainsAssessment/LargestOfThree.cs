// See https://aka.ms/new-console-template for more information
using System;
class Hello
{
    public static int Highest(int a, int b, int c)
    {
        if(a>=b && a>=c)
        return a;
        else if(b>=a && b>=c)
        return c;
        else 
        return c;
        
    }
}
class LargestOfThree
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Hello.Highest(5,6,7));
        Console.WriteLine(Hello.Highest(23,34,65));
    }
}
