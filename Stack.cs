using System;
using static System.Linq.Enumerable;

namespace Stack
{
    class Stack
    {
        static int MAX_SIZE = 32;
        int peak;
        int[] stack = new int[MAX_SIZE];

        public Stack()
        {
            peak = -1;
        }

        public void Push(int data)
        {
            if(peak >= MAX_SIZE)            //checking whether oveflow has occurred
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                peak++;
                stack[peak] = data;
            }
        }

        public int Pop()
        {
            if(peak < 0)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            else
            {
                peak--;
                int value = stack[peak];
                return value;
            }
        }

        public void Peek()
        {
            if(peak < 0)
            {
                Console.WriteLine("Stack underflow");
            }      
            else
            {
                Console.WriteLine("The top of the stack is : {0}", stack[peak]);
            }
        }

        public int isEmpty()                //returns 0 if stack isn't empty, 1 if is
        {
            int i = stack.Count();          //counts elements of the stack
            if(i == 0)
            {
                return 1;
            }
            return 0;
        }

        public int isFull()                 //returns 0 if stack isn't full, 1 if is
        {
            int i = stack.Count();          //counts elements of the stack
            if(i == MAX_SIZE)               //checking if counters match
            {
                return 1;                
            }     
            return 0;
        }

        public void PrintStack()
        {
            for (int i = peak; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }     
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(2);
            myStack.Push(11);
            myStack.Pop();
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("----------");
            Console.WriteLine(myStack.isFull());
            Console.WriteLine(myStack.isEmpty());
        }

    }
}