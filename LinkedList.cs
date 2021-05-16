using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/**
    A singly linked list.
    Each element contains data and link to the next node.
    Final node references to null.
*/

/**
    Author: Matsvei Hauryliuk
    Student at VUT FIT
*/

namespace LinkedList        
{
    class Program
    {
        
        class LinkedListNode
        {
            public int data;                                            //value of the node
            public LinkedListNode next;

            public LinkedListNode(int x)
            {
                data = x;
                next = null;
            }

        }

        class LinkedList
        {
            int count;                                                  //keeps track of how much data is in the linked list
            LinkedListNode head = null;                                 //beginning of the list

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)                        //adds a node at the beginning
            {
                LinkedListNode node = new LinkedListNode(data);
                node.next = head;      
                head = node;  
                count++;
            }

            public void AddNodeToEnd(int data)                          //adds a node at the end
            {
                LinkedListNode nodeToAdd = new LinkedListNode(data);    //node that will be added to the list
                LinkedListNode runner = head;                           //iterator to find last member of the list
                while(runner != null)
                {
                    if(runner.next == null)
                    {
                        runner.next = nodeToAdd;
                        nodeToAdd.next = null;
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

            public void DeleteNodeFromEnd()
            {
                LinkedListNode current = head;
                while(current != null)
                {
                    if(current.next.next == null)
                    {
                        current.next = null;        
                    }
                    current = current.next;
                }  
                count--;         
            }

            public void PrintList()                                     //iterates through list and prints the data
            {
                LinkedListNode runner = head;
                while(runner != null)                                   //checking if node isn't null before accessing the data within it
                {
                    Console.WriteLine(runner.data); 
                    runner = runner.next;                               //moves runner forward       
                }        
            }   

        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(90);
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(11);
            linkedList.AddNodeToFront(-10);
            linkedList.AddNodeToFront(2);
            linkedList.AddNodeToEnd(4);
            linkedList.DeleteNodeFromBeginning();
            linkedList.DeleteNodeFromEnd();
            linkedList.PrintList();                                     
        }


    }

}