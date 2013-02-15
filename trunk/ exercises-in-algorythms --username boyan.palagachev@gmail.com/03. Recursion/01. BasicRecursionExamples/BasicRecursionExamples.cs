using System;

class BasicRecursionExamples
{
    static void Main()
    {
        //Console.WriteLine(Factorial(5));
        Console.WriteLine(Fibonacci(11));
    }

    // Simple program to illustrate the basic features of recursive program
    static int Factorial(int num)
    {
        if (num == 1)
        {
            return 1;
        }
        else
        {
            return num * Factorial(num - 1);
        }
    }
    // Very ineffective. Recursion should not be used here. Extensive recomputing!
    static int Fibonacci(int num)
    {
        if (num <=1 )
        {
            return 1;
        }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}