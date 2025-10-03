
namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (CheckPasswordLengthMustBetweenSixAndTenCharacters(password) &&
                CheckPasswordContainsOnlyLettersAndDigits(password) &&
                CheckPasswordContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

            if (!CheckPasswordLengthMustBetweenSixAndTenCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckPasswordContainsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!CheckPasswordContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool CheckPasswordLengthMustBetweenSixAndTenCharacters(string pass)
        {
            if (pass.Length >= 6 && pass.Length <= 10)
            {
                return true;
            }

            return false;
        }

        private static bool CheckPasswordContainsOnlyLettersAndDigits(string pass)
        {
            for (int i = 0; i < pass.Length; i++)
            {
                char symbol = pass[i];

                if (!char.IsLetter(symbol) && !char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckPasswordContainsAtLeastTwoDigits(string pass)
        {
            int counter = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                char symbol = pass[i];

                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
