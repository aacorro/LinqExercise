using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine("-----------------");

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers");
            Console.WriteLine(numbers.Average());
            Console.WriteLine("-----------------");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending order");
            var ascending = numbers.OrderBy(p => p);
            foreach (var x in ascending)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("-----------------");

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Decsending order");
            var descending = numbers.OrderByDescending(p => p);
            foreach(var x in descending)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("------------------");

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6");
            var greaterThanSix = numbers.Where(x => x > 6);
            foreach (var x in greaterThanSix)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-----------------");

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Only print 4");
            foreach (var x in descending.Take(..4))
            {
                    Console.WriteLine(x);
                
            }

            Console.WriteLine("-----------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Change value and Decsending order");
            numbers[4] = 99;
            foreach (var x in numbers.OrderByDescending(p => p))
            {
                Console.WriteLine(x);

            }


            // List of employees ****Do not remove this****

            var employees = CreateEmployees();




            Console.WriteLine("FullName && C OR an S");
            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var employeesNameWithCorS = employees.Where(p => p.FirstName.StartsWith("C")
            || p.FirstName.StartsWith("S")).OrderBy(p => p.FirstName);

            foreach (var x in employeesNameWithCorS)
            {
                Console.WriteLine(x.FullName);
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("FullName and Age who are over the age 26");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var overtwentySix = employees.Where(e => e.Age > 26)
                .OrderBy(e => e.Age)
                .ThenBy(e => e.FirstName);

            foreach (var y in overtwentySix)
            {
                Console.WriteLine($"Name: {y.FullName} Age: {y.Age}");
            }

            Console.WriteLine("-----------------");

            Console.WriteLine("YearsOfExperience");
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var average = employees.Where(u => u.YearsOfExperience <= 10 && u.Age > 35);

            Console.WriteLine($"Sum: {average.Sum(p => p.YearsOfExperience)} Average: {average.Average(p=>p.YearsOfExperience)}");

            Console.WriteLine("-----------------");

            Console.WriteLine("Add employee");
            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee( "Angel", "Legna", 100, 50)).ToList();

            foreach (var x in employees)
            {
                Console.WriteLine($"{x.FullName} {x.Age}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
