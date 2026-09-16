using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Seven
{
    public static void Solve()
    {
        Console.Write("what is the temperature in celsius? ");
        double c = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"It is {c * 9/5 + 32} fahrenheit and {c + 273.15} kelvin");
    }
}
