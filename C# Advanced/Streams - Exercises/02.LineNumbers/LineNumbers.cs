using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string source = "..//..//..//..//files//text.txt"; //Route to files-text.txt
            string outputDestination = "..//..//..//..//files//outputExer2.txt";

            using (StreamReader reader = new StreamReader(source))
            {
                using (StreamWriter writer = new StreamWriter(outputDestination))
                {
                    var line = reader.ReadLine();
                    int counter = 1;

                    while (line != null)
                    {
                        writer.WriteLine($"Line {counter}:{line}");
                        counter++;

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
