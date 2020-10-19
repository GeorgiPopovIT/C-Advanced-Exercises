using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }
            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node head { get; set; }
        private Node tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                this.head = this.tail = new Node(element);
            }
            else
            {
                var newHead = new Node(element);
                newHead.Next = this.head;
                this.head.Previous = newHead;
                this.head = newHead;
            }
        }
        public void AddLast(T element)
        {
            if (Count == 0)
            {
                this.head = this.tail = new Node(element);
            }
            else
            {
                var newTail = new Node(element);
                newTail.Previous = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }
            Count++;
        }
        public T RemoveFirst()
        {
            if (Count == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            T firstElement = this.head.Value;
            this.head = head.Next;
            if (this.head != null)
            {
                this.head.Previous = null;
            }
            else
            {
                this.tail = null;
            }
            Count--;
            return firstElement;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new ArgumentException("The list is empty");
            }
            var lastElement = this.tail.Value;
            this.tail = tail.Previous;
            if (this.tail != null)
            {
                this.head.Next = null;
            }
            else
            {
                this.tail = null;
            }
            Count--;
            return lastElement;
        }
        public void ForEach(Action<T> action)
        {
            var currNode = this.head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }
        public T[] ToArray()
        {
            T[] array = new T[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.Next;
                counter++;
            }
            return array;
        }
    }
}
