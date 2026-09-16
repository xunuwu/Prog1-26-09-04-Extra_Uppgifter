namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;
internal class One
{
    public static void Solve()
    {
        // this has no error handling whatsoever :P

        Console.Write("input a number: ");
        int first = int.Parse(Console.ReadLine()!);

        Console.Write("input another number: ");
        int second = int.Parse(Console.ReadLine()!);

        (first, second) = (second, first);

        Console.WriteLine($"first: {first}. second: {second}");
    }
}
