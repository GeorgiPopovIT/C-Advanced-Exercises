using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddHead(Node newHead)
        {
            if (Head == null)
            {
                Head = newHead;
                Tail = newHead;
            }
            else
            {
                newHead.Next = Head;
                Head.Previous = newHead;
                Head = newHead;
            }
        }
        public void AddLast(Node newTail)
        {
            if (Tail == null)
            {
                Head = newTail;
                Tail = newTail;
            }
            else
            {
                newTail.Previous = Tail;
                Tail.Next = newTail;
                Tail = newTail;
            }
        }
        public Node Pop()
        {
            var head = this.Head;
            this.Head = this.Head.Next;
            return head;
        }
        public int Peek()
        {
            return this.Head.Value;
        }
        public void ForEach(Action<int> action)
        {
            var currNode = this.Head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }
        public void PrintList()
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
