﻿using System;

class Program
{
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                    if (i != 100)
                    {
                        Console.Write(" ");
                    }
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    if (i != 100)
                    {
                        Console.Write(" ");
                    }
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    if (i != 100)
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write("{0}", i);
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
}