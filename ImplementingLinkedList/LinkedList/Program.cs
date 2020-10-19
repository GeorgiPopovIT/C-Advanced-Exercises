using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            for (int i = 0; i < 20; i++)
            {
                list.AddHead(new Node(i));
            }
            list.PrintList();
        }
    }
}
