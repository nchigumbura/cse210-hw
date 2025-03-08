using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your Grade percentage?");
       string grade = Console.ReadLine();

       string letter = "";

       int x = int.Parse(grade);

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

       if (x >= 70)
       {
        Console.WriteLine("Congrats you have Passed");
       }
       else
       {
        Console.WriteLine("Better luck nextime Pal");
       }
    }
}