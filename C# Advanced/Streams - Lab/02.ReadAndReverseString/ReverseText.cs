using System;
using System.IO;
using System.Linq;

namespace _02.ReadAndReverseString
{
    class ReverseText
    {
        static void Main()
        {
            string path = "../../../../"; //Directory to file
            string fileName = "ReverseText.cs"; //FIle name , which we want to read
            //Sintax
            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(String.Join("", line.Reverse()));

                    line = reader.ReadLine();
                }
            }
        }
    }
}
