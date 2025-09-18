
int firstAthleteTime = int.Parse(Console.ReadLine());
int secondAthleteTime = int.Parse(Console.ReadLine());
int thirdAthleteTime = int.Parse(Console.ReadLine());

int sumTimes = firstAthleteTime + secondAthleteTime + thirdAthleteTime;

int minutes = sumTimes / 60;
int seconds = sumTimes % 60;

if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}
