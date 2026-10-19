using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculator
{
    // undergraduate student class that inherits from Student
    public class UndergradStudent : Student
    {
        // constructor for undergrad students
        public UndergradStudent(string name, double midterm, double final) : base(name, midterm, final)
        {
        }

        // override the AssignGrade method for undergrad students
        public override string AssignGrade()
        {
            double average = CalculateAverage();
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B"; 
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
