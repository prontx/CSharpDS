using System;
using static System.Linq.Enumerable;
using System.Collections.Generic;

/**
    An array implementation.
    Supports the following operations:
    Traverse, SearchByValue, SearchByIndex,
    Update, Insert, Delete.
*/

/**
    Author: Matsvei Hauryliuk
    Student at VUT FIT
*/


namespace Array
{
    class Array
    {

        static int MAX_ARRAY_SIZE = 50;
        int count = 0;

        int[] arr = new int[MAX_ARRAY_SIZE];

        public Array()
        {
            count = -1;
        }
        
        public void Traverse()
        {
            for(int i = 0; i <= count; i++)
            {
                Console.WriteLine(arr[i]);          //prints array elements
            }
            return;
        }

        public int SearchByValue(int value)
        {
            for(int i = 0; i < count; i++)
            {
                if(arr[i] == value)
                {
                    return i;
                }
            }   
            return 0;
        } 

        public int SearchByIndex(int index)
        {
            for(int i = 0; i < count; i++)
            {
                if(i == index)
                {
                    return arr[i];
                }
            }
            return 0;
        }

        public void Update(int index, int value)
        {
            for(int i = 0; i < count; i++)
            {
                if(i == index)
                {
                    arr[i] = value;
                }
            }
            return;
        }

        public void Insert(int value)
        {
            List<int> arrList = new List<int>();
            for(int i = 0; i < count; i++)
            {
                arrList.Add(arr[i]);
            }
            arrList.Add(value);
            arr = arrList.ToArray();
            count++;
        }

        public void Delete(int value)
        {
            int[] newArr = new int[49];
            for(int i = 0; i < count; i++)
            {
                if(arr[i] == value)
                {
                    continue;
                }
                newArr[i] = arr[i];                 //copying to second array except last element
            }
            arr = newArr;
            count--;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Array a = new Array();
            a.Insert(4);
            a.Insert(100);
            a.Insert(-10);
            a.Insert(444);
            a.Insert(11);
            a.Insert(1023);
            a.Insert(89);
            a.Insert(56);
            a.Insert(23);
            a.Delete(100);
            a.Update(0, 5);
            Console.WriteLine(a.SearchByValue(-10));
            Console.WriteLine(a.SearchByIndex(5));
            a.Traverse();   
        }
    }
}