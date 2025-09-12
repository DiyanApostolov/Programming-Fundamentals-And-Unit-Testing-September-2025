// Input
int amountOfNylon = int.Parse(Console.ReadLine());
int amountOfPaint = int.Parse(Console.ReadLine());
int amountOfThinner = int.Parse(Console.ReadLine());
int hoursNeededForWork  = int.Parse(Console.ReadLine());

// Calculations
double nylonPricePerSquareMeter = 1.50;
double paintPricePerLiter = 14.50;
double thinnerPricePerLiter = 5;
double bagsPrice = 0.40;

double nylonPrice = (amountOfNylon + 2) * nylonPricePerSquareMeter;
double paintPrice = amountOfPaint * 1.1 * paintPricePerLiter; // * 1.1 => + 10%
double thinnerPrice = amountOfThinner * thinnerPricePerLiter;

double allMaterialsPrice = nylonPrice + paintPrice + thinnerPrice + bagsPrice;

double priceForOneHourWork = allMaterialsPrice * 0.3;
double workPrice = hoursNeededForWork * priceForOneHourWork;

double finalPrice = allMaterialsPrice + workPrice;

// Output
Console.WriteLine(finalPrice);

