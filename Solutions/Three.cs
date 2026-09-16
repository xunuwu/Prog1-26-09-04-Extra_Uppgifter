namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Three
{
    public static void Solve()
    {
        // no error handling :D

        Console.Write("input a number: ");
        int input = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"your number is {(input << sizeof(int) * 8 - 1 == 0 ? "even" : "odd")}");
    }
}
