using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStore
{
    class MyDictionary
    {
        private KeyValue[] arr = new KeyValue[10];
        private int count = 0;

        public object this[string key]
        {
            get
            {
                foreach (KeyValue x in arr)
                {
                    if (x.key == key)
                    {
                        return x.value;
                    }
                }
                throw new KeyNotFoundException();
            }
            set 
            {
                bool isNew = true;
                for (int i = 0; i < count; i++)
                {
                    if (arr[i].key == key)
                    {
                        arr[i] = new KeyValue(key, arr[i].value);
                        isNew = false;
                    }
                }
                if (isNew && count != 10)
                {
                    arr[count++] = new KeyValue(key, value);
                }
                else
                {
                    throw new Exception("\nMaximum number of items is reached.");
                }
            }
        }
    }
}
