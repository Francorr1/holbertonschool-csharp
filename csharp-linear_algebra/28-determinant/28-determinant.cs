using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        int MatType = matrix.GetLength(0) + matrix.GetLength(1) / 2;
        if (MatType != 2 || MatType != 3)
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
        return res;
    }
}