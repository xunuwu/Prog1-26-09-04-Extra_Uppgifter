namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Two
{
    public static void Solve()
    {
        // dates are terrible
        // im just gonna assume that their birthday is the current month
        // to avoid leap years, etc

        Console.Write("what is the current day of the month (ex. 12)? ");
        int currentDay = int.Parse(Console.ReadLine()!);
        Console.Write("what day this month is your birthday? ");
        int birthDay = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"your birthday is in {birthDay - currentDay} days!");
    }
}