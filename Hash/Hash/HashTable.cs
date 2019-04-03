using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List;


namespace Hash
{
    class HashTable
    {
        private int  size;
        private LinkedList<Hashnode>[] numbers;
        public HashTable(int size)
        {
            this.size = size;
            numbers = new LinkedList<Hashnode>[size];
            
        }
        public int Position(int key)
        {
            int hash = Math.Abs(key % size);
            return hash;
        }
        public void Add(int key, int data)
        {
            int position = Position(key);
            LinkedList<Hashnode> linkedList = GetLinkedList(position);
            Hashnode numbers = new Hashnode( key,data);
            linkedList.AddLast(numbers);
        }

        public bool Contains(int key)
        {
            int position = Position(key);
            LinkedList<Hashnode> linkedList = GetLinkedList(position);
            foreach (Hashnode number in linkedList  )
            {
                if(number.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }
        
        public bool Contains(int key, int data)
        {
            int position = Position(key);
            LinkedList<Hashnode> linkedList = GetLinkedList(position);
            foreach (var item in linkedList)
            {
                if(item.key.Equals(key))
                {
                    if (item.data.Equals(data))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Remove(int key)
        {
            int position = Position(key);
            LinkedList<Hashnode> linkedList = GetLinkedList(position);
            bool found = false;
            Hashnode hashnode = default(Hashnode);
            foreach(Hashnode node in linkedList)
            {
                if (node.key.Equals(key))
                {
                    found = true;
                    hashnode = node;
                }
            }

            if(found)
            {
                linkedList.Remove(hashnode.data);
            }
        }

        public LinkedList<Hashnode> GetLinkedList(int position)
        {
            LinkedList<Hashnode> linkedList = numbers[position];
            if(linkedList == null)
            {
                linkedList = new LinkedList<Hashnode>();
                numbers[position] = linkedList;
            }
            return linkedList;
        }

        public HashTable Intersect(HashTable table)
        {
          
            for ()
            {
                if(this.Contains())
            }
        }
        e
       
    }
}
