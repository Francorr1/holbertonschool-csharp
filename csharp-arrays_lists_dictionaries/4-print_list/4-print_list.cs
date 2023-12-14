using System;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < size; i++)
            {
                newList.Add(i);
                Console.Write("{0}", i);
                if (i != size)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
            return newList;
        }
    }
}