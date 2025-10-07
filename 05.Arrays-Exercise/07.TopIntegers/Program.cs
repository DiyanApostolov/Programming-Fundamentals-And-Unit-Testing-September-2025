// Input
int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

// Calculations + Output
for (int i = 0; i < numbers.Length; i++)
{
    // взимаме текущото число
    int currentElement = numbers[i];

    // приемаме по подразбиране, че текущото числ е по-голямо от всички на дясно
    bool isBigger = true;

    // започваме да взимаме от следващото число на дясно до края на масива
    for (int j = i + 1; j < numbers.Length; j++)
    {
        int nextRigthElement = numbers[j];

        if (currentElement <= nextRigthElement) // проверявам дали не е по-малко от някое число на дясно
        {
            isBigger = false; // не е по-голямо от всички на дясно
            break;
        }
    }

    // Output
    if (isBigger)
    {
        Console.Write(currentElement + " ");
    }
}

