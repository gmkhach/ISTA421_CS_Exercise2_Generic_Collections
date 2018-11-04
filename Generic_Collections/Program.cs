using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    struct KeyValue<T>
    {
        public KeyValue(string key, T value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }
        public T Value { get; }
    }

    class Program
    {
        static void Main()
        {
            var d = new MyDictionary<int>();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            d["Cats"] = 42;
            d["Dogs"] = 17;
            Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
        }
    }
}
