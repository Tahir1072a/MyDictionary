using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyDictionary<int,string> names = new MyDictionary<int,string>();
           names.Add(1, "Tahiri");
           names.Add(1, "Engin"); // Bunu eklemye çalışırken bize br hata verecek.
           names.Add(2, "Engin"); // Burda hata vermez çünkü key değeri daha önce kullanılmamış.

           names.ShowList();
        }
    }
}
