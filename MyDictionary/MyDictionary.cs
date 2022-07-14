using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<T,K>
    {
        KeyValuePair<T,K>[] items;

        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T _key,K _value)
        {
            KeyValuePair<T, K>[] tempArray = items;
            items = new KeyValuePair<T, K>[items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = new KeyValuePair<T, K>(_key, _value);

        }
    }
}
