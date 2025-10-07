// Input
int n = int.Parse(Console.ReadLine());

// Calculations
int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    // Input
    int[] rowData = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

    if(i % 2 == 0)
    {
        firstArray[i] = rowData[0]; // пращаме първото число в първия масив
        secondArray[i] = rowData[1]; // пращаме второто число във втория масив
    }
    else
    {
        firstArray[i] = rowData[1]; // пращаме второто число в първия масив
        secondArray[i] = rowData[0]; // пращаме първото число във втория масия
    }
}

// Output
Console.WriteLine(string.Join(' ', firstArray));
Console.WriteLine(string.Join(' ', secondArray));
