using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        Console.Write("The last digit of {0} is ", number);
	    if (number < 0)
        {
            number *= -1;
            bool neg = true;
        }
        int lastNumber = number % (10);
        if (neg == true)
        {
            lastNumber *= -1;
        }
        if (lastNumber > 5)
        {
            Console.WriteLine("{0} and is greater than 5", lastNumber);
        }
        else if (lastNumber == 0)
        {
            Console.WriteLine("{0} and is 0", lastNumber);
        }
        else if (lastNumber < 6 && lastNumber != 0)
        {
            Console.WriteLine("{0} and is less than 6 and not 0", lastNumber);
        }
    }
}