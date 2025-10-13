
List<int> filed = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToList();

int[] bombInfo = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();

int bombNumber = bombInfo[0];
int power = bombInfo[1];

while (filed.Contains(bombNumber))
{
    int bombIndex = filed.IndexOf(bombNumber); // мамираме индекса на бомбата

    int startIndex = bombIndex - power;
    int endIndex = bombIndex + power;
        
    if(startIndex < 0) // правя проверка дали съм излязъл от ляво на листа
    {
        startIndex = 0; // задаваме стойност на първия индекс
    }

    if(endIndex >= filed.Count) // правя проверка дали съм излязъл от дясно на листа
    {
        endIndex = filed.Count - 1; // задаваме стойност на последния индекс
    }

    for (int i = startIndex; i <= endIndex; i++)
    {
        filed[i] = 0;
    }
}

int sum = 0;

foreach (var item in filed)
{
    sum += item;
}

Console.WriteLine(sum);