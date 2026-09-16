using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Six
{
    public static void Solve()
    {
        Console.Write("input a number: ");
        int input = int.Parse(Console.ReadLine()!);

        // idk how to actually check this efficiently :p
        // thankfully the int32 max isnt that big
        bool isPrime = true;
        for (int i = 2; i < input; i++)
        {
            if (int.DivRem(input, i).Remainder == 0)
            {
                isPrime = false;
                Console.WriteLine(i);
                break;
            }
        }

        Console.WriteLine($"your number {(isPrime ? "is" : "is not")} a prime");
    }
}