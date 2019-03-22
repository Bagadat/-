using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class LinkedList
    {
        public DoubleK head;
        public DoubleK current;
        public DoubleK tail;
        int count = 0;

        public void AddLast(int data)
        {
            DoubleK knot = new DoubleK(data);

            if (head == null)
                head = knot;
            else
            {
                tail.Next = knot;
                knot.Previous = tail;
            }
            tail = knot;
            count++;
        }

        public void AddFirst(int data)
        {
            DoubleK knot = new DoubleK(data);
            DoubleK current = head;
            knot.Next = current;
            head = knot;
            if (count == 0)
                tail = head;
            else
                current.Previous = knot;

            count++;
        }

        public void Remove(int index)
        {
            current = head;
            if (index > count)
                throw new InvalidOperationException();
            else
            {
                

                while (current != null && count!=index)
                {
                    current = current.Next;
                    
                }
                if (current != null && count==index)
                {
                    current.Previous.Next = current.Next;

                    current.Next.Previous = current.Previous;
                }
                else
                    throw new NullReferenceException();
                
            }
            count--;
           
        }

        public bool Contains(int data)
        {
            
            current = head;
            while (current != null)
            {
                if (current.data.Equals(data))

                    return true;

                current = current.Next;
            }
            return false;
        }

        public void InsertIndex(int index,int data)
        {
            DoubleK knot = new DoubleK(data); 
            if (index > count)
                throw new InvalidOperationException();
            else
            {
                
                current = head;
                while(current != null && count!=index)
                {
                    current = current.Next;
                    
                }
                
               
                if (current != null && count==index)
                {
                    current.Previous.Next = knot;

                    knot.Previous = current.Previous;

                    current.Previous = knot;

                    knot.Next = current;
                }
            }
            count++;
        }

        public int Get(int index)
        {
            current = head;
            while (count != index)
            {
                current = current.Next;
                if(count==index)
                    return current.data;
            }
            return -1;
        }
        
    }
}
