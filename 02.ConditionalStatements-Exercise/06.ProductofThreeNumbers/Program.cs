
double firstNumber = double.Parse(Console.ReadLine());
double secondNumber = double.Parse(Console.ReadLine());
double thirdNumber = double.Parse(Console.ReadLine());

if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
{
    Console.WriteLine("zero");
}
else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
{
    Console.WriteLine("positive");
}
else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
{
    Console.WriteLine("negative");
}
else if (firstNumber < 0)
{
    if (secondNumber < 0 && thirdNumber > 0)
    {
        Console.WriteLine("positive");
    }
    else if (secondNumber > 0 && thirdNumber < 0)
    {
        Console.WriteLine("positive");
    }
}
else if (secondNumber < 0 && thirdNumber < 0)
{
    Console.WriteLine("positive");
}
else if (secondNumber < 0 && thirdNumber > 0)
{
    Console.WriteLine("negative");
}
else if (secondNumber > 0 && thirdNumber < 0)
{
    Console.WriteLine("negative");
}