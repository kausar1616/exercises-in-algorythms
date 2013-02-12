using System;
using MyQueue;


class Program
{
    static void Main(string[] args)
    {
        Queue<int> test = new Queue<int>();
        test.Insert(5);
        test.Insert(6);
        Console.WriteLine(test.Remove());
        test.Insert(7);
        Console.WriteLine(test.Remove());
        test.Insert(8);
        test.Insert(9);

        Console.WriteLine(test.Remove());
        Console.WriteLine(test.Remove());
        Console.WriteLine(test.Remove());




        Queue<int> newQueue = new Queue<int>();
        for (int i = 0; i < 15000; i++)
        {
            newQueue.Insert(i);
        }
        for (int i = 0; i < 15000; i++)
        {
            //Console.WriteLine(newQueue.Remove());
            newQueue.Remove();
        }
    }
}

