﻿using System;
using System.Collections.Generic;
using System.Linq;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            double [,] err = { { -1 } };
            return err;
        }
        double[,] rot = { { Math.Round(Math.Cos(angle)), Math.Round(Math.Sin(angle)) }, { Math.Round(-1 * Math.Sin(angle)), Math.Round(Math.Cos(angle)) } };
        double[,] res = Multiply(matrix, rot);
        return res;
    }
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