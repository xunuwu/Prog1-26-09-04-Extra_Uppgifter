using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Five
{
    public static void Solve()
    {
        Console.Write("input 3 numbers separated by spaces: ");

        int[] input = [.. Console.ReadLine()!.Split(' ').Select(x => int.Parse(x.Trim()))];
        Console.WriteLine($"the largest number is: {input.Max()}");
        Console.WriteLine($"the smallest number is: {input.Min()}");
    }
}
