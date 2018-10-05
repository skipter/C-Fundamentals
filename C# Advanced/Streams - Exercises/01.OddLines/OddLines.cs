using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            //var files = File.Open("..//..//..//..//files//text.txt", FileMode.Open); //Route to files-text.txt

            using (StreamReader streamReader = new StreamReader("..//..//..//..//files//text.txt")) //Must be in diff variable(the path).
            {
                var line = streamReader.ReadLine();

                int counter = 0; //TO get odd lines.

                while (line != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;

                    line = streamReader.ReadLine();
                }
            }
        }
    }
}
