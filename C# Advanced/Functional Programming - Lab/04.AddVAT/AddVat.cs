using System;
using System.Linq;

namespace _04.AddVAT
{
    class AddVat
    {
        static void Main()
        {
            Func<double, double> addVat = p => p * 1.2;

            Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(addVat)
                 .ToList()
                 .ForEach(x => Console.WriteLine($"{x:F2}"));
        }
    }
}
