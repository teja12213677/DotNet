using System;
public class Height
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Heightincm: ");
        int height=int.Parse(Console.ReadLine());
        
        if(height<150)
        {
            Console.WriteLine("Short");
        }
        else if(height<180)
        {
            Console.WriteLine("Average");
        }
        else
        {
            Console.WriteLine("Tall");
        }
    }
}