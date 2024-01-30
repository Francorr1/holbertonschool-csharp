using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int Mat1Type = matrix1.GetLength(0);
        int Mat2Type = matrix2.GetLength(0);
        if (Mat1Type != Mat2Type)
        {
            double[,] res = {-1};
            return res;
        }
        if (Mat1Type == 2)
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
        if (Mat1Type == 3)
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
            double[,] res = {-1};
            return res;
        }
    }
}