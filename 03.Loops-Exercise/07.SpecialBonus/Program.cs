
int stopNumber = int.Parse(Console.ReadLine());

int lastNumber = 0;

int currentNumber = int.Parse(Console.ReadLine());

while (currentNumber != stopNumber)
{
    lastNumber = currentNumber;

    currentNumber = int.Parse(Console.ReadLine());
}

double result = lastNumber * 1.2; // +20%

Console.WriteLine(result);