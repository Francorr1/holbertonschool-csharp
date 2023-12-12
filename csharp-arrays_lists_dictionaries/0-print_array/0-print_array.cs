using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
            int[] newArray = new int[] {};
            return newArray;
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = i;
                Console.Write("{0} ", i);
                if (i == size - 1)
                {
                    Console.WriteLine();
                }
            }
            return newArray;
        }
    }
}