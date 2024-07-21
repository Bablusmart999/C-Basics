using System;

public class Hypotenuse
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter side A:");
       Double a = Convert.ToDouble(Console.ReadLine());
       
       Console.WriteLine("Enter side B:");
       Double b = Convert.ToDouble(Console.ReadLine());
       
       Double c = Math.Sqrt((a*a)+(b*b));
       Console.WriteLine("The Hypotenuse is:"+c);
    }
}