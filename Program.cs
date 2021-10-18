using System;

namespace Weekly_10_18
{
    class Program
    {
        static int[,] PrintGrid(int rows, int cols)
        {
            int[,] result = new int[rows, cols];
            int x = 0;
            int y = 0;
            int max = rows * cols;
            for ( int i = 1; i <= max; i++ )
            {
                result[x, y] = i;
                x++;
                if (x == rows)
                {
                    x = 0;
                    y++;
                }
            }
            return result;
        }

        // Shamelessly copied from https://stackoverflow.com/a/24094221/4114124
        static void Print2DArray<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            Print2DArray(PrintGrid(3, 6));
            Print2DArray(PrintGrid(5, 3));
            Print2DArray(PrintGrid(4, 1));
        }
    }
}
