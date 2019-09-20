using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        //This constructor initializes grade
         public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        //This method adds grades to Book
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        //This method computes the minimum, maximum value, 
        //and average of all values in Book
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;

            }
            result.Average /= grades.Count;
            return result;

        }
        private List<double> grades;
        public string Name;
    }
}