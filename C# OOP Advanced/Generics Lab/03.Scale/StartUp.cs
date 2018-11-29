namespace GenericScale
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var scale = new Scale<int>(25, 2); //to set value must be set in the constructor
            var scale1 = new Scale<double>(13, 19);
            var scale2 = new Scale<string>("aaa", "aaa");

            Console.WriteLine(scale.GetHeavier());
            Console.WriteLine(scale1.GetHeavier());
            Console.WriteLine(scale2.GetHeavier());
        }
    }
}
