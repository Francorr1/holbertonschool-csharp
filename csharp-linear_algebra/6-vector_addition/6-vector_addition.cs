using System;
using System.Collections.Generic;
using System.Linq;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        int Vec1Type = vector1.Count();
        int Vec2Type = vector2.Count();
        if (Vec1Type != Vec2Type)
        {
            double[] res = [-1];
            return res;
        }
        if (Vec1Type == 2)
        {
            double x = vector1[0] + vector2[0];
            double y = vector1[1] + vector2[1];
            double[] res = [x, y];
            return res;
        }
        if (Vec1Type == 3)
        {
            double x = vector1[0] + vector2[0];
            double y = vector1[1] + vector2[1];
            double z = vector1[2] + vector2[2];
            double[] res = [x, y, z];
            return res;
        }
        else
        {
            double[] res = [-1];
            return res;
        }
    }
}