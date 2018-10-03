using System;

using System.IO;

namespace _01.ReadFromFile
{
    class ReadFromFile
    {
        static void Main()
        {
            string path = "../../../";
            string fileName = "ReadFromFile.cs";

            path = Path.Combine(path, fileName);

            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    Console.WriteLine();

                    line = reader.ReadLine();
                }
            }
        }
    }
}
