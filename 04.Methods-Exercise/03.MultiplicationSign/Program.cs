namespace _03.MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string result = PrintSignOfProductFromThreeNumbers(num1, num2, num3);

            Console.WriteLine(result);
        }

        static public string PrintSignOfProductFromThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                return "zero";
            }
            else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
            {
                return "positive";
            }
            else if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
            {
                return "negative";
            }
            else if (firstNumber < 0)
            {
                if (secondNumber < 0 && thirdNumber > 0)
                {
                    return "positive";
                }
                else if (secondNumber > 0 && thirdNumber < 0)
                {
                    return "positive";
                }
                else
                {
                    return "negative";
                }
            }
            else if (secondNumber < 0 && thirdNumber < 0)
            {
                return "positive";
            }
            else if (secondNumber < 0 && thirdNumber > 0)
            {
                return "negative";
            }
            else 
            {
                return "negative";
            }

        }
    }
}
