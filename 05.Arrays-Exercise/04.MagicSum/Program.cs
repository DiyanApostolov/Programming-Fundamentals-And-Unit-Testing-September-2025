// Input
int[] numbers = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

int contorlNumber = int.Parse(Console.ReadLine());

// Calculations + Output
for (int i = 0; i < numbers.Length - 1; i++) // искам да спра на предпоследния елемент
{
    int currentNumber = numbers[i];

    for (int j = i + 1; j < numbers.Length; j++)
    {
        int nextRigthNumber = numbers[j];

        if(currentNumber + nextRigthNumber == contorlNumber)
        {
            Console.WriteLine($"{currentNumber} {nextRigthNumber}");
            break;
        }
    }
}
