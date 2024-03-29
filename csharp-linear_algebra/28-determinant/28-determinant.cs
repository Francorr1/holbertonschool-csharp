﻿using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that calculates the determinant of a 2D or 3D matrix
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        int Mat1Type = matrix.GetLength(0);
        int Mat1Type1 = matrix.GetLength(1);
        int MatType = (matrix.GetLength(0) + matrix.GetLength(1)) / 2;
        if (MatType != 2 && MatType != 3)
        {
            return -1;
        }
        if (Mat1Type != Mat1Type1)
        {
            return -1;
        }
        double res = 0;
        if (MatType == 2)
        {
            res = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
        if (MatType == 3)
        {
            res = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]);
            res -= matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]);
            res += matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
        return Math.Round(res, 2);
    }
}