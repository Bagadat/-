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

            linkedlist.AddFirst(1);
            linkedlist.AddLast(2);
            
            for (int i = 3;i < 11; i++)
            {
                linkedlist.AddLast(i);
            }
            linkedlist.AddLast(55);

            linkedlist.Remove(3);
            Console.WriteLine(linkedlist.Contains(3));
           

            Console.ReadKey();
        }
    }
}
