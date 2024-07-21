using System;
class ArithmeticOperators
{
     public int Increment(int x,int y)
        {
            return x+=y;
        }
    public int Decrement(int x,int y)
        {
            if (x>y)
        {
            return x-=y;
        }
        else
        {
            return y-=x;
        }
    public int Multiply(int x,int y)
    {
        return x*=y;
    }
    
    public int Division(int x,int y)
    {
        if (x>y)
        {
            return x/=y;
        }
        else
        {
            return y/=x;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the First Number:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        ArithmeticOperators A = new ArithmeticOperators();
        int increment = A.Increment(n1, n2);
        int decrement = A.Decrement(n1, n2);
        int multiply = A.Multiply(n1, n2);
        int division = A.Division(n1, n2);
        
        Console.WriteLine($"Increment: {increment}");
        Console.WriteLine($"Decrement: {decrement}");
        Console.WriteLine($"Multiply: {multiply}");
        Console.WriteLine($"Division: {division}");
    }
}