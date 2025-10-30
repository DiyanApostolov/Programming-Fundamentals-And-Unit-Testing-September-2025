int number = int.Parse(Console.ReadLine());

int sum = 0; //сума от факториелите на четните цифри от въведеното число

//1. премина през всички цифри на числото
//number > 0 -> има цифри в него
//number <= 0 -> нямаме повече цифри
while (number > 0)
{
    //1. последната цифра
    int lastDigit = number % 10;

    //2. проверяваме дали е четна -> намираме факториел -> сумираме
    if (lastDigit % 2 == 0)
    {
        //lastDigit = 4 -> 4! = 1 * 2 * 3 * 4 = 24
        int fact = 1;
        for (int i = 1; i <= lastDigit; i++)
        {
            fact *= i; //fact = fact * i;
        }
        sum += fact;
    }

    //3. премахвам последната цифра
    number /= 10; //number = number / 10;
}

Console.WriteLine(sum);

