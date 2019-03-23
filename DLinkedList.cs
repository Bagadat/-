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
        private DoubleK head;
        
        private DoubleK tail;
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
             
            DoubleK current = head;
           
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
          
                for (DoubleK current = head; current != null; current = current.Next)
                {
                    if (current.data.Equals(data))

                        return true;
                }
            
            return false;
        }

        public void InsertIndex(int index,int data)
        {
            DoubleK knot = new DoubleK(data); 
            if (index > count || index < 0)
                throw new IndexOutOfRangeException("Вышел за пределы списка, МУДИЛА!!!");
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
                DoubleK current = head;

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
            DoubleK current = head;
            if (head == null)
                throw new IndexOutOfRangeException();
            if (index > count || index < 0)
                throw new IndexOutOfRangeException();
            
            for(int i =0;i<count;i++)
            {
                if (index == i)
                    return current.data;
                current = current.Next;
            }

            return 404;
        }

        public void Intersect(LinkedList list,LinkedList list1,LinkedList list2)
        {
            for (int i = 0; i < list.count; i++)
            {
                for (int j = 0; j < list1.count; ++j)
                {
                    if(list.Get(i)==list1.Get(j))
                    {
                        list2.AddLast(list.Get(i));
                    }
                }
            }
        }
        
    }
}
