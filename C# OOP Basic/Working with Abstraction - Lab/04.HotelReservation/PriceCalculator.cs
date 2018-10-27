namespace _04.HotelReservation
{
    public class PriceCalculator
    {
        private decimal price;
        private int days;
        private Seasons season;
        private DiscountType discount;

        public PriceCalculator(decimal price, int days, Seasons season, DiscountType discount)
        {
            this.Price = price;
            this.Days = days;
            this.Season = season;
            this.Discount = discount;
        }

        public string CalculatePrice()
        {
            var tempTotal = price * days * (int)season;
            var discountPercentage = ((decimal)100 - (int)discount) / 100;
            var totalPrice = tempTotal * discountPercentage;
            return totalPrice.ToString("F2");
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public int Days
        {
            get
            {
                return this.days;
            }
            set
            {
                this.days = value;
            }
        }

        public Seasons Season
        {
            get
            {
                return this.season;
            }
            set
            {
                this.season = value;
            }
        }

        public DiscountType Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }
    }
}
