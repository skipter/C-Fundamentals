using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> directoryInfo = new Dictionary<string, Dictionary<string, decimal>>();

            string path = "..//..//..//";
            string[] files = Directory.GetFiles(path,
                "*.*",
                SearchOption.TopDirectoryOnly);

            foreach (string file in files)
            {
                FileStream currentFile = File.Open(file, FileMode.Open);
                var fileName = Path.GetFileName(file);
                var extension = Path.GetExtension(file);
                Decimal fileSize = Decimal.Divide(currentFile.Length, 1024);

                if (!directoryInfo.ContainsKey(extension))
                {
                    directoryInfo.Add(extension, new Dictionary<string, decimal>());
                }

                if (!directoryInfo[extension].ContainsKey(fileName))
                {
                    directoryInfo[extension].Add(fileName, fileSize);
                }
            }

            string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";

            using (StreamWriter writer = new StreamWriter(pathDesktop))
            {
                foreach (var kvp in directoryInfo.OrderByDescending(x => x.Value.Count).ThenBy(k => k.Key))
                {
                    writer.WriteLine(kvp.Key);

                    foreach (var fileInfo in kvp.Value.OrderBy(x => x.Key))
                    {
                        writer.WriteLine($"--{fileInfo.Key} - {fileInfo.Value:F2}kb");
                    }
                }
            }
        }
    }
}
