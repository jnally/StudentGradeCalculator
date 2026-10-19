using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculator
{
    // graduate student class that inherits from Student
    public class GradStudent : Student
    {
        // constructor for graduate students
        public GradStudent(string name, double midterm, double final) : base(name, midterm, final)
        {
        }

        // override the AssignGrade method for graduate students
        // grad students basically fail with a C or below, so we only have A, B, and F grades
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
            else
            {
                return "F";
            }
        }
    }
}
