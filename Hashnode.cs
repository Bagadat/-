using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    class Hashnode<K,D>
    {
        public K key { get; set; }
        public D data { get; set; }
        public override bool Equals(object obj)
        {
            return this.key.Equals (((Hashnode<K,D>)obj).key); //base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return key.GetHashCode();
        }
        public Hashnode(K key, D data=default(D))
        {
            this.key = key;
            this.data = data;
        }
    }
}
