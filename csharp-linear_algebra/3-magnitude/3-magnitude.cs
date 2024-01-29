using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double res = 0;
        int VectorType = vector.Count();
        if (VectorType == 2)
        {
            res += Math.Pow(vector[0], 2);
            res += Math.Pow(vector[1], 2);
            res = Math.Sqrt(res);
            return Math.Round(res, 2, MidpointRounding.ToEven);
        }
        if (VectorType == 3)
        {
            res += Math.Pow(vector[0], 2);
            res += Math.Pow(vector[1], 2);
            res += Math.Pow(vector[2], 2);
            res = Math.Sqrt(res);
            return Math.Round(res, 2, MidpointRounding.ToEven);
        }
        else
        {
            return -1;
        }
    }
}