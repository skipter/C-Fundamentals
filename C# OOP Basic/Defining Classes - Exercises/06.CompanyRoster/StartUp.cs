using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();

            int employeesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < employeesCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                Employee employee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    if (input[4].Contains("@"))
                    {
                        employee.Email = input[4];
                    }
                    else
                    {
                        int age = int.Parse(input[4]);
                        employee.Age = age;
                    }
                }
                else if (input.Length == 6)
                {
                    employee.Email = input[4];
                    int age = int.Parse(input[5]);
                    employee.Age = age;

                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var employy in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employy.Name} {employy.Salary:F2} {employy.Email} {employy.Age}");
            }
        }
    }
}
