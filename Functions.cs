using System;
class Functions
{
     public int Sum(int x,int y)
        {
            return x+y;
        }
     public int Subtract(int x,int y)
        {
            return x-y;
        }
    public int Multiply(int x,int y)
    {
        return x*y;
    }
    
    public int Division(int x,int y)
    {
        if (x>y)
        {
            return x/y;
        }
        else
        {
            return y/x;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the First Number:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        Functions F = new Functions();
        int sum = F.Sum(n1, n2);
        int subtract = F.Subtract(n1, n2);
        int multiply = F.Multiply(n1, n2);
        int division = F.Division(n1, n2);
        
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Subtract: {subtract}");
        Console.WriteLine($"Multiply: {multiply}");
        Console.WriteLine($"Division: {division}");
    }
}
