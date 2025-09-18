
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

double result = 0;

if (operation == "+")
{
    result = firstNumber + secondNumber;
}
else if (operation == "-")
{
    result = firstNumber - secondNumber;
}
else if (operation == "*")
{
    result = firstNumber * secondNumber;
}
else if (operation == "/")
{
    result = firstNumber / secondNumber;
}

Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");