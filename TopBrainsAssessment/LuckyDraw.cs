using System;
public class LuckyDraw
{
    public static int DigitSum(long num)
    {
        int sum=0;
        while(num>0)
        {
            sum=sum+(int)(num%10);
            num /= 10;
        }
        return sum;
        
    }
    public static bool IsPrime(int num)
    {
        if(num<=1)
        return false;
        if(num==2)
        return true;
        if(num%2==0) 
        return false;
         
         for(int i=3;i*i<=num;i=i+2)
         {
             if(num%i==0)
             return false;
         }
         return true;
    }
    public static int CountLuckyNumber(int m, int n)
    {
        int count = 0;

        for (int x = m; x <= n; x++)
        {
            if (!IsPrime(x))
            {
                int s1 = DigitSum(x);
                int s2 = DigitSum((long)x * x);

                if (s2 == s1 * s1)
                {
                    count++;
                }
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        int m=20;
        int n=30;
        
        int result=CountLuckyNumber(m, n);
        Console.WriteLine(result);
    }
}