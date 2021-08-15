using System;
using System.Collections.Generic;
using System.Text;

namespace DSPrograms
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node(T value)
        {
            this.value = value;
            this.Next = null;
        }
    }
    public class UnOrderedList<T>
    {
        private Node<T> head;

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.head == null)
            {
                this.head = node;
            }
            else 
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }

        public void DeleteNode(T value)
        {
            if (head == null)
            {
                Console.WriteLine(" No element to delete.. ");
            }
            else if (head.value.Equals(value))
            {
                head = head.Next;
            }
            else
            {
                Node<T> prev = head, temp = head;
                while (temp != null && !(temp.value.Equals(value)))
                {
                    prev = temp;
                    temp = temp.Next;
                }
                if (temp.value.Equals(value))
                {
                    prev.Next = temp.Next;
                    Console.WriteLine(" Element : {0} is Removed..", value); ;
                    temp.Next = null;
                }
            }
        }

        //method to find/search for the element
        public int SearchNode(T value)
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null && !(temp.value.Equals(value)))
                {
                    temp = temp.Next;
                }
                if (temp.value.Equals(value))
                {
                    return 1;
                }
                return 0;
            }
        }

        //method to display the elements 
        public string Process()
        {
            Node<T> temp = head;
            string data = "";
            if (head == null)
            {
                Console.WriteLine(" List is empty..");
            }
            else
            {
                while (temp.Next != null)
                {
                    data = data + temp.value + " ";
                    temp = temp.Next;
                }
                data = data + temp.value;
            }
            return data;
        }
    }
}
