using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Telephony
{
    public class Smartphone : IBrowsing, ICalling
    {
        
        public string Browsing (string url)
        {
            if (url.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {url}!";
            }
        }

        public string Calling(string number)
        {
            if (!number.All(char.IsDigit))
            {
                return "Invalid number!";
            }
            else
            {
                return $"Calling... {number}";
            }
        }

    }
}
