﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();

            for (int i = 1;i < 11; i++)
            {
                linkedlist.AddLast(i);
            }
            linkedlist.AddLast(55);
            linkedlist.InsertIndex(1, 15);
            Console.WriteLine(linkedlist.Get(1));
            linkedlist.Remove(1);
            Console.WriteLine(linkedlist.Get(1));
            //  Console.WriteLine(linkedlist.Contains(31));


            Console.ReadKey();
        }
    }
}
