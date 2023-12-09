using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int space = 0;
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int x = 0; x <= space; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("\\");
                space++;
            }
        }
        else
        {
            Console.WriteLine();
        }
    }
}