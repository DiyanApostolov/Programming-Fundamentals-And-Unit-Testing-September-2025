// Method
int PrintVowelsCount(string text)
{
    int counter = 0;

    for (int i = 0; i < text.Length; i++)
    {
        char letter = text[i];

        switch (letter)
        {
            case 'a' or 'o' or 'i' or 'u' or 'e':
            case 'A' or 'O' or 'I' or 'U' or 'E':
                counter++;
                break;
        }
    }

    return counter;
}

// Input
string input = Console.ReadLine();

//Output
int result = PrintVowelsCount(input);
Console.WriteLine(result);





