using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class ProductShop
    {
        static void Main(string[] args)
        {
            var inputData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, Dictionary<string, double>> shopsData = new SortedDictionary<string, Dictionary<string, double>>();

            while (inputData[0] != "Revision")
            {
                string shopName = inputData[0];
                string product = inputData[1];
                double price = double.Parse(inputData[2]);

                if (!shopsData.ContainsKey(shopName))
                {
                    shopsData.Add(shopName, new Dictionary<string, double>());
                    shopsData[shopName].Add(product, price);
                }
                else
                {
                    shopsData[shopName].Add(product, price);
                }

                inputData = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var shop in shopsData)
            {
                var product = shop.Key;

                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shopsData[product])
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
