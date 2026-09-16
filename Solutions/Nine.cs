using System;
using System.Collections.Generic;
using System.Text;

namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Nine
{
    public static void Solve()
    {
        Console.Write("how much do you weigh? (in kg) ");
        float kg = float.Parse(Console.ReadLine()!);

        Console.Write("how tall are you? (in cm) ");
        float cm = float.Parse(Console.ReadLine()!);
        float m = cm / 100;

        Console.WriteLine($"Your BMI is {kg / (m*m)}");
    }
}
