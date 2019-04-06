using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class LinkedList<T>:IEnumerable<T>
    {
        private DoubleK<T> head;
        
        private DoubleK<T> tail;
        private int count = 0 ;

        public void AddLast(T data)
        {
            DoubleK<T> knot = new DoubleK<T>(data);

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

        public void AddFirst(T data)
        {
            DoubleK<T> knot = new DoubleK<T>(data);
            DoubleK<T> current = head;
            knot.Next = current;
            head = knot;
            if (count == 0)
                tail = head;
            else
                current.Previous = knot;

            count++;
        }
        public void RemoveData(T data)
        {
            for (DoubleK<T> current = head; current!=null;current= current.Next )
            {
                 if (current.data.Equals(data))
                 {
                    if (current == head && current == tail)
                    {
                        head = null;
                        tail = null;
                    }
                    else
                    {
                        if (current != head) current.Previous.Next = current.Next;
                        if (current != tail) current.Next.Previous = current.Previous;
                    }
                    break;
                 }
            }
            count--;
        }

        public void RemoveIndex(int index)
        {
             
            DoubleK<T> current = head;
           
            if (index > count)
                throw new IndexOutOfRangeException("Вышел за пределы списка, МУДИЛА!!!");

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

        public bool Contains(T data)
        {
          
                for (DoubleK<T> current = head; current != null; current = current.Next)
                {
                    if (current.data.Equals(data))

                        return true;
                }
            
            return false;
        }

        public void InsertIndex(int index,T data)
        {
            DoubleK<T> knot = new DoubleK<T>(data); 
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
                DoubleK<T> current = head;

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

        public T Get(int index)
        {
            
            DoubleK<T> current = head;
            if (head == null)
                throw new IndexOutOfRangeException();
            if (index > count || index < 0)
                throw new IndexOutOfRangeException();
            
            for(int i =0;i!=index;i++)
            {
                current = current.Next;
            }

            return current.data;
        }

        public LinkedList<T> Intersect(LinkedList<T> list,LinkedList<T> list1)
        {
            for(DoubleK<T> current = head; current != null; current = current.Next)
            {
                if (list.Contains(current.data))
                {
                    list1.AddLast(current.data);
                }
            }
            return list1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleK<T> current = head;
            while (current != null)
            {
                yield return current.data;
                current = current.Next;
            }
        }




    }

}

