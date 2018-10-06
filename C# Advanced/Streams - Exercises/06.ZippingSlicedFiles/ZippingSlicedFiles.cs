using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _06.ZippingSlicedFiles
{
    class ZippingSlicedFiles
    {
        static List<string> paths;

        static void Main()
        {
            paths = new List<string>();

            string sourceFile = "..//..//..//..//files//sliceMe.mp4";
            string outputDestination = "..//..//..//..//files//";
            int partsToSlice = 4;

            Slice(sourceFile, outputDestination, partsToSlice);

            Assemble(paths, outputDestination);
        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            //To read file.
            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFile.Length / parts + readFile.Length % parts;
                byte[] buffer = new byte[size];

                for (int i = 0; i < parts; i++)
                {
                    string destinationPath = destinationDirectory + $"Path-{i}.mp4";

                    paths.Add(destinationPath);

                    using (FileStream writeFile = new FileStream(destinationPath, FileMode.Create))
                    {
                        int bytesCount = readFile.Read(buffer, 0, buffer.Length);
                        writeFile.Write(buffer, 0, buffer.Length);
                    }

                    using (GZipStream gz = new GZipStream(new FileStream(destinationPath + ".gz", FileMode.Create), CompressionMode.Compress, false))
                    {
                        gz.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            byte[] buffer = new byte[1024];

            destinationDirectory += "assembled.mp4";

            using (FileStream writeFile = new FileStream(destinationDirectory, FileMode.Create))
            {
                foreach (var path in paths)
                {

                    using (GZipStream gzZip = new GZipStream(new FileStream(path + ".gz", FileMode.Open), CompressionMode.Decompress))
                    {
                        while (true)
                        {
                            int bytesCount = gzZip.Read(buffer, 0, buffer.Length);

                            if (bytesCount == 0)
                            {
                                break;
                            }
                            writeFile.Write(buffer, 0, bytesCount);
                        }
                    }
                }
            }
        }
    }
}
