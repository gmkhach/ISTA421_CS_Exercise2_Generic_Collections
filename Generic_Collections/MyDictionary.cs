using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    class MyDictionary<T>
    {
        private KeyValue<T>[] arr = new KeyValue<T>[10];
        private int count = 0;

        public T this[string key]
        {
            get
            {
                foreach (KeyValue<T> x in arr)
                {
                    if (x.Key == key)
                    {
                        return x.Value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set 
            {
                bool isNew = true;
                for (int i = 0; i < count; i++)
                {
                    if (arr[i].Key == key)
                    {
                        arr[i] = new KeyValue<T>(key, value);
                        isNew = false;
                    }
                }
                if (isNew && count != 10)
                {
                    arr[count++] = new KeyValue<T>(key, value);
                }
                else
                {
                    throw new Exception("\nMaximum number of items is reached.");
                }
            }
        }
    }
}
