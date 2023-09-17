using System;
/***************************************************************
* Name        : House
* Author      : River Deters
* Created     : 06/26/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Create a House class that includes the Address class as a property.
*               Input: No user input
*               Output: No output other than ToString method.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace AddressClass
{
    public class House
    {
        private Address _buildingAddress;
        private int _numberBedrooms;
        private int _numberBathrooms;

        public House(string buildingNum, string streetName, string apartmentNum, string city, string state, string zipCode) // Make sure to include all necessarily elements to create an Address object -- it can't be empty like the prior House default constructor 
        {
            BuildingAddress = new Address(buildingNum, streetName, apartmentNum, city, state, zipCode); // create BuildingAddress, not Address string
            NumberBedrooms = 0;
            NumberBathrooms = 0;
        }

        public House(string buildingNum, string streetName, string apartmentNum, string city, string state, string zipCode, int numberBathrooms, int numberBedrooms)  // Make sure to include all necessarily elements to create an Address object 
        {
            BuildingAddress = new Address(buildingNum, streetName, apartmentNum, city, state, zipCode); // create BuildingAddress, not Address string
            NumberBathrooms = numberBathrooms;
            NumberBedrooms = numberBedrooms;
        }

        public Address BuildingAddress // Change from string type to an object of Address class, keeping the get/set the same otherwise
        {
            get { return _buildingAddress; }
            set { _buildingAddress = value; }
        }

        public int NumberBedrooms
        {
            get { return _numberBedrooms; }
            set { _numberBedrooms = value; }
        }

        public int NumberBathrooms
        {
            get { return _numberBathrooms; }
            set { _numberBathrooms = value; }
        }

        public override string ToString()
        {
            return "House at " + BuildingAddress.ToString() + " has " + NumberBedrooms + " bedrooms and " + NumberBathrooms + " bathrooms.";
        }
    }
}
