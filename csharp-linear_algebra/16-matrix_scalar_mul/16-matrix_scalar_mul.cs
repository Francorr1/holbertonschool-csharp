using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that multiplies a 2D or 3D matrix by a scalar
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int MatType = matrix.GetLength(0);
        int MatType1 = matrix.GetLength(1);
        if (MatType != MatType1)
        {
            double[,] res = { { -1} };
            return res;
        }
        if (MatType == 2)
        {
            double[,] res = { { 0, 0 }, { 0, 0 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] = matrix[i, j] * scalar;
                }
            }
            return res;
        }
        if (MatType == 3)
        {
            double[,] res = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    res[i, j] = matrix[i, j] * scalar;
                }
            }
            return res;
        }
    }
}