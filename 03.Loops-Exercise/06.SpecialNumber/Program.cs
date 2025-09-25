
int number = int.Parse(Console.ReadLine());

int copyNumber = number;
bool isSpecial = true;

while (copyNumber > 0)
{
    int lastDigit = copyNumber % 10; // -> взимам последната цифра от числото

    if (number % lastDigit != 0)
    {
        isSpecial = false; // отбелязвам си, че числото не е специално
        break; // прекъсвам цикъла преждевременно
    }

    copyNumber /= 10; // -> премахвам последната цифра от числото
}

if (isSpecial)
{
    Console.WriteLine($"{number} is special");
}
else
{
    Console.WriteLine($"{number} is not special");
}