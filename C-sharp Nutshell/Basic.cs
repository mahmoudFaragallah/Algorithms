using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.C_sharp_Nutshell
{
    public static class Basic
    {
       public static int[,] RectangularArray()
        {
            // init rectangular array
            int[,] matrix = new int[3, 3];

            // GetLength() method of an array returns the length for a given dimension (starting at 0)
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;

            // create an rectangular array with explicit values
            int[,] jaggMat = new int[,]
            {
                { 0,1,2},
                { 3,4,5},
                { 6,7,8}
            };

            // init jagged array
            int[][] jaggedMat = new int[3][];
            for (int i = 0; i < jaggedMat.Length; i++)
            {
                jaggedMat[i] = new int[3]; // create inner array
                for (int j = 0; j < jaggedMat[i].Length; j++)
                    jaggedMat[i][j] = i * 3 + j;
            }

            // Notes => The inner array doesn't initialize in the delcation of jagged array
            // because unlike rectangular array, each inner array can be an arbitrary like example below

            int[][] jaggArray = new int[][]
            {
                new int[]{ 0,1,2},
                new int[]{ 3,4,5},
                new int[]{ 6,7,8,9},
            };
            Console.WriteLine(matrix);
            return matrix;
        }
    }
}
