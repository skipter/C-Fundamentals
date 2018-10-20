using System;
using System.Collections.Generic;
using System.Text;

namespace _05.DateModifier
{
    public class DateModifier
    {
        public static int CalculateDifferenceBetweenDates(string firstDate, string secondDate)
        {
            TimeSpan difference = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);

            return Math.Abs(difference.Days);
        }
    }
}
