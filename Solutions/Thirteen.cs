namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Thirteen
{
    public static void Solve()
    {
        Console.Write("input the first number: ");
        int first = int.Parse(Console.ReadLine()!);

        Console.Write("input the last number: ");
        int last = int.Parse(Console.ReadLine()!);

        foreach (int num in Enumerable.Range(first, last - first + 1))
        {
            Console.WriteLine(num);
        }
    }
}
