using System;

class Program
{
    static void Main(string[] args)
    {
        for (int num = 0; num <= 9; num++)
        {
            for (int num1 = num + 1; num1 <= 9; num1++)
            {
                Console.Write("{0}{1}", num, num1);
                if (!(num == 8 && num1 == 9))
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
    }
}