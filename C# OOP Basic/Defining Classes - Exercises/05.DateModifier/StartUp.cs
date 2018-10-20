using System;

namespace _05.DateModifier
{
    class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.CalculateDifferenceBetweenDates(firstDate, secondDate)); //Call the class, then the method and print result
        }
    }
}
