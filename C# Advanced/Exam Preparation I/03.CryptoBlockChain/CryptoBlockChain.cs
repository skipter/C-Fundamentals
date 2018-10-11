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

                for (int j = 0; j < validate[i].Length; j++)
                {
                    if (Char.IsDigit(validate[i][j]))
                    {
                        nums += validate[i][j];
                    }
                }

                if (nums.Length % 3 != 0)
                {
                    continue;
                }

                string numPattern = @"[0-9]{3}";
                MatchCollection numMatches = Regex.Matches(nums, numPattern);

                foreach (var match in numMatches)
                {
                    int num = int.Parse(match.ToString());
                    num -= validate[i].Length;

                    char ch = (char)num;
                    output += ch;
                }
            }
            Console.WriteLine(output);
        }
    }
}
