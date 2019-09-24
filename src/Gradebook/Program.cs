using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Luis Grade Book");
            
            while (true)
            {
                Console.WriteLine("Enter grades for student or \"Q\" to quit");
                var input = Console.ReadLine();
                
                if(input == "q")
                {
                    break;
                }

                try
                {
                    var gradeNum = double.Parse(input);
                    book.AddGrade(gradeNum);
                }

                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("**");
                }
                
            }
 
            
            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
          
        }
    }
}
