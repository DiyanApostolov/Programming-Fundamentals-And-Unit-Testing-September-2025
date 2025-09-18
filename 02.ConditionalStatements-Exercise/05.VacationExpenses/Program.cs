
string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());

double discount = 0;
double pricePerDay = 0;

if (season == "Spring")
{
    discount = 0.2; // 20%

    if (accommodationType == "Hotel")
    {
        pricePerDay = 30;
    }
    else if (accommodationType == "Camping")
    {
        pricePerDay = 10;
    }
}
else if (season == "Summer")
{
    if (accommodationType == "Hotel")
    {
        pricePerDay = 50;
    }
    else if (accommodationType == "Camping")
    {
        pricePerDay = 30;
    }
}
else if (season == "Autumn")
{
    discount = 0.3; // 30%

    if (accommodationType == "Hotel")
    {
        pricePerDay = 20;
    }
    else if (accommodationType == "Camping")
    {
        pricePerDay = 15;
    }
}
else if (season == "Winter")
{
    discount = 0.1; // 10%

    if (accommodationType == "Hotel")
    {
        pricePerDay = 40;
    }
    else if (accommodationType == "Camping")
    {
        pricePerDay = 10;
    }
}

double priceForAllDays = countOfDays * pricePerDay;
double finalDiscount = priceForAllDays * discount;
double finalPrice = priceForAllDays - finalDiscount;

Console.WriteLine($"{finalPrice:F2}");
