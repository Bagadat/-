using System;
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
            for (int i = 0; i < 10; i++)
            {
                Console.Write(linkedlist.Get(i));

            }
            Console.WriteLine();

            //linkedlist.AddLast(55);
            //linkedlist.InsertIndex(1, 15);
            //Console.WriteLine(linkedlist.Get(1));
            //linkedlist.Remove(1);
            //Console.WriteLine(linkedlist.Get(1));
            LinkedList linkedlist1 = new LinkedList();
            for (int i = 0; i < 4; i++)
            {
                linkedlist1.AddLast(i);
                
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(linkedlist1.Get(i));

            }
            Console.WriteLine();
            LinkedList linkedlist2 = new LinkedList();
            linkedlist2.Intersect(linkedlist, linkedlist1, linkedlist2);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(linkedlist2.Get(i));
            }
            //  Console.WriteLine(linkedlist.Contains(31));


            Console.ReadKey();
        }
    }
}
