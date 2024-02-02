using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            double[,] errmat = { { -1 } };
            return errmat;
        }
        if (direction != 'x' || direction != 'y')
        {
            double[,] errdir = { { -1 } };
            return errdir;
        }
        if (direction == 'x')
        {
            double[,] res = { { matrix[1, 1], matrix[1, 2] }, { matrix[2, 1], matrix[2, 2] } };
            res[1, 1] += factor * res[1, 2];
            res[2, 1] += factor * res[2, 2];
        }
        if (direction == 'y')
        {
            double[,] res = { { matrix[1, 1], matrix[1, 2] }, { matrix[2, 1], matrix[2, 2] } };
            res[1, 2] += factor * res[1, 1];
            res[2, 2] += factor * res[2, 1];
        }
        return res;
    }
}