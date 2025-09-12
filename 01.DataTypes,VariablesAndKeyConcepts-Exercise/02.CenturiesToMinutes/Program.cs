// Input
int centuries = int.Parse(Console.ReadLine());

// Calculations
int years = centuries * 100;
int days = (int)(years * 365.2422); // кастваме към тип integer и губим остатъка от резултата
int hours = days * 24;
int minutes = hours * 60;

// Output
Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");



