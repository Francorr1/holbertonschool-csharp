using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that fids the cross product of 2 3D vectors
    /// </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Count() != 3 || vector2.Count() != 3)
        {
            double[] err = {-1};
            return err;
        }
        double[] res = {0, 0, 0};
        res[0] = (vector1[1] * vector2[2]) - (vector1[2] * vector2[1]);
        res[1] = (vector1[2] * vector2[0]) - (vector1[0] * vector2[2]);
        res[2] = (vector1[0] * vector2[1]) - (vector1[1] * vector2[0]);
        return res;
    }
}