using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that adds two 2D or 3D matrix
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int Mat1Type = matrix1.GetLength(0) + matrix1.GetLength(1);
        int Mat2Type = matrix2.GetLength(0) + matrix2.GetLength(1);
        if (matrix1.GetLength(0) != 2 || matrix2.GetLength(0) != 2)
        {
            double[,] res = { { -1 } };
            return res;
        }
        if (matrix1.GetLength(0) != 3 || matrix2.GetLength(0) != 3)
        {
            double[,] res = { { -1 } };
            return res;
        }
        if (Mat1Type != Mat2Type)
        {
            double[,] res = { { -1 } };
            return res;
        }
        if (Mat1Type == 4)
        {
            double[,] res = { { 0, 0 }, { 0, 0 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] += matrix1[i, j];
                    res[i, j] += matrix2[i, j];
                }
            }
            return res;
        }
        if (Mat1Type == 6)
        {
            double[,] res = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] += matrix1[i, j];
                    res[i, j] += matrix2[i, j];
                }
            }
            return res;
        }
        else
        {
            double[,] res = { { -1 } };
            return res;
        }
    }
}