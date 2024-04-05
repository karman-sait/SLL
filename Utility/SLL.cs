// Name: Kiru and Karman, Date: 4/4/23, Program Description: Implementation of a linked list ADT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    // Singly Linked list
    public class SLL : ILinkedListADT
    {
        private Node head; //first node
        private int count; //no. of elements in the list

        public bool IsEmpty() // sees if list is empty
        {
            return head == null; 
        }

        public void Clear() // clears the list
        {
            head = null;
            count = 0;
        }

        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
            count++;
        }

        public void Add(User value, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                AddFirst(value);
                return;
            }

            Node newNode = new Node(value);
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            count++;
        }

        public void Replace(User value, int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Value = value;
        }

        public int Count()
        {
            return count;
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                return;
            }

            head = head.Next;
            count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }

            if (count == 1)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
            count--;
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= count)
            {
                return;
            }

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            count--;
        }

        public User GetValue(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public int IndexOf(User value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool Contains(User value)
        {
            return IndexOf(value) != -1;
        }

        private class Node
        {
            public User Value { get; set; }
            public Node Next { get; set; }

            public Node(User value)
            {
                Value = value;
                Next = null;
            }
        }

        //Addtional funtion asked for. I went with joining tje lists 
        public SLL Join(params SLL[] lists)
        {
            SLL result = new SLL();
            foreach (SLL list in lists)
            {
                Node current = list.head;
                while (current != null)
                {
                    result.AddLast(current.Value);
                    current = current.Next;
                }
            }
            return result;
        }

        public User GetValueAtIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public int IndexOfValue(User value)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }

        public bool ContainsValue(User value)
        {
            return IndexOfValue(value) != -1;
        }
    }
}

