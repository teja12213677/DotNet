// See https://aka.ms/new-console-template for more information
using System;
class AreaOfCircle{
    public static double Calculate(double radius){
        double area=Math.PI*radius*radius;
        area=Math.Round(area,2,MidpointRounding.AwayFromZero);
        return area;
    }
    
    public static void Main(){
        double r=5;
        double result=Calculate(r);
        Console.WriteLine(result);
        
        
    }
}
