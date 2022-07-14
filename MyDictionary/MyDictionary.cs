using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<T,K>
    {
        KeyValuePair<T,K>[] items; // KeyValuePair int gibi string gibi bir veri tipidir. 

        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T _key,K _value)
        {
            KeyValuePair<T, K>[] tempArray = items;  // Geçici dizimizi oluşturduk
            items = new KeyValuePair<T, K>[items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçici dizideki elemanları alıp asıl dizimize gri koyduk.
            }

            items[items.Length-1] = new KeyValuePair<T, K>(_key, _value); // En son bize gelen değeri dizimize aktarıp işi bitirdik.

        }
    }
}
