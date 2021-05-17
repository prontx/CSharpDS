using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/**
    A doubly linked list.
    Each element contains data and link to the next and previous nodes.
    Final node references to null.
*/

/**
    Author: Matsvei Hauryliuk
    Student at VUT FIT
*/

namespace DoubleList
{
    class Program 
    {
        class DoubleListNode
        {
            public int data;                                              //value of the node
            public DoubleListNode previous;
            public DoubleListNode next;

            public DoubleListNode(int x)
            {
                data = x;
                previous = null;
                next = null;
            }    
        }

        class DoubleList
        {
            int count;                                                    //counts elements in the list
            DoubleListNode head = null;                                   //beginning of the lish

            public DoubleList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)                           //adds at the beginning
            {
                DoubleListNode node = new DoubleListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void AddNodeToEnd(int data)                             //adds to the end
            {
                DoubleListNode node = new DoubleListNode(data);
                DoubleListNode runner = head;
                while(runner != null)
                {
                    if(runner.next == null)
                    {
                        runner.next = node;
                        node.previous = runner;
                        node.next = null;
                        break;
                    }   
                    runner = runner.next;     
                }
                count++;         
            }

            public void DeleteNodeFromBeginning()
            {
                head = head.next;
            }

            public void PrintList()
            {
                DoubleListNode runner = head;
                DoubleListNode prev = null;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    prev = runner;
                    runner.previous = prev;
                    runner = runner.next;
                }
            }
        }

        static void Main(string[] args)
        {
            DoubleList doubleList = new DoubleList();
            doubleList.AddNodeToFront(1); 
            doubleList.AddNodeToFront(2); 
            doubleList.AddNodeToFront(3); 
            doubleList.AddNodeToFront(4);
            doubleList.AddNodeToEnd(5);
            doubleList.DeleteNodeFromBeginning();
            doubleList.PrintList();        
        }
    }
}