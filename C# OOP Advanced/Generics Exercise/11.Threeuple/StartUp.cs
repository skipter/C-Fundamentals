using System;

namespace _11.Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            string[] personInfo = Console.ReadLine().Split();

            string fullName = personInfo[0] + " " + personInfo[1];
            string adress = personInfo[2];
            string town = personInfo[3];

            string[] beerInfo = Console.ReadLine().Split();

            string name = beerInfo[0];
            int litters = int.Parse(beerInfo[1]);
            bool drunkOrNot = beerInfo[2] == "drunk"? true : false;

            string[] bankInfo = Console.ReadLine().Split();

            string nameAccount = bankInfo[0];
            double cash = double.Parse(bankInfo[1]);
            string bankName = bankInfo[2];

            Threeuple<string, string, string> personAdress = new Threeuple<string, string, string>(fullName, adress, town);
            Threeuple<string, int, bool> beerLitters = new Threeuple<string, int, bool>(name, litters, drunkOrNot);
            Threeuple<string, double, string> specialNums = new Threeuple<string, double, string>(nameAccount, cash, bankName);

            Console.WriteLine(personAdress);
            Console.WriteLine(beerLitters);
            Console.WriteLine(specialNums);
        }
    }
}
