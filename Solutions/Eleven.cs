using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Eleven
{
    public static void Solve()
    {
        // just doing this the boring way
        string input = Console.ReadLine()!;
        Console.WriteLine($"Your number is{(input.Reverse().SequenceEqual(input) ? "" : " not")} a palindrome");
    }
}
