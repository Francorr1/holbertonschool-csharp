using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            double[,] errmat = { { -1 } };
            return errmat;
        }
        double det = (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        if (det == 0)
        {
            double[,] errdet = { { -1 } };
            return errdet;
        }
        double[,] res = { {matrix[1, 1], matrix[0, 1] * -1}, {matrix[1, 0] * -1, matrix[0, 0]} };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                res[i, j] = res[i, j] / det;
            }
        }
        return res;
    }
}