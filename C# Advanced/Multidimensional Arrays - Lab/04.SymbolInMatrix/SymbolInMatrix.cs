using System;

namespace _04.SymbolInMatrix
{
    class SymbolInMatrix
    {                               //80/100
        static void Main()
        {   //Read matrix size.
            int matrixSize = Int32.Parse(Console.ReadLine());
            string[,] matrix = new string[matrixSize, matrixSize];

            //Initial matrix.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                //Read columns.
                string columnElements = Console.ReadLine();
                char[] symbols = new char[columnElements.Length];
                for (int i = 0; i < columnElements.Length; i++)
                {
                    symbols[i] = columnElements[i];
                }

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col].ToString();
                }
            }
            //Input symbol.
            string symbol = Console.ReadLine();

            int rowIndex = 0;
            int colIndex = 0;
            bool isContainsSymbol = false;

            #region CheckForSymbol
            //Check for symbol.
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        isContainsSymbol = true;
                        rowIndex = row;
                        colIndex = col;
                        Console.WriteLine($"({rowIndex}, {colIndex})");
                        return;
                    }
                }
            }
            #endregion
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
