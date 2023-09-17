/***************************************************************
* Name        : BillTipTaxDeters
* Author      : River Deters
* Created     : 05/29/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Add together the total of two meals and two desserts, then calculating the subtotal, tax (7%), tip (20%), total, and total per person.
*               Input: Meals 1 and 2, desserts 1 and 2
*               Output: The subtotal, tax, tip, total, and total per person
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

const decimal TAX_RATE = 0.07m;
const decimal TIP_PERCENTAGE = 0.20m;
const int numOfPeople = 2;
decimal firstMeal = 0;
decimal secondMeal = 0;
decimal firstDessert = 0;
decimal secondDessert = 0;

Console.WriteLine("Please enter the price for meal one: ");
try
{
    firstMeal = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the price of meal one.");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Please enter the price for meal two: ");
try
{
    secondMeal = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the price of meal two.");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Please enter the price for dessert one: ");
try
{
    firstDessert = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the price of dessert one.");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Please enter the price for dessert two: ");
try
{
    secondDessert = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the price of dessert two.");
    Console.WriteLine(e.Message);
}

decimal subtotal = firstMeal + secondMeal + firstDessert + secondDessert;
decimal tax = subtotal * TAX_RATE;
decimal tip = subtotal * TIP_PERCENTAGE;
decimal total = subtotal + tax + tip;
decimal totalPerPerson = total / numOfPeople;

Console.WriteLine("Subtotal: {0:C}", subtotal);
Console.WriteLine("Tax: {0:C}", tax);
Console.WriteLine("Tip: {0:C}", tip);
Console.WriteLine("Total: {0:C}", total);
Console.WriteLine("Total per person: {0:C}", totalPerPerson);
