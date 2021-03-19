using System;
using System.Collections.Generic;
//SOLID
//S - All classes and methods manage only a single aspect
//O - Methods are open to extention 
//L - see "Student.cs"
//I - Interface segreation done through the student manager and text file manager 
//D - Dependancy Inversion - performed through seperation of "StudentList" (source), "StudentManager", "TextFileManager"
namespace StudentV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string check = "";
            while (!check.Equals("x"))
            {
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Welcome to the Student Management System");
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("Press 's' to view students ");
                Console.WriteLine("Press 'a' to add a new student");
                Console.WriteLine("Press 'x' to exit");
                check = Console.ReadLine();
                switch (check)
                {
                    case "s":
                        listStudents();
                        break;
                    case "a":
                        addStudents();
                        break;
                    case "x":
                        Console.WriteLine("Goodbye!");
                        break;

                }
            }

        }

        public static void listStudents()   // lists all students, part time and full time
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Current students (ALL)");
            Console.WriteLine("---------------------------------------------------");
            foreach (Student s in StudentManger.Instance.getStudents())
            {
                Console.WriteLine(s.ToString());
            }
        }
        public static void addStudents() // to add a new student
        {
            Console.WriteLine("Please enter a student ID: ");
            string sID = Console.ReadLine();
            Console.WriteLine("Please enter a student name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the fees due: ");
            double outF = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter enrollment date: ");
            string enrDate = Console.ReadLine();
            Console.WriteLine("Is " + name + " studying full time? (y/n) : ");

            if (Console.ReadLine().Equals("y")) // decides object type
            {
                FTStudent fts = new FTStudent(sID, name, outF, enrDate);        // Program(not dependant on StudentList) -> 
                StudentManger.Instance.addStudent(fts);                         // StudentManager(receive student object) ->                                                                 
            }                                                                   // StudentList (Dependancy Inversion)
            else
            {
                PTStudent pts = new PTStudent(sID, name, outF, enrDate);
                StudentManger.Instance.addStudent(pts);
            }
            StudentManger.Instance.saveStudents();
        }





    }
}
