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
        private int size;
        private LinkedList<Hashnode>[] numbers;
        public int Count { get; private set; }
        public HashTable(int size=10)
        {
            this.size = size;
            numbers = new LinkedList<Hashnode>[size];
            
        }
        public int Position(int key)
        {
            int hash = Math.Abs(key)% size;
            return hash;
        }
        public void Add(int key, int data)
        {
            if (Count > size)
                Resize();
            int position = Position(key);
            LinkedList<Hashnode> linkedList = GetLinkedList(position);
            Hashnode numbers = new Hashnode( key,data);
            linkedList.AddLast(numbers);
            Count++;
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
            if(!linkedList.Contains(new Hashnode(key,10)))
            { throw new InvalidOperationException(); }
           
                linkedList.RemoveData(new Hashnode(key,1));
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
            var answer = new HashTable(size>table.size?size:table.size);
           
            foreach(var backet in numbers)
            {
                foreach(var node in backet)
                {
                    if (table.Contains(node.key, node.data))
                        answer.Add(node.key,node.data);
                }
            }
            return answer;
        }

       public void Resize()
        {
            
            LinkedList<Hashnode>[] newNumbers = new LinkedList<Hashnode>[2 * size-1];
            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] = new LinkedList<Hashnode>();
            }
            LinkedList<Hashnode>[] oldNumbers = numbers;
            numbers = newNumbers;
            foreach (var bucket in oldNumbers)
            {
                foreach (var node in bucket)
                {
                    numbers[Position(node.key)].AddLast(node);
                }
            }
        }
        
    }
}
