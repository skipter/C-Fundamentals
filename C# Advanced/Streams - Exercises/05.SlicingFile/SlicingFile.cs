using System;
using System.IO;

namespace _05.SlicingFile
{
    class SlicingFile
    {
        static void Main()
        {
            string sourceFile = "..//..//..//..//files//sliceMe.mp4";
            string outputDestination = "..//..//..//..//files//";
            int partsToSlice = 4;

            Slice(sourceFile, outputDestination, partsToSlice);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            //To read file.
            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFile.Length / parts;

                byte[] buffer = new byte[4096];

                for (int i = 0; i < parts; i++)
                {
                    string destinationPath = destinationDirectory + $"Path-{i}.mp4";

                    int readedBytes = 0;

                    using (FileStream writeFile = new FileStream(destinationPath, FileMode.Create))
                    {
                        while (true)
                        {
                            int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                            readedBytes += bytesCount;

                            if (readedBytes >= size)
                            {
                                break;
                            }

                            if (bytesCount == 0)
                            {
                                break;
                            }

                            writeFile.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}
