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
            if (Control(_key))
            {
                Configuration(_key);
                items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value); // En son bize gelen değeri dizimize aktarıp işi bitirdik.
            }
            else
            {
                Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamassınız.");
            }

        }

        public void ShowList()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }

        private void Configuration(T _key)
        {
            KeyValuePair<T, K>[] tempArray = items;  // Geçici dizimizi oluşturduk
            items = new KeyValuePair<T, K>[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //Geçici dizideki elemanları alıp asıl dizimize gri koyduk.
            }
            
        }
        private bool Control(T _Key)
        {
            bool control = true;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == _Key.ToString())
                {
                    control = false;
                }
            }
            return control;
        }
    }
}
