using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollections
{
    public struct NodeStruct<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public NodeStruct(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
