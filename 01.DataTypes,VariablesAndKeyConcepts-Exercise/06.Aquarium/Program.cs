// Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentOccupiedSpace = double.Parse(Console.ReadLine());

// Calculations
double allAmountInLiters = length * width * height / 1000.0; // деля на double стойност!!!
double neededLiters = allAmountInLiters * (1 - percentOccupiedSpace / 100);

// Output
Console.WriteLine($"{neededLiters:F2}");


