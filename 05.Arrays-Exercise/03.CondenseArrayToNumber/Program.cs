// Input
int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

// Calculations
while(numbers.Length > 1)
{
    int[] condensedArray = new int[numbers.Length - 1];

    for (int i = 0; i < numbers.Length - 1; i++) // numbers.Length - 1, спирам до предпоследния елемент
    {
        int sumElements = numbers[i] + numbers[i + 1];
        condensedArray[i] = sumElements;
    }

    numbers = condensedArray;
}

// Output
Console.WriteLine(numbers[0]);
