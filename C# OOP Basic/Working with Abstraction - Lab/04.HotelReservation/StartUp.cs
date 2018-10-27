using System;

namespace _04.HotelReservation
{
    public class StartUp
    {
        public static void Main()
        {
            var inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(inputArgs[0]);
            int days = int.Parse(inputArgs[1]);
            Seasons season = Enum.Parse<Seasons>(inputArgs[2]);
            DiscountType discount = DiscountType.None;

            if (inputArgs.Length > 3)
            {
                discount = Enum.Parse<DiscountType>(inputArgs[3]);
            }

            PriceCalculator priceClaculator = new PriceCalculator(pricePerDay, days, season, discount);
            var price = priceClaculator.CalculatePrice();
            Console.WriteLine(price);

        }
    }
}
