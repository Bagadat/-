﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable hash = new HashTable(3);
            hash.Add(1, 23);
           
            hash.Add(3, 25);
            hash.Add(6, 34);
            Console.WriteLine(hash.Contains(2));
            Console.WriteLine(hash.Contains(3));
           // hash.Remove(3);
           
            
            HashTable hashTable = new HashTable(4);
            hashTable.Add(1, 23);

            hashTable.Add(3, 25);
            hashTable.Add(7, 56);
            HashTable newHashTable = hash.Intersect(hashTable);
            Console.WriteLine(newHashTable.Contains(7));








            Console.ReadKey();



        }
    }
}
