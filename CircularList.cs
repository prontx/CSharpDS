using System;

/**
    A circular linked list.
    Tail points to head and vice versa.
*/

/**
    Author: Matsvei Hauryliuk
    Student at VUT FIT
*/

namespace CircularList
{

    class Program
    {
        class CircularListNode
        {
            public int data;
            public CircularListNode previous;
            public CircularListNode next;

            public CircularListNode(int x)
            {
                data = x;
                previous = null;
                next = null;
            }
        }

        class CircularList
        {
            int count;
            CircularListNode head = null;
            CircularListNode tail = null;

            public CircularList()
            {
                head = null;
                tail = null;
                count = 0;
            }

            public void InsertAtBeginning(int data)
            {
                CircularListNode node = new CircularListNode(data);
                node.next = head;
                node.previous = tail;
                head = node;
                count++;
                return;
            }

            public void InsertAtMiddle(int data)
            {
                CircularListNode node = new CircularListNode(data);
                int index = count / 2;
                int i = 1;
                CircularListNode curr = head;
                while(curr != null)
                {
                    if (i == index)
                    {
                        node.next = curr.next;
                        curr.next = node;
                        node.previous = curr;
                        curr = node;
                        i++;
                        break;
                    }
                    curr = curr.next;
                    i++;
                }
                count++;
                return;    
            }

            public void InsertAtEnd(int data)
            {
                CircularListNode node = new CircularListNode(data);
                CircularListNode curr = head;
                while(curr != tail)
                {
                    if(curr.next == tail)
                    {
                        curr.next = node;
                        node.next = tail;
                        node.previous = curr;
                        curr = node;
                        break;
                    }
                    curr = curr.next;                    
                }
                count++;
                return;
            }

            public CircularListNode Search(int key)
            {
                CircularListNode curr = head;
                while(curr != tail)
                {
                    if(curr.data == key)
                    {
                        return curr;
                    }        
                    curr = curr.next;    
                }
                return null;    
            }

            public void DeleteFromBeginning()
            {
                head = head.next;
                count--;
                return;
            }

            public void DeleteFromEnd()
            {
                if(tail == null)
                {
                    return;
                }

                if(tail.next == tail)
                {
                    tail = null;
                    return;
                }

                CircularListNode curr = tail.next;
                while(curr.next != tail)
                {
                    curr = curr.next;
                }
                
                curr.next = tail.next;
                tail = curr;
                return;
            }

            public void PrintList()
            {
                CircularListNode curr = head;
                while(curr != tail)
                {
                    Console.WriteLine(curr.data);
                    curr = curr.next;
                }
            }

        }

        static void Main(string[] args)
        {
            CircularList list = new CircularList();
            list.InsertAtBeginning(4);
            list.InsertAtBeginning(3);
            list.InsertAtMiddle(2);
            list.InsertAtBeginning(7);
            list.InsertAtEnd(9);
            list.InsertAtEnd(6);
            list.InsertAtMiddle(1);
            list.DeleteFromBeginning();
            list.DeleteFromBeginning();
            list.DeleteFromEnd();
            list.PrintList();  
            Console.WriteLine(list.Search(9)); 
            Console.WriteLine(list.Search(13));                      
        }

    }

}