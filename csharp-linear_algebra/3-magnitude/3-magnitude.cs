using System;
using System.Collections.Generic;
using System.Linq;

class Vectormath
{
    public static double Magnitude(double[] vector)
    {
        int res = 0;
        int VectorType = vector.Count();
        if (VectorType == 2)
        {
            res += Math.Pow(vector[0], 2);
            res += Math.Pow(vector[1], 2);
            res = Math.Sqrt(res);
            return res;
        }
        if (VectorType == 3)
        {
            res += Math.Pow(vector[0], 2);
            res += Math.Pow(vector[1], 2);
            res += Math.Pow(vector[2], 2);
            res = Math.Sqrt(res);
            return res;
        }
        else
        {
            return -1;
        }
    }
}