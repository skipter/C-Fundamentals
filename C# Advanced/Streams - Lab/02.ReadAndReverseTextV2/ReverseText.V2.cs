using System;
using System.IO;
using System.Linq;

namespace _02.ReadAndReverseTextV2
{
    class Program
    {
        static void Main()
        {
            string path = "../../../"; //Directory to file. For \ - use @ before "". Sintax is : @"..\..\..\".
            string inputFileName = "ReverseText.V2.cs"; //FIle name , which we want to read
            string outputFileName = "reversed.txt";
            //Output is in ../bin/debug/.. folder

            //Sintax
            path = Path.Combine(path, inputFileName);

            //writter using must be in readear
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writter = new StreamWriter(outputFileName))
                {
                    string line = reader.ReadLine();
                    //string line = reader.ReadToEnd(); // read the whole text

                    while (line != null)
                    {
                        writter.WriteLine(String.Join("", line.Reverse()));

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
