using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Function that calculates the dot product of two 2D or 3D vectors
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        int Vec1Type = vector1.Count();
        int Vec2Type = vector2.Count();
        double res = 0;
        if (Vec1Type != Vec2Type)
        {
            return -1;
        }
        if (Vec1Type == 2)
        {
            res += vector1[0] * vector2[0];
            res += vector1[1] * vector2[1];
            return res;
        }
        if (Vec1Type == 3)
        {
            res += vector1[0] * vector2[0];
            res += vector1[1] * vector2[1];
            res += vector1[2] * vector2[2];
            return res;
        }
        else
        {
            return -1;
        }
    }
}