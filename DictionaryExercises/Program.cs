using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            double newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student IDs and names

            do
            {
                Console.WriteLine("Student ID: ");
                string input = Console.ReadLine();
                bool isNum = double.TryParse(input, out newStudent);
                if (isNum)
                {
                    Console.WriteLine("Student name: ");
                    string studentName = Console.ReadLine();
                    students.Add(newStudent, studentName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                } else
                {
                    break;
                }

            } while (!Equals(newStudent, " "));

            // Print class roster
            Console.WriteLine("\nClass Roster");

            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine(student.Key + " - " + student.Value);
            }
        }
    }

}
