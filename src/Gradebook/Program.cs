using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Luis Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.GetStatistics();
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade is {stats.Low}");
            Console.WriteLine($"The lowest grade is {stats.High}");
            Console.WriteLine($"The highest grade is {stats.Average:N1}");
          
        }
    }
}
