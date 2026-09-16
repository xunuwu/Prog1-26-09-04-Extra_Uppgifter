namespace Prog1_26_09_04_Extra_Uppgifter.Solutions;

internal class Twelve
{
    public static void Solve()
    {
        Console.Write("what is your monthly salary per month? ");
        int monthlySalary = int.Parse(Console.ReadLine()!);
        int annualSalary = monthlySalary * 12;
        Console.WriteLine($"your annual salary is: {annualSalary}");
        Console.WriteLine($"with 30% income tax you would pay {annualSalary * 0.3} annually");
    }
}