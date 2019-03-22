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

            if (tail == null)
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
                for (int i = 0; i < count; i++)
                {
                    if (index == i)
                    {
                        if (current != null)
                        {
                            current.Previous.Next = current.Next;

                            current.Next.Previous = current.Previous;
                        }
                        else if(current.Next==null)
                        {
                            tail = current.Previous;
                        }
                        else if(current.Previous==null)
                        {
                            head = current.Next;
                        }
                            
                    }
                    current = current.Next;
                }
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
            else if(index==0)
            {
                AddFirst(data);
            }
            else if(index==count)
            {
                AddLast(data);
            }
            else
            {
                current = head;

                for (int i = 0; i < count; i++)
                {
                    if (index == i)
                    {
                        if (current != null )
                        {
                            current.Previous.Next = knot;

                            knot.Previous = current.Previous;

                            current.Previous = knot;

                            knot.Next = current;
                        }
                        else
                            throw new NullReferenceException();
                    }
                    current = current.Next;
                }
            }
            count++;
        }

        public int Get(int index)
        {
            if (head == null)
                return -2;
            current = head;
           
            for(int i =0;i<count;i++)
            {
                if (index == i)
                    return current.data;
                current = current.Next;
            }
            return -1;
        }
        
    }
}
