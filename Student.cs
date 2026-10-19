using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeCalculator
{
    // base class for students
    public class Student
    {
        // private attributes
        private string studentName;
        private double midtermExam;
        private double finalExam;

        // constructor
        public Student(string name, double midterm, double final)
        {
            studentName = name;
            midtermExam = midterm;
            finalExam = final;
        }

        // arithmetic mean
        public double CalculateAverage()
        {
            return (midtermExam + finalExam) / 2.0;
        }

        // virtual method needs to be overridden in derived classes
        public virtual string AssignGrade()
        {
            return "N/A";
        }

        public string Name
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public double Midterm
        {
            get { return midtermExam; }
            set { midtermExam = value; }
        }

        public double Final
        {
            get { return finalExam; }
            set { finalExam = value; }
        }
    }
}
