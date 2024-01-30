using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// class VectorMath
/// </summary>
class VectorMath
{
    /// <summary>
    /// Function that multiplies 2D or 3D vectors by a scalar
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int VecType = vector.Count();
        if (VecType == 2)
        {
            double[] res = {vector[0] * scalar, vector[1] * scalar};
            return res;
        }
        if (VecType == 3)
        {
            double[] res = {vector[0] * scalar, vector[1] * scalar, vector[2] * scalar};
            return res;
        }
        else
        {
            double[] res = {-1};
            return res;
        }
    }
}