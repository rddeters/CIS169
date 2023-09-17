/***************************************************************
* Name        : ExceptionHandling
* Author      : River Deters
* Created     : 05/29/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Allow the user to input the number of cupcakes and people attending a party, with exception handling, to calculate the number of cupcakes per person.
*               Input: Number of cupcakes, number of people
*               Output: Number of cupcakes per person
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

int numOfPeople = 0;
int numOfCupcakes = 0;
int cupcakesPerPerson = 0;
int remainderOfCupcakes = 0;

Console.WriteLine("Please enter the number of people invited to your birthday (or unbirthday party!): ");
try
{
    numOfPeople = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the number of people attending the party.");
    Console.WriteLine(e.Message);
}

Console.WriteLine("Please enter the number of cupcakes that have been ordered: ");
try
{ 
    numOfCupcakes = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException e)
{
    Console.WriteLine("Error reading the number of cupcakes that that have been ordered.");
    Console.WriteLine(e.Message);
}

cupcakesPerPerson = numOfCupcakes / numOfPeople;
remainderOfCupcakes =  numOfCupcakes % numOfPeople;

Console.WriteLine("Happy (UN)Birthday to me!");
Console.WriteLine("You may have up to " + cupcakesPerPerson + " cupcakes :)");
Console.WriteLine("There will be " + remainderOfCupcakes + " extra for me!");