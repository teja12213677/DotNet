using System;
public class SumUntilZero{
    public static int Sum(int[] nums){
        int sum=0;
        foreach(int num in nums)
        {
            if(num==0)
            
            break;
            if(num<0)
            continue;
            
            sum=sum+num;
        }
        return sum;
        
    }
    public static void Main(){
        int[] nums={5,-2,45,67,0,7};
        
        Console.WriteLine(Sum(nums));
    }
    
    
}