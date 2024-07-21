using System;

public class StringsClass
{
    public static void Main(string[] args)
    {
        string fullName = "Bro Code";
        string phoneNumber = "123-456-7890";
        
        string userName = fullName.Insert(0, "Mr. ");
        fullName = fullName.ToUpper();
        phoneNumber = phoneNumber.Replace("-", "");
        
        Console.WriteLine($"Phone number without dashes: {phoneNumber}");
        Console.WriteLine($"Full name in uppercase: {fullName}");
        Console.WriteLine($"Username with title: {userName}");
        Console.WriteLine($"Length of full name: {fullName.Length}");
        
        string firstName = fullName.Substring(0, 3);
        string lastName = fullName.Substring(4, 4);
        
        Console.WriteLine($"First name extracted: {firstName}");
        Console.WriteLine($"Last name extracted: {lastName}");
    }
}
