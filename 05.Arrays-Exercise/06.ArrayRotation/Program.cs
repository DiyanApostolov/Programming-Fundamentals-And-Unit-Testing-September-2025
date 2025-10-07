// Input
int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

int rotations = int.Parse(Console.ReadLine());

// Calculations
rotations = rotations % numbers.Length; // оптимизира (намаля) излишните итерации

for (int i = 0; i < rotations; i++)
{
    int firstElement = numbers[0]; // пазим си първия елемент

    for (int j = 1; j < numbers.Length; j++)
    {
        numbers[j - 1] = numbers[j]; // местим всеки един елемент с един индекс на ляво
    }

    numbers[numbers.Length - 1] = firstElement; // заместваме последния елемент с първия
}

// Output
Console.WriteLine(string.Join(' ', numbers));