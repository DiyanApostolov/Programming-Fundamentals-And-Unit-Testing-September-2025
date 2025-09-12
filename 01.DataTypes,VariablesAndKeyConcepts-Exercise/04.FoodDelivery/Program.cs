// Input
int numberOfChickenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

// Calculations
double priceForOneChickenMenu = 10.35;
double priceForOneFishMenu = 12.40;
double priceForOneVegetarianMenu = 8.15;
double deliveryPrice = 2.50;

double priceForAllChickenMenus = numberOfChickenMenus * priceForOneChickenMenu;
double priceForAllFishMenus = numberOfFishMenus * priceForOneFishMenu;
double priceForAllVegetarianMenus = numberOfVegetarianMenus * priceForOneVegetarianMenu;
double orderPrice = priceForAllChickenMenus + priceForAllFishMenus + priceForAllVegetarianMenus;

double dessertPrice = orderPrice * 0.2;

double finalPrice = orderPrice + dessertPrice + deliveryPrice;

// Output
Console.WriteLine(finalPrice);