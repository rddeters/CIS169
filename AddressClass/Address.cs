using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

/***************************************************************
* Name        : Address
* Author      : River Deters
* Created     : 06/26/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Create an Address class.
*               Input: No user input
*               Output: No output other than ToString method.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace AddressClass
{
    public class Address
    {
        private string _buildingNum;
        private string _streetName;
        private string _apartmentNum;
        private string _city;
        private string _state;
        private string _zipCode;

        public Address()
        {
            BuildingNum = "unknown";
            StreetName = "unknown";
            ApartmentNum = "unknown";
            City = "unknown";
            State = "unknown";
            ZipCode = "unknown";
        }

        public Address(string buildingNum, string streetName, string apartmentNum, string city, string state, string zipCode)
        {
            // Constructors
            BuildingNum = buildingNum;
            StreetName = streetName;
            ApartmentNum = apartmentNum;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        // Properties
        public string BuildingNum
        {
            get { return _buildingNum; }
            set { _buildingNum = value; }
        }

        public string StreetName
        {
            get { return _streetName; }
            set { _streetName = value; }
        }

        public string ApartmentNum
        {
            get { return _apartmentNum; }
            set { _apartmentNum = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        // Methods
        public override string ToString()
        {
            return BuildingNum + " " + StreetName + "\nApt " + ApartmentNum + "\n" + City + ", " + State + " " + ZipCode;
        }
    }
}