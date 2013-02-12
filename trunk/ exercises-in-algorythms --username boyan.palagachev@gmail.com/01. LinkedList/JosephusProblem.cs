using System;
using MyLinkedList;

class JosephusProblem
{
    static void Main()
    {
        // Josephus Problem
        Console.WriteLine("N: ");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("M: ");
        int M = int.Parse(Console.ReadLine());
        MyLinkedList<int> circle = new MyLinkedList<int>();
        Console.WriteLine(new string('-', 50));
        for (int i = N; i > 0; i--)
        {
            circle.InsertAfter(circle.Head, i);
        }
        int index = 0;
        //Node current = circle.TargetNextPosition(circle.Head);
        Node<int> current = circle.Head;

        while (!circle.IsEmply)
        {

            index++;

            if (index % 5 == 0)
            {
                Console.WriteLine(circle.GetNext(current).Value);
                circle.DeleteNext(current);
                index = 0;
                continue;
            }
            current = circle.GetNext(current);



        }

    }
}





