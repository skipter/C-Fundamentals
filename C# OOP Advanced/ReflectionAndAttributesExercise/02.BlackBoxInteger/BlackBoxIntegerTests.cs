namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            //Create an instance because methods in blackBoxInteger are not static.
            var box = (BlackBoxInteger)Activator.CreateInstance(type, true);

            string data = Console.ReadLine();

            while (data != "END")
            {
                string[] inputArgs = data.Split("_");
                string command = inputArgs[0];
                int number = int.Parse(inputArgs[1]);

                MethodInfo field = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                    .First(m => m.Name == command);

                field.Invoke(box, new object[] { number });

                var result = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                    .First(f => f.Name == "innerValue").GetValue(box);

                Console.WriteLine(result);

                data = Console.ReadLine();
            }
            

            
        }
    }
}
