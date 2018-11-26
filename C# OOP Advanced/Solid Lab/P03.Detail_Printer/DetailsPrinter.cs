using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        private void PrintEmployee(Employee employee)
        {
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
            }
        }
    }
}
