using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Function that shears a matrix in a direction by a factor
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            double[,] errmat = { { -1 } };
            return errmat;
        }
        if (direction == 'x')
        {
            double[,] res = { { matrix[0, 0], matrix[0, 1] }, { matrix[1, 0], matrix[1, 1] } };
            res[0, 0] += factor * res[0, 1];
            res[1, 0] += factor * res[1, 1];
            return res;
        }
        if (direction == 'y')
        {
            double[,] res = { { matrix[0, 0], matrix[0, 1] }, { matrix[1, 0], matrix[1, 1] } };
            res[0, 1] += factor * res[0, 0];
            res[1, 1] += factor * res[1, 0];
            return res;
        }
        double[,] errdir = { { -1 } };
        return errdir;
    }
}