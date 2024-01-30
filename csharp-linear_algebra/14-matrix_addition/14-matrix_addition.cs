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
        int Mat1Type = matrix1.GetLength(0);
        int Mat2Type = matrix2.GetLength(0);
        int Mat1Type1 = matrix1.GetLength(1);
        int Mat2Type1 = matrix2.GetLength(1);
        if (Mat1Type != Mat2Type || Mat1Type != Mat1Type1 || Mat2Type != Mat2Type1 || Mat1Type1 != Mat2Type1)
        {
            double[,] res = { { -1 } };
            return res;
        }
        if (Mat1Type == 2)
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
        if (Mat1Type == 3)
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