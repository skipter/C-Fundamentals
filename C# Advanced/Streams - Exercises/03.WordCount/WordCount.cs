using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            string wordSource = "..//..//..//..//files//words.txt"; //Route to files-words.txt - words to check.
            string text = "..//..//..//..//files//text.txt"; //Test source directory.
            string outputDestinationFile = "..//..//..//..//files//resultExec3.txt"; //Output file directory.

            Dictionary<string, int> wordCounter = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(wordSource))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();

                    //Add the whole line/sentence.
                    if (!wordCounter.ContainsKey(line))
                    {
                        wordCounter.Add(line, 0);
                    }

                    line = reader.ReadLine();
                }
            }
            
            using (StreamReader streamReader = new StreamReader(text))
            {
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    line = line.ToLower();
                    //Search in text by regex expression.
                    Regex regex = new Regex("[A-Za-z]+"); //Catch every word.

                    foreach (Match word in regex.Matches(line))
                    {
                        if (wordCounter.ContainsKey(word.Value))
                        {
                            wordCounter[word.Value] += 1;
                        }
                    }
                    line = streamReader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter (outputDestinationFile))
            {
                foreach (var word in wordCounter.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
