
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string[] input = Console.ReadLine().Split(' ');

while (input[0] != "End")
{
    string command = input[0];

    if(command == "Add")
    {
        int numberToAdd = int.Parse(input[1]);
        numbers.Add(numberToAdd);
    }
    else if (command == "Insert")
    {
        int numberToInsert = int.Parse(input[1]);
        int index = int.Parse(input[2]);

        if(index < 0 || index >= numbers.Count) // проверяваме дали индекса е валиден
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(index, numberToInsert); // вкарвам елемент на конкретен индекс
        }
    }
    else if (command == "Remove")
    {
        int index = int.Parse(input[1]);

        if (index < 0 || index >= numbers.Count) // проверяваме дали индекса е валиден
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(index); // премахваме елемент по индекс
        }

    }
    else if (command == "Shift")
    {
        string direction = input[1];
        int count = int.Parse(input[2]);

        if (direction == "left")
        {
            for (int i = 0; i < count; i++)
            {
                int firstElement = numbers[0]; // запазвам си стойността на първия елемент
                numbers.RemoveAt(0);           // премагхвам първият елемент (по индекс)
                numbers.Add(firstElement);     // добавям първият елемент като последен
            }
        }
        else if (direction == "right")
        {
            for (int i = 0; i < count; i++)
            {
                int lastElement = numbers[numbers.Count - 1]; // пазя си последния елемент
                numbers.RemoveAt(numbers.Count - 1); // премахвам последният елемент (по индекс)
                numbers.Insert(0, lastElement);  // добавям последният елемент като първи
            }
        }
    }

    input = Console.ReadLine().Split(' ');
}

Console.WriteLine(string.Join(' ', numbers));