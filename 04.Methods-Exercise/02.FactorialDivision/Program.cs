// Method
int FindFactorial(int x)
{
    int factorial = 1;

    for (int i = 1; i <= x; i++)
    {
        factorial *= i;
    }

    return factorial;
}

// Input
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

// Calculations
int firstFactorial = FindFactorial(firstNumber);
int secondFactorial = FindFactorial(secondNumber);

int result = firstFactorial / secondFactorial;

//Output
Console.WriteLine(result);