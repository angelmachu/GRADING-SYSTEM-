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
        static StudentData students;

        static StudentAccounts accountResult;

        public static bool loop1 = true; // 1st loop
        public static bool loop2 = true; // 2nd loop

        static void Main()
        {
            CreateStudentData();
            string subjectChoice = "";

            while (loop1)
            {
                Console.WriteLine("Welcome User! This program will calculate your Grade and its interpretation.");
                Console.WriteLine();

                Console.Write("Press any key to continue or type \"exit\" to stop the program : ");
                subjectChoice = Console.ReadLine();

                if (subjectChoice == "exit")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Exiting Program, Thank you!");
                    loop1 = false;
                }
                else
                {
                    Console.WriteLine("Please Enter Your Student Number: ");
                    string studentNumber = GetStudentAccount();

                    Console.WriteLine("Please Enter Your Student PIN: ");
                    string studentPin = GetStudentAccount();

                    accountResult = students.CheckPin(studentNumber, studentPin);

                    while (loop2 && studentPin != "0")
                    {
                        if (accountResult != null)
                        {
                            ListSubjects();

                            studentPin = GetStudentAccount();
                            switch (studentPin)
                            {
                                case "exit":
                                    Console.WriteLine("");
                                    Console.WriteLine("Exiting Program, Thank you!");
                                    loop1 = false;
                                    loop2 = false;
                                    break;
                                case "1":
                                case "2":
                                case "3":
                                case "4":
                                case "5":
                                    inputGrade();
                                    break;
                                default: // for loop2 cases
                                    Console.WriteLine("Invalid input, choose between numbers 1 - 5 ");
                                    break;
                            }
                        }
                    }
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
                subjectsLists.Add("");
                subjectsLists.Add("Type \"exit\" to stop the program");

                foreach (string ListSubjects in subjectsLists)
                {
                    Console.WriteLine(ListSubjects);           
                }
            }

            static void inputGrade()
            {
                Console.Write("Enter your Midterm Grade: ");
                double midtermGrade = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Enter your Final Grade: ");
                double finalGrade = double.Parse(Console.ReadLine());
                Console.WriteLine();

                double average = (midtermGrade + finalGrade) / 2;

                Console.WriteLine("Your Average in this subject is: " + average);
                Console.WriteLine();

                if (average >= 97 && average <= 100)
                {
                    Console.WriteLine(" Excellent, Your Final Average Grade is 1.0 ");
                }
                else if (average >= 94 && average <= 96)
                {
                    Console.WriteLine(" Excellent, Your Final Average Grade is 1.25 ");
                }
                else if (average >= 91 && average <= 93)
                {
                    Console.WriteLine(" Very Good, Your Final Average Grade is 1.5 ");
                }
                else if (average >= 88 && average <= 90)
                {
                    Console.WriteLine(" Very Good, Your Final Average Grade is 1.75 ");
                }
                else if (average >= 85 && average <= 87)
                {
                    Console.WriteLine(" Good, Your Final Average Grade is 2.0 ");
                }
                else if (average >= 82 && average <= 84)
                {
                    Console.WriteLine(" Good, Your Final Average Grade is 2.25 ");
                }
                else if (average >= 79 && average <= 81)
                {
                    Console.WriteLine(" Satisfactory, Final Average Grade is 2.50 ");
                }
                else if (average >= 76 && average <= 78)
                {
                    Console.WriteLine(" Satisfactory, Final Average Grade is 2.75 ");
                }
                else if (average == 75)
                {
                    Console.WriteLine(" Passing, Your Final Average Grade is 3.0 ");
                }
                else if (average >= 64 && average <= 74)
                {
                    Console.WriteLine(" Fail, Your Final Average Grade is 5.0 ");
                }

                Console.WriteLine("");
                Console.WriteLine("Enter any key to choose another subject ");
                Console.ReadLine();
            }

            static void CreateStudentData()
            {
                students = new StudentData();
            }

            static string GetStudentAccount()
            {
                Console.Write("Account input > ");
                return Console.ReadLine();
            }
        }
    }
