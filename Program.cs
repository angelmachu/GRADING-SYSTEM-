// Marcos, Angel Matthew D.
// BSCPE 1 - 1 
// CLASS IMPLEMENTATION 

using GRADING_SYSTEM;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Mime;

namespace IntroToCSharp
{
    class Program
    {
        static StudentData studentData;

        static StudentAccounts studentAccounts;

        static double midtermGrade;
        static double finalGrade;
        static double average = (midtermGrade + finalGrade) / 2;
        static void Main()
        {

            CreateStudentData();

            bool loop1 = true; // 1st loop
            bool loop2 = true; // 2nd loop
            bool loop3 = true; // 3rd loop
            string subjectChoice = "";
            string gradeChoice = "";

            while (loop1)
            {
                Console.WriteLine("Welcome User! This program will calculate your Grade and its interpretation.");
                Console.WriteLine();

                Console.Write("Press any key to continue or type \"exit\" to stop the program: ");
                subjectChoice = Console.ReadLine();

                Console.WriteLine(" Please Enter Your Student Number: ");
                string studentNumber = GetStudentAccount();

                Console.WriteLine(" Please Enter Your Student Number: ");
                string studentPin = GetStudentAccount();

                studentAccounts = studentData.CheckPin(studentNumber, studentPin);

                if (subjectChoice == "exit")
                {
                    loop1 = false;
                }
                else
                {
                    while (loop2)
                    {
                        while (studentNumber != "0")
                        {
                            ListSubjects();

                            subjectChoice = Console.ReadLine();

                            switch (subjectChoice)
                            {
                                case "exit":
                                    loop1 = false;
                                    loop2 = false;
                                    break;
                                case "1":
                                case "2":
                                case "3":
                                case "4":
                                case "5":
                                    while (loop3)
                                    {
                                        gradeChoice = inputGrade();
                                        switch (gradeChoice)
                                        {
                                            case "exit":
                                                loop1 = false;
                                                loop2 = false;
                                                loop3 = false;
                                                break;
                                        }
                                    }
                                    loop3 = true;
                                    break;
                                default: // for loop2 cases
                                    Console.WriteLine("Invalid input, choose between number 1 - 5 or type \"exit\" to stop the program");
                                    break;
                            }
                        }
                        loop2 = true;
                    }
                }
            }

            static void ListSubjects()
            {
                List<string> subjectsLists = new List<string>();

                Console.WriteLine("These are the subjects available:");

                subjectsLists.Add("1. Object Oriented Programming");
                subjectsLists.Add("2. Computer Hardware Fundamentals");
                subjectsLists.Add("3. Programming Logic and Design");
                subjectsLists.Add("4. Discrete Mathematics");
                subjectsLists.Add("5. Engineering Data Analysis");

                foreach (string ListSubjects in subjectsLists)
                {
                    Console.WriteLine(ListSubjects);
                }
            }
            static string inputGrade()
            {
                Console.Write("Enter your Midterm Grade: ");
                double midtermGrade = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter your Midterm Grade: ");
                double finalGrade = double.Parse(Console.ReadLine());
                Console.WriteLine();

                average = (midtermGrade + finalGrade) / 2;

                Console.WriteLine("Your Average in this subject is: " + average);

                if (average >= 97 && average <= 100)
                {
                    Console.WriteLine(" Excellent, Your Grade is 1.0 ");
                }
                else if (average >= 94 && average <= 96)
                {
                    Console.WriteLine(" Excellent, Your Grade is 1.25 ");
                }
                else if (average >= 91 && average <= 93)
                {
                    Console.WriteLine(" Very Good, Your Grade is 1.5 ");
                }
                else if (average >= 88 && average <= 90)
                {
                    Console.WriteLine(" Very Good, Your Grade is 1.75 ");
                }
                else if (average >= 85 && average <= 87)
                {
                    Console.WriteLine(" Good, Your Grade is 2.0 ");
                }
                else if (average >= 82 && average <= 84)
                {
                    Console.WriteLine(" Good, Your Grade is 2.25 ");
                }
                else if (average >= 79 && average <= 81)
                {
                    Console.WriteLine(" Satisfactory, Your Grade is 2.50 ");
                }
                else if (average >= 76 && average <= 78)
                {
                    Console.WriteLine(" Satisfactory, Your Grade is 2.75 ");
                }
                else if (average == 75)
                {
                    Console.WriteLine(" Passing, Your Grade is 3.0 ");
                }
                else if (average >= 64 && average <= 74)
                {
                    Console.WriteLine(" Fail, Your Grade is 5.0 ");
                }
                return Console.ReadLine();
            }

            static void CreateStudentData()
            {
                studentData = new StudentData();
            }
            static string GetStudentAccount()
            {
                Console.Write("Account input > ");
                return Console.ReadLine();
            }
        }
    }
}
