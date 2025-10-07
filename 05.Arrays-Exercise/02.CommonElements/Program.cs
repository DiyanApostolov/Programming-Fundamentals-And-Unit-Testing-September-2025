// Input
int[] firstArray = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();

int[] secondArray = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToArray();


// Calculations + Output
for (int i = 0; i < firstArray.Length; i++)
{
    int currentElement = firstArray[i];

    for (int j = 0; j < secondArray.Length; j++)
    {
        int currentElementSecondArray = secondArray[j];

        if (currentElement == currentElementSecondArray)
        {
            Console.Write(currentElement + " ");
        }
    }
}

// Второ решение на задача с foreach и метода .Contains()

//foreach (var item in firstArray)
//{
//    if (secondArray.Contains(item))
//    {
//        Console.Write(item + " ");
//    }
//}