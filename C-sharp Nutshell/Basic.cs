using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.C_sharp_Nutshell
{
    public static class Basic
    {
       public static int[,] RectangularArray()
        {
            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;
            Console.WriteLine(matrix);
            return matrix;
        }

    }
}
