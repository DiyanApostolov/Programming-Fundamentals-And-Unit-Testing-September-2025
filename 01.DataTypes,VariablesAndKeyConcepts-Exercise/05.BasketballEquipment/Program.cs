// Input
int basketballFeePerYear = int.Parse(Console.ReadLine());

// Calculations
double priceForSneakers = basketballFeePerYear * 0.6; // -40%
double priceForUniform = priceForSneakers * 0.8;      // -20%
double priceForBall = priceForUniform / 4;            // или * 0.25
double priceForAccessories = priceForBall / 5;        // или * 0.2

double finalPrice = priceForSneakers + priceForUniform + priceForBall + priceForAccessories + basketballFeePerYear;

// Output
Console.WriteLine(finalPrice);
