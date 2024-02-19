using System;
using System.Text.RegularExpressions;

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Mata in registeringsnummer:");
        string inmatning = Console.ReadLine();
        if (GiltigtRegistreringsnummer(inmatning))
        {
            Console.WriteLine("Ja");
        }
        else
        {
            Console.WriteLine("Nej");
        }
    }
    static bool GiltigtRegistreringsnummer(string regNr)
    {
        if (regNr.Length != 6)
        {
            return false;
        }
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsUpper(regNr[i]))
            {
                return false;
            }
        }
        for (int i = 3; i < 6; i++)
        {
            if (!char.IsDigit(regNr[i]))
            {
                return false;
            }
        }
        return true;
    }
    }