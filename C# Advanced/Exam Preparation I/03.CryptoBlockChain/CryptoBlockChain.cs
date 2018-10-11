using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CryptoBlockChain
{
    class CryptoBlockChain
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string output = String.Empty;
            List<string> blockChain = new List<string>();
            //take sentence parts
            for (int i = 0; i < n; i++)
            {
                string incomeChains = Console.ReadLine();
                blockChain.Add(incomeChains);

            }
            //Make all the sentence one big.
            string makeThemOne = string.Concat(blockChain);

            string pattern = @"{[^\]\[{]+}|\[[^{}\[]+\]";

            MatchCollection matches = Regex.Matches(makeThemOne, pattern);

            List<string> validate = new List<string>();

            foreach (var match in matches)
            {
                validate.Add(match.ToString());
            }

            for (int i = 0; i < validate.Count; i++)
            {
                string nums = String.Empty;
                //check symbol is a number
                for (int j = 0; j < validate[i].Length; j++)
                {
                    if (Char.IsDigit(validate[i][j]))
                    {
                        nums += validate[i][j];
                    }
                }
                //check if string % 3 = 0
                if (nums.Length % 3 != 0)
                {
                    continue;
                }

                string numPattern = @"[0-9]{3}"; //make number by groups of 3 numbers
                MatchCollection numMatches = Regex.Matches(nums, numPattern);

                foreach (var match in numMatches)
                {
                    //take evry num
                    int num = int.Parse(match.ToString());
                    num -= validate[i].Length;
                    //Convert num to char - ascii number -> symbol
                    char ch = (char)num;
                    //concat chars
                    output += ch;
                }
            }
            //print result
            Console.WriteLine(output);
        }
    }
}
