using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class DoubleK<T>
    {
        public T data { get; set; }
        public DoubleK (T data)
        {
           this.data = data;
        }

        public DoubleK<T> Next { get; set; }
        public DoubleK<T> Previous { get; set; } 
            
    }
}
