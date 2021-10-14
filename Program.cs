using System;
using System.Collections.Generic;
using System.Collections;


namepace Demo_Collection
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            // var MYLIST = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //foreach (var item in MYLIST) ...

            //var MyFruits = new List<string> { "mango", "bananna", "grapes" };
            //foreach(var item in MyFruits)
            //{
            //  Console.WriteLine(item);
            // }

            Stack<string> number = new Stack<string>();
            number.Push("one");
            number.Push("Two");
            number.Push("Three");
       


            
            foreach (var item in number)
            {
                Console.WriteLine("Following are the Contents pf Collection\t {0}\n", item);
            }

            //remove an element

            Console.WriteLine("Removing  top of the stack \n {0}", number.Pop());





            //Queue<int> MyQue = new Queue<int>();
           // MyQue.Enqueue = 120;
            //yQue.Enqueue = 220;
            //MyQue.Enqueue = 330;

           // foreach(var iteam in MyQue)
            //{
            //Console.WriteLine();
           // }

        Hashtable MyHashTable = new Hashtable();
        MyHashTable.Add(01, "Delhi");
        MyHashTable.Add(02, "Guntur");
        MyHashTable.Add(03, "patna");
        Console.WriteLine("Total content of the HashTable is {0}", MyHashTable.Count);
        foreach(var item in MyHashTable)
        {
            Console.WriteLine("Content of the table is {0}", item);
        }

        }
    }
}


