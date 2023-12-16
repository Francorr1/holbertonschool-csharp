using System;
using System.Collections.Generic;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int x = myMatrix.GetLength(0);
        int y = myMatrix.GetLength(1);
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                myMatrix[i, j] = (int)Math.Pow(myMatrix[i, j], 2);
            }
            return myMatrix;
        }
    }
}