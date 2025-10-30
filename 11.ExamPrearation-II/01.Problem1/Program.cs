
int n = int.Parse(Console.ReadLine());

if(n == 1) // само в този случай, ще имам изход "no"
{
    Console.WriteLine("no");
}

for (int number = 1; number <= n; number++)
{
    int currentNumber = number; // в нова променлива си вадим числото за обработка

    bool isAllDigitsPrime = true; // търсим дали всички цифри в числото са прости

    int sumAllDigits = 0; // сумираме всички цифри от числото

    while(currentNumber > 0)
    {
        int lastDigit = currentNumber % 10; // взимаме последната цифра от числото 
        sumAllDigits += lastDigit;

        if(IsPrime(lastDigit) == false)
        {
            isAllDigitsPrime = false;
            break;
        }

        currentNumber /= 10; // премахваме последната цифра от числото
    }

    // тук проверяваме дали числото е специално според двете условия
    if(isAllDigitsPrime == true && sumAllDigits % 2 == 0)
    {
        Console.Write(number + " ");
    }
}

// метод, който проверява дали едно число е просто
static bool IsPrime(int number)
{
    int counter = 0; // брояч на делителите без остатък

    for (int i = 1; i <= number; i++)
    {
        if(number % i == 0)
        {
            counter++;
        }
    }

    return counter == 2;
    // ако има само два делителя без остатък, значи числото е просто
    // ако има повече от два два делителя без остатък, числото не е просто
}