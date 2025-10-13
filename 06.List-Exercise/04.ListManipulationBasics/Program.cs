
List<int> numbers = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

string[] input = Console.ReadLine().Split(' ');

while (input[0] != "end")
{
    string command = input[0];

    if (command == "Add")
    {
        numbers.Add(int.Parse(input[1])); // на един ред правим Parse и Add
    }
    else if (command == "Remove")
    {
        numbers.Remove(int.Parse(input[1])); // на един ред правим Parse и Remove
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(input[1]);
        numbers.RemoveAt(index); // премахваме елемента на дадения индекс
    }
    else if (command == "Insert")
    {
        int numberToAdd = int.Parse(input[1]);
        int index = int.Parse(input[2]);

        numbers.Insert(index, numberToAdd); // добавям елемент на конкретен индекс
    }

    input = Console.ReadLine().Split(' ');
}

Console.WriteLine(string.Join(' ', numbers));
