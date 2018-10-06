using System;
using System.Linq;

namespace Generic_Delegates_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, string> Multy = IsGreater;

            Console.WriteLine(Calculator(4, 5, Multiply));
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, IsGreater));
            Console.WriteLine(Calculator(21, 3, (x, y) => (x / y).ToString()));
        }
        public static int WrongFunction(int x, int y)
        {
            return (x + y);
        }

        public static string Calculator(int x, int y, Func<int, int, string> opr)
        {
            return opr(x, y);
        }
        //These methods are ok for BinaryOperator(strint - int, int)
        public static string Multiply(int x, int y) => (x * y).ToString();

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int x, int y)
        {
            return (x > y).ToString();
        }
    }
}
