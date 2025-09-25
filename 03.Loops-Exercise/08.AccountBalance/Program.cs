
string input = Console.ReadLine();

double bankAccount = 0;

while (input != "End")
{
    double currentAmount = double.Parse(input);

    if (currentAmount > 0)
    {
        bankAccount += currentAmount;
        Console.WriteLine($"Increase: {currentAmount:F2}");
    }
    else
    {
        bankAccount -= Math.Abs(currentAmount);
        Console.WriteLine($"Decrease: {Math.Abs(currentAmount):F2}");
    }

    input = Console.ReadLine();
}

Console.WriteLine($"Balance: {bankAccount:F2}");