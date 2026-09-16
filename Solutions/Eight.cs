using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Eight
{
    public static void Solve()
    {
        Console.WriteLine("write some words");
        string input = Console.ReadLine()!;
        Console.WriteLine($"you wrote {input.Split(' ').Where(x => !x.IsWhiteSpace()).Count()} words");
    }
}
