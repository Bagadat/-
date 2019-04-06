using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Hashnode
    {
        public int key { get; set; }
        public int data { get; set; }
        public Hashnode next;
        public override bool Equals(object obj)
        {
            return this.key == ((Hashnode)obj).key; //base.Equals(obj);
        }
        public Hashnode(int key, int data)
        {
            this.key = key;
            this.data = data;
            next = null; 
        }

       
    }
}
