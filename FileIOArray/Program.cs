using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOArray
{
    /// <summary>
    /// demo of the git file.io
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string dataPath = @"Data\Students.txt";
            
            string[] students = new string[3];
            students[0] = "Sue,McWaters,46";
            students[1] = "Bill,McGaw,67";
            students[2] = "Charlie,Velis,22";

            //File.WriteAllLines(dataPath, students);
            WriteAllStudents(dataPath, students);

            students = ReadAllStudents(dataPath);

            DisplayAllStudents(students);

            //
            //Show all files
            //change data.txt to copy always
            //

        }

        static void WriteAllStudents(string dataPath, string[] students)
        {
            File.WriteAllLines(dataPath, students);
        }

        static string[] ReadAllStudents(string dataPath)
        {
            string[] studentList;

            studentList = File.ReadAllLines(dataPath);

            return studentList;
        }

        /// <summary>
        /// Displats all students
        /// </summary>
        /// <param name="students"></param>
        static void DisplayAllStudents(string[] students)
        {
            Console.WriteLine();
            Console.WriteLine("Student Info");
            Console.WriteLine();

            //
            // Creates a table header
            //
            Console.WriteLine(" ".PadRight(1) +
                "First Name".PadRight(15) +
                "Last Name".PadRight(15) +
                "Age".PadRight(5)
                );

            Console.WriteLine(" ".PadRight(1) +
                "_____________".PadRight(15) +
                "_____________".PadRight(15) +
                "___________".PadRight(5)
                );

            foreach (string eachStudent in students)
            {
                string[] studentInfo = eachStudent.Split(',');

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string age = studentInfo[2];

                //
                // Displays the username within the table
                //
                Console.WriteLine(" ".PadRight(1) +
                    firstName.PadRight(15) + 
                    lastName.PadRight(15) +
                    age.PadRight(5)
                    );
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
