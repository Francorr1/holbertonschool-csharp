using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that calculates a rotation matrix
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            double [,] err = { { -1 } };
            return err;
        }
        double[,] rot = { { Math.Cos(angle), Math.Sin(angle) }, { -1 * Math.Sin(angle), Math.Cos(angle) } };
        double[,] res = Multiply(matrix, rot);
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                res[i, j] = Math.Round(res[i, j], 2);
            }
        }
        return res;
    }
    /// <summary>
    /// Function that multiplies the Matrix by the rotation matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            double[,] err = { { -1 } };
            return err;
        }
        int Mat1Col = matrix1.GetLength(0);
        int Mat1Row = matrix1.GetLength(1);
        int Mat2Row = matrix2.GetLength(1);
        double[,] res = new double[Mat1Col, Mat2Row];
        for (int i = 0; i < Mat1Col; i++)
        {
            for (int j = 0; j < Mat2Row; j++)
            {
                for (int k = 0; k < Mat1Row; k++)
                {
                    res[i, j] += matrix1[i, k] * matrix2[k, j];
                }
                
            }   
        }
        return res;
    }
}