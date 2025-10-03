namespace _05.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        private static int GetSumOfEvenDigits(int num) // 12345
        {
            int sum = 0;

            while(num > 0)
            {
                int lastDigit = num % 10;

                if (lastDigit % 2 == 0) // търсим само четни цифри
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }

        private static int GetSumOfOddDigits(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                int lastDigit = num % 10;

                if (lastDigit % 2 != 0) // търсим само нечетни цифри
                {
                    sum += lastDigit;
                }

                num /= 10;
            }

            return sum;
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);

            return result;
        }
    }
}
