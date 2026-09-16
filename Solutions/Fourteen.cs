namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Fourteen
{
    public static void Solve()
    {
        Console.Write("input a password: ");
        string password = Console.ReadLine()!;

        bool containsNumber = password.Any(char.IsNumber);
        bool containsCapitalLetter = password.Any(char.IsUpper);
        bool isEightCharactersLong = password.Length >= 8;

        Console.WriteLine($"Your password {(containsNumber && containsCapitalLetter && isEightCharactersLong ? "passed" : "failed")} the criteria");
    }
}
