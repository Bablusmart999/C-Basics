using System;

public class RandomClass
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        
        int num = random.Next(1, 7);          // Random integer between 1 and 6
        int num1 = random.Next(1, 21);        // Random integer between 1 and 20
        double num2 = random.NextDouble();    // Random double between 0.0 and 1.0
        int num3 = random.Next(1, 7);         // Random integer between 1 and 6
        int num4 = random.Next(1, 7);         // Random integer between 1 and 6

        Console.WriteLine($"Random integer between 1 and 6: {num}");
        Console.WriteLine($"Random integer between 1 and 20: {num1}");
        Console.WriteLine($"Random double between 0.0 and 1.0: {num2}");
        Console.WriteLine($"Random integer between 1 and 6: {num3}");
        Console.WriteLine($"Random integer between 1 and 6: {num4}");
    }
}
