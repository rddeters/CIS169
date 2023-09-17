/***************************************************************
* Name        : JaggedArrays
* Author      : River Deters
* Created     : 06/12/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Create a jagged array with distance between cities in the UK and then creating a Min method and a Max function to find the farthest and shortest travelling distance.
*               Input: No user input
*               Output: The farthest/shortest travelling distance for the requested city.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/


using System;

namespace JaggedArrays
{
    internal class JaggedArrays
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;
            string[] cityList = { "Edinburgh", "Birmingham", "Cardiff",
                "Dover", "Leeds", "Liverpool", "London", "Manchester",
                "Newcastle", "York" };

            int[][] mileageTable = new int[SIZE][];

            mileageTable[0] = new int[] { 0 };
            mileageTable[1] = new int[] { 290 };
            mileageTable[2] = new int[] { 373, 102 };
            mileageTable[3] = new int[] { 496, 185, 110 };
            mileageTable[4] = new int[] { 193, 118, 165, 270 };
            mileageTable[5] = new int[] { 214, 90, 165, 270, 73 };
            mileageTable[6] = new int[] { 412, 118, 150, 81, 191, 198 };
            mileageTable[7] = new int[] { 222, 86, 173, 285, 41, 34, 201 };
            mileageTable[8] = new int[] { 112, 2017, 301, 360, 94, 155, 288, 141 };
            mileageTable[9] = new int[] { 186, 129, 231, 264, 25, 97, 194, 66, 82 };

            Console.WriteLine("\nPrinting the jagged array:");
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < mileageTable[i].Length; j++)
                {
                    Console.Write(mileageTable[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // Find the closest mileage to Manchester
            int manchesterIndex = Array.IndexOf(cityList, "Manchester");
            int[] manchesterArray = mileageTable[manchesterIndex];
            int closestMileage = Min(manchesterArray);
            Console.WriteLine("The closest mileage to Manchester is: " + closestMileage + " miles");

            // Find the farthest mileage
            int farthestMileage = Max(manchesterArray);
            Console.WriteLine("The farthest mileage to Manchester is: " + farthestMileage + " miles");

            // Not needed for the assignment but testing anyway to find the closest mileage to York
            int YorkIndex = Array.IndexOf(cityList, "York");
            int[] YorkArray = mileageTable[YorkIndex];
            int closestMileageYork = Min(YorkArray);
            Console.WriteLine("The closest mileage to York is: " + closestMileageYork + " miles");

            // Not needed for the assignment but testing anyway to find the farthest mileage to York
            int farthestMileageYork = Max(YorkArray);
            Console.WriteLine("The farthest mileage to York is: " + farthestMileageYork + " miles");
        }

        public static int Min(int[] array)
        {
            int minValue = int.MaxValue;

            foreach (int element in array)
            {
                if (element < minValue)
                {
                    minValue = element;
                }
            }

            return minValue;
        }

        public static int Max(int[] array)
        {
            int maxValue = int.MinValue;

            foreach (int element in array)
            {
                if (element > maxValue)
                {
                    maxValue = element;
                }
            }

            return maxValue;
        }
    }
}
