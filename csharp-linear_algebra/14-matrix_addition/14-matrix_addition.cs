using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int Mat1Type = matrix1.Count();
        int Mat2Type = matrix2.Count();
        if (Mat1Type != Mat2Type)
        {
            double[,] res = { { -1 } };
            return res;
        }
        if (Mat1Type == 4)
        {
            double[,] res = { { 0, 0 }, { 0, 0 } };
            for (int i = 0; i < Mat1Type; i++)
            {
                for (int j = 0; j < Mat1Type; j++)
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
            for (int i = 0; i < Mat1Type; i++)
            {
                for (int j = 0; j < Mat1Type; j++)
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