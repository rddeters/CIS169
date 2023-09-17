/***************************************************************
* Name        : DaysOfTheWeek
* Author      : River Deters
* Created     : 06/03/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Creating a program that allows the user to input and then the program will output the corresponding day. The program will use a switch statement and valid user input.
*               Input: Integer day
*               Output: The corresponding day of the week
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System;

namespace DaysOfTheWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = "None";
            int dayInt;

            Console.WriteLine("Enter a number (1-7) to display a day of the week:");

            if (!int.TryParse(Console.ReadLine(), out dayInt) || dayInt < 1 || dayInt > 7)
            {
                Console.WriteLine("Invalid input. Now exiting the program!");
                return;
            }

            switch (dayInt)
            {
                case 1:
                    dayOfWeek = "Monday";
                    break;
                case 2:
                    dayOfWeek = "Tuesday";
                    break;
                case 3:
                    dayOfWeek = "Wednesday";
                    break;
                case 4:
                    dayOfWeek = "Thursday";
                    break;
                case 5:
                    dayOfWeek = "Friday";
                    break;
                case 6:
                    dayOfWeek = "Saturday";
                    break;
                case 7:
                    dayOfWeek = "Sunday";
                    break;
                default:
                    dayOfWeek = "Invalid choice";
                    break;
            }

            Console.WriteLine("The day that you chose is " + dayOfWeek + "!");
        }
    }
}