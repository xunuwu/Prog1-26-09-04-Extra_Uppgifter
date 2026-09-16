using Prog1_26_09_04_Extra_Uppgifter.Solutions;

namespace Prog1_26_09_04_Extra_Uppgifter;
internal class Program
{
    static void Main(string[] args)
    {
        Action[] solutions = [
            One.Solve,
            Two.Solve,
            Three.Solve,
            Four.Solve,
            Five.Solve,
            Six.Solve,
            Seven.Solve,
            Eight.Solve,
            Nine.Solve,
            Ten.Solve,
            Eleven.Solve,
            Twelve.Solve,
            Thirteen.Solve,
            Fourteen.Solve,
            Fifteen.Solve
        ];

        Console.Write($"enter a number between 1 and 15 to run the corresponding solution: ");
        int input = int.Parse(Console.ReadLine()!);
        solutions[input - 1]();
    }
}