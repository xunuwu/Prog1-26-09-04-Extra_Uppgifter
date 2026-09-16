namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Four
{
    public static void Solve()
    {
        Console.Write("input your name: ");
        string name = Console.ReadLine()!;


        Console.Write("input your age: ");
        int age = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"You ({name}) will be {age + 10} years old in 10 years");
    }
}
