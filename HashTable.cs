using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List;


namespace Hash
{
    class HashTable<K, D>
    {
        private int size;
        private LinkedList<Hashnode<K, D>>[] numbers;
        public int Count { get; private set; }
        public HashTable(int size = 10)
        {
            this.size = size;
            numbers = new LinkedList<Hashnode<K, D>>[size];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new LinkedList<Hashnode<K, D>>();
            }
        }



        public int Position(K key)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }
        public void Add(K key, D data)
        {
            if (Count > size)
                Resize();
            int position = Position(key);
            LinkedList<Hashnode<K, D>> linkedList = GetLinkedList(position);
            Hashnode<K, D> numbers = new Hashnode<K, D>(key, data);
            linkedList.AddLast(numbers);
            Count++;
        }

        public bool Contains(K key)
        {
            int position = Position(key);
            LinkedList<Hashnode<K, D>> linkedList = GetLinkedList(position);
            foreach (Hashnode<K, D> number in linkedList)
            {
                if (number.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(K key, D data)
        {
            int position = Position(key);
            LinkedList<Hashnode<K, D>> linkedList = GetLinkedList(position);
            foreach (var item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    if (item.data.Equals(data))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Remove(K key)
        {
            int position = Position(key);
            LinkedList<Hashnode<K, D>> linkedList = GetLinkedList(position);
            if (!linkedList.Contains(new Hashnode<K, D>(key)))
            { throw new InvalidOperationException(); }

            linkedList.RemoveData(new Hashnode<K, D>(key));
        }

        public LinkedList<Hashnode<K, D>> GetLinkedList(int position)
        {
            LinkedList<Hashnode<K, D>> linkedList = numbers[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<Hashnode<K, D>>();
                numbers[position] = linkedList;
            }
            return linkedList;
        }

        public HashTable<K, D> Intersect(HashTable<K, D> table)
        {
            var answer = new HashTable<K, D>(size > table.size ? size : table.size);

            foreach (var backet in numbers)
            {
                foreach (var node in backet)
                {
                    if (table.Contains(node.key, node.data))
                        answer.Add(node.key, node.data);
                }
            }
            return answer;
        }

        public void Resize()
        {

            LinkedList<Hashnode<K, D>>[] newNumbers = new LinkedList<Hashnode<K, D>>[2 * size];

            for (int i = 0; i < newNumbers.Length; i++)
            {
                newNumbers[i] = new LinkedList<Hashnode<K, D>>();
            }

            LinkedList<Hashnode<K, D>>[] oldNumbers = numbers;

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
     



