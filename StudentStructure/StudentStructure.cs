/***************************************************************
* Name        : StudentStructure
* Author      : River Deters
* Created     : 06/12/2023
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* IDE         : Visual Studio 2022 Community
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Create a structure that contains first name, last name, student id, major and year. In the main method, accept user input for the 5 variables, create a CreateStudent method that accepts the 5 values and returns a student. Then, create a displayStudent method to display all values of the structure outside of the structure itself.
*               Input: Student's first name, last name, student ID, major, and year in school
*               Output: The display string of all input values after a student has been created.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System;

namespace StudentStructure
{
    public class StudentStructure
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the student's first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter the student's last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter the student's ID number:");
            string studentID = Console.ReadLine();

            Console.WriteLine("Please enter the student's major:");
            string major = Console.ReadLine();

            Console.WriteLine("Please enter the student's year in school:");
            string yearInSchool = Console.ReadLine();

            Student student = CreateStudent(firstName, lastName, studentID, major, yearInSchool);
            string display = DisplayStudent(student);

            Console.WriteLine(display);
        }

        public struct Student
        {
            public string firstName;
            public string lastName;
            public string studentID;
            public string major;
            public string yearInSchool;
        }

        public static string DisplayStudent(Student student)
        {
            string display = student.firstName + " " + student.lastName + ", student ID #" + student.studentID + ", majoring in " + student.major + " is in year " + student.yearInSchool + ".";

            return display;
        }

        public static Student CreateStudent(string firstName, string lastName, string studentID, string major, string yearInSchool)
        {
            Student student = new Student();
            student.firstName = firstName;
            student.lastName = lastName;
            student.studentID = studentID;
            student.major = major;
            student.yearInSchool = yearInSchool;

            return student;
        }
    }
}
