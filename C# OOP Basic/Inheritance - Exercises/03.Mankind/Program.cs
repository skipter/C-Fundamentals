using System;

namespace _03.Mankind
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                string studentInput = Console.ReadLine();
                string[] studentInfo = studentInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                string facNumber = studentInfo[2];

                Student student = new Student(firstName, lastName, facNumber);

                string workerInput = Console.ReadLine();
                string[] workerInfo = workerInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string frstName = workerInfo[0];
                string lstName = workerInfo[1];
                decimal salary = decimal.Parse(workerInfo[2]);
                int hours = int.Parse(workerInfo[3]);

                Worker worker = new Worker(frstName, lstName, salary, hours);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
