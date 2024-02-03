using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 2, 5, 0 }, { 0, 4, -1 } };

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}