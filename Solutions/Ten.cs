using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Ten
{
    public static void Solve()
    {
        Console.Write("enter a digit: ");

        int input = int.Parse(Console.ReadLine()!);

        var max_length = (int)Math.Floor(Math.Log10(input * 9));

        // NOTE crashes on input 0 and misbehaves when the input is negative or if any values extend beyond the i32 cap
        Console.WriteLine(string.Join(
            $"+{new string([.. Enumerable.Repeat('-', max_length + 7)])}+\n",
            ["",
             .. Enumerable.Range(1, 9).Select(x => $"| {x} | {x * input}{new string([.. Enumerable.Repeat(' ', max_length - (int)Math.Floor(Math.Log10(x * input) - 1))])}|\n"),
             ""]));
    }
}