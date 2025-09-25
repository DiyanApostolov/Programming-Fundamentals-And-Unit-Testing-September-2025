
int n = int.Parse(Console.ReadLine());

int counterFor2 = 0;
int counterFor3 = 0;
int counterFor4 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (currentNumber % 2 == 0)
    {
        counterFor2++;
    }

    if (currentNumber % 3 == 0)
    {
        counterFor3++;
    }

    if (currentNumber % 4 == 0)
    {
        counterFor4++;
    }
}

double percentFor2 = (double)counterFor2 / n * 100;
double percentFor3 = (double)counterFor3 / n * 100;
double percentFor4 = (double)counterFor4 / n * 100;

Console.WriteLine($"{percentFor2:F2}%");
Console.WriteLine($"{percentFor3:F2}%");
Console.WriteLine($"{percentFor4:F2}%");
