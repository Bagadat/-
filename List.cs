using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class DoubleK
    {
        public int data { get; set; }
        public DoubleK (int data)
        {
           this.data = data;
        }

        public DoubleK Next { get; set; }
        public DoubleK Previous { get; set; } 
            
    }
}
