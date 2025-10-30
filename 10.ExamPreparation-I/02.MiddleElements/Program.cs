int[] numbers = Console.ReadLine() //"3 4 6 7 8 9"
                .Split(" ")        //["3", "4", "6", "7", "8", "9"]
                .Select(int.Parse) //[3, 4, 6, 7, 8, 9]
                .ToArray();

//!!!масивът винаги ще бъде с четна дължина!!!

//1. първия среден елемент
int firstMiddleElement = numbers[numbers.Length / 2 - 1];

//2. втория среден елемент
int secondMiddleElement = numbers[numbers.Length / 2];

//3. средноаритметична стойност
double average = (firstMiddleElement + secondMiddleElement) / 2.0;

Console.WriteLine($"{average:F2}");