using System;

namespace _10.Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] personInfo = Console.ReadLine().Split();

            string fullName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2];

            string[] beerInfo = Console.ReadLine().Split();

            string name = beerInfo[0];
            int litters = int.Parse(beerInfo[1]);

            string[] specialNumbers = Console.ReadLine().Split();

            int specialNum = int.Parse(specialNumbers[0]);
            double specialDouble = double.Parse(specialNumbers[1]);

            SpecialTuple<string, string> personAdress = new SpecialTuple<string, string>(fullName, adress);
            SpecialTuple<string, int> beerLitters = new SpecialTuple<string, int>(name, litters);
            SpecialTuple<int, double> specialNums = new SpecialTuple<int, double>(specialNum, specialDouble);

            Console.WriteLine(personAdress);
            Console.WriteLine(beerLitters);
            Console.WriteLine(specialNums);
        }
    }
}
