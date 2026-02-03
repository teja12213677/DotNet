// See https://aka.ms/new-console-template for more information
using System;

class MultiplicationRow
{
    static void Main()
    {
       
        Console.Write("Enter n value: ");
        
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the value of upto: ");
        int upto = int.Parse(Console.ReadLine());

        int[] row = GetMultiplicationRow(n, upto);

        Console.Write("[");
        for (int i = 0; i < row.Length; i++)
        {
            Console.Write(row[i]);
            if (i < row.Length - 1)
                Console.Write(",");
        }
        Console.Write("]");
    }

    static int[] GetMultiplicationRow(int n, int upto)
    {
        int[] result = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            result[i - 1] = n * i;
        }

        return result;
    }
}
