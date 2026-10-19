using System;
using static System.Console;

namespace StudentGradeCalculator
{
    public class  GradeCalculator
    {
        public static void Main(string[] args)
        {
            string studentName = "";
            string studentType = "";

            DisplayWelcomeMessage();

            Write("Enter student name: ");
            studentName = ReadLine() ?? string.Empty;

            Write("Type of student? Enter U for Undergraduate or G for Graduate: ");
            studentType = ReadLine() ?? string.Empty;
            studentType = studentType.ToUpper();

            double midtermScore = GetValidScore("Enter midterm exam score (0-100): ");
            double finalScore = GetValidScore("Enter final exam score (0-100): ");

            // Base student object
            Student student;

            // Create the appropriate student object based on the type of student
            if (studentType == "U")
            {
                student = new UndergradStudent(studentName, midtermScore, finalScore);
            }
            else if (studentType == "G")
            {
                student = new GradStudent(studentName, midtermScore, finalScore);
            }
            else
            {
                WriteLine("Invalid student type. Please enter U for Undergraduate or G for Graduate.");
                return;
            }

            // Display the results
            WriteLine("Final Results:");
            WriteLine($"Student Name: {student.Name}");
            WriteLine($"Midterm Exam Score: {student.Midterm}");
            WriteLine($"Final Exam Score: {student.Final}");
            WriteLine($"Course Average: {student.CalculateAverage()}");
            WriteLine($"Final Grade: {student.AssignGrade()}");
        }

        private static void DisplayWelcomeMessage()
        {
            WriteLine("Student Grade Calculator");
        }

        static double GetValidScore(string prompt)
        {
            double score = 0.0;
            bool isValid;
            do
            {
                Write(prompt);
                string? input = ReadLine();
                if (input == null)
                {
                    isValid = false;
                }
                else
                {
                    isValid = double.TryParse(input, out score) && score >= 0 && score <= 100;
                }
                if (!isValid)
                {
                    WriteLine("Invalid input. Please enter a number between 0 and 100.");
                }
            } while (!isValid);
            return score;
        }
    }
}