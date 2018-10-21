using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    struct KeyValue
    {
        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public readonly string key;
        public readonly object value;
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
