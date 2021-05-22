using System;
using static System.Linq.Enumerable;

/**
    A queue implementation(FIFO).
    Supports two operations: Enqueue and Dequeue.    
*/

/**
    Author: Matsvei Hauryliuk
    Student at VUT FIT
*/

namespace Queue
{
    class Queue
    {
        static int MAX_QUEUE_SIZE = 64;
        int beginningIndex, endIndex = 0;
        int count = 0;

        int[] q = new int[MAX_QUEUE_SIZE];

        public Queue()
        {
            beginningIndex = endIndex = -1;
        }

        public void Enqueue(int data)                                   //Inserts at end
        {
            if(beginningIndex >= MAX_QUEUE_SIZE || endIndex >= MAX_QUEUE_SIZE)
            {
                Console.WriteLine("Queue out of bounds");
                return;
            }

            else
            {
                if(count == 0)                                          //checking if the queue is empty
                {
                    ++beginningIndex;                                   //setting the beginning
                    endIndex = beginningIndex;
                }  

                else
                {
                    ++endIndex;                                         //setting the end if there's more than one element
                }

                q[endIndex] = data;                                     //adding the new element
                count++;
            }
            return;
        }

        public void Dequeue()                                           //Deletes from beginning
        {
            if(beginningIndex < 0 || endIndex < 0)
            {
                Console.WriteLine("Out of queue bounds");
                return;
            }

            else
            {
                MAX_QUEUE_SIZE--;                                       //decrementing array size
                int[] nq = new int[MAX_QUEUE_SIZE];
                for(int i = 1; i < MAX_QUEUE_SIZE; i++)
                {
                    nq[i - 1] = q[i];
                }
                q = nq; 
                count--;
            }
            return;
        }

        public void PrintQueue()
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(q[i]);
            }
            return;
        }
    }   

    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(500);
            q.Enqueue(-19);
            q.Enqueue(56);
            q.Enqueue(87);
            q.Enqueue(1);
            q.Enqueue(5);
            q.Dequeue();
            q.Dequeue();
            q.PrintQueue();
        }
    } 
}