using System;

public class MathClass
{
    public static void Main(string[] args)
    {
        double n = 3.14;
        double n1 = Math.Pow(n, 3);
        double n2 = Math.Sqrt(n);
        double n3 = Math.Abs(n);
        double n4 = Math.Round(n);
        double n5 = Math.Ceiling(n);
        double n6 = Math.Floor(n);
        double n7 = Math.Max(n5, n6);
        double n8 = Math.Min(n5, n6);

        Console.WriteLine($"n^3: {n1}");
        Console.WriteLine($"Square root of n: {n2}");
        Console.WriteLine($"Absolute value of n: {n3}");
        Console.WriteLine($"Rounded value of n: {n4}");
        Console.WriteLine($"Ceiling value of n: {n5}");
        Console.WriteLine($"Floor value of n: {n6}");
        Console.WriteLine($"Maximum of ceiling and floor: {n7}");
        Console.WriteLine($"Minimum of ceiling and floor: {n8}");
    }
}
