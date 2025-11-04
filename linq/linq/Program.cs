using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Example1_BasicFiltering();
            Example2_Sorting();
            Example3_Grouping();
            Example4_Aggregation();
            Example5_ComplexObjects();



            Console.ReadLine();
        }

        static void Example1_BasicFiltering()
        {
            Console.WriteLine("=== Example1: Basic Filtering ===");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            var greaterThan5 = numbers.Where(n => n > 5);
            Console.WriteLine("Number gather than 5: " + string.Join(", ", greaterThan5));

            var between3And7 = numbers.Where(n => n >= 3 && n <= 7);
            Console.WriteLine("Numbers between 3 and 7: " + string.Join(", ", between3And7));

            Console.WriteLine();
        }

        static void Example2_Sorting()
        {
            Console.WriteLine("=== Example2: Sorting ===");

            List<string> names = new List<string> 
            { 
                "Reza", "Maryam", "Ali", "Sara", "Ahmad", "Fatemeh" 
            };

            // Ascending Order
            var sortedAsc = names.OrderBy(n => n);
            Console.WriteLine("Ascending Order : " + string.Join(", ", sortedAsc));

            // Descending Order
            var sortedDesc = names.OrderByDescending(n => n);
            Console.WriteLine("Descending Order : " + string.Join(", ", sortedDesc));

            // Sort by string length
            var byLength = names.OrderBy(n => n.Length).ThenBy(n => n);
            Console.WriteLine("Sort by string length: " + string.Join(", ", byLength));

            Console.WriteLine();
        }

        static void Example3_Grouping()
        {
            Console.WriteLine("=== Example3 : Grouping  ===");
    
            List<Person> people = new List<Person>
            {
                new Person { Name = "ali", Age = 25, City = "tehren" },
                new Person { Name = "maryam", Age = 30, City = "mashhad" },
                new Person { Name = "reza", Age = 25, City = "tehran" },
                new Person { Name = "sara", Age = 28, City = "esfahan" },
                new Person { Name = "ahmad", Age = 30, City = "mashhad" }
            };
    
            // group by city
            var groupByCity = people.GroupBy(p => p.City);
    
            foreach (var group in groupByCity)
            {
                Console.WriteLine("city : "+ group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine("  - "+person.City+" ("+person.Age+" year)");
                }
            }
    
            Console.WriteLine();
        }

        static void Example4_Aggregation()
        {
            Console.WriteLine("=== Example 4: Aggregation ===");
    
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
    
            int sum = numbers.Sum();
            Console.WriteLine("Sum: "+sum);
    
            double average = numbers.Average();
            Console.WriteLine("Average: "+average);
    
            int max = numbers.Max();
            Console.WriteLine("Max: "+max);
    
            int min = numbers.Min();
            Console.WriteLine("Min: "+min);
    
            int count = numbers.Count();
            Console.WriteLine("Count: "+count);
    
            int countGreaterThan25 = numbers.Count(n => n > 25);
            Console.WriteLine("Numbers gather than 25: " + countGreaterThan25);
    
            Console.WriteLine();
        }

        static void Example5_ComplexObjects()
        {
            Console.WriteLine("=== Example5: Work by Complex Objects ===");
    
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "ali", Grade = 18.5, Department = "computer" },
                new Student { Id = 2, Name = "maryam", Grade = 19.2, Department = "mathematic" },
                new Student { Id = 3, Name = "reza", Grade = 16.8, Department = "computer" },
                new Student { Name = "sara", Grade = 17.5, Department = "physics" },
                new Student { Id = 5, Name = "ahmad", Grade = 20.0, Department = "computer" }
            };
    
            // Scores of computer students greater than 17
            var computerTopStudents = students
                .Where(s => s.Department == "computer" && s.Grade > 17)
                .OrderByDescending(s => s.Grade);
    
            Console.WriteLine("Scores of computer students greater than 17 :");
            foreach (var student in computerTopStudents)
            {
                Console.WriteLine("  - "+student.Name+" : "+student.Grade);
            }
    
            // Average of Department
            var departmentAverages = students
                .GroupBy(s => s.Department)
                .Select(g => new {
                    Department = g.Key,
                    AverageGrade = g.Average(s => s.Grade)
                });

            Console.WriteLine("\n Average of Department:");
            foreach (var dept in departmentAverages)
            {
                Console.WriteLine("  - " + dept.Department + ": " + dept.AverageGrade);
            }
    
            Console.WriteLine();
        }

    }
}
