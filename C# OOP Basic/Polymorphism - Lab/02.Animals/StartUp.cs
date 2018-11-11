using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main()
        {
            Animals cat = new Cat("Pesho", "Whiskas");
            Animals dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
