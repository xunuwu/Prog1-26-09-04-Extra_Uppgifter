namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Fifteen
{
    public static void Solve()
    {
        Console.Write("input a temperature in fahrenheit: ");
        double temperature = double.Parse(Console.ReadLine()!);

        string state = temperature switch
        {
            var x when x <= 32 => "freezing",
            var x when x >= 212 => "boiling",
            _ => "between freezing and boiling",
        };

        Console.WriteLine($"water would be {state}");
    }
}
