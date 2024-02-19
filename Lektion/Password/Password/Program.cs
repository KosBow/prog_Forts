using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your password:");
        string typePassword = Console.ReadLine();

        while (typePassword != null) { 

        if (isValidPassword(typePassword))
        {
            Console.WriteLine("Correct password");
        }
        else
        {
            Console.WriteLine("Invalid password");
        }

        Console.ReadLine();
    }
    static bool isValidPassword(string typePassword)
    {
        // Kontrollera längd
        if (typePassword.Length < 8)
            return false;

        // Kontrollera stora och små bokstäver samt specialtecken
        if (!Regex.IsMatch(typePassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z0-9]).{8,}$"))
            return false;

        // Kontrollera förbjudna delar
        if (Regex.IsMatch(typePassword, @"(?i)hej|lösen|hopp"))
            return false;

        return true;
        }
    }
}