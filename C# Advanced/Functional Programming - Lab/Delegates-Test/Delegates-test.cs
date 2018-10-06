using System;

namespace Delegates_Test
{
    class Program
    {
        //public, delegate, return string, name of the type and params
        public delegate string BinaryOperator(int x, int y);

        static void Main()
        {
            BinaryOperator opMulty = Multiply; //Here we save function-Multiply with variable name: opMulty with type BinaryOperator.
            Console.WriteLine(Calculator(4, 5, Multiply));
            Console.WriteLine(Calculator(4, 5, Add));
            Console.WriteLine(Calculator(4, 5, IsGreater));


           // BinaryOperator tesWrongFunct = WrongFunction; //Cant use because BinaryOperator return string and WrongFunction is int type.
        }

        //return int type
        public static int WrongFunction(int x, int y)
        {
            return (x + y);
        }

        public static string Calculator (int x, int y, BinaryOperator opr)
        {
            return opr(x, y);
        }
        //These methods are ok for BinaryOperator(strint - int, int)
        public static string Multiply(int x, int y)
        {
            return (x * y).ToString();
        }

        public static string Add(int x, int y)
        {
            return (x + y).ToString();
        }

        public static string IsGreater(int x , int y)
        {
            return (x > y).ToString();
        }
    }
}
