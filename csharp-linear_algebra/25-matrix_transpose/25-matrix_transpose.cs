using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that transposes a matrix
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.GetLength(0) == 0)
        {
            double[,] errempt = new double[,] { { } };
            return errempt;
        }
        double[,] res = new double[matrix.GetLength(1), matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                res[j, i] = matrix[i, j];
            }
        }
        return res;
    }
}