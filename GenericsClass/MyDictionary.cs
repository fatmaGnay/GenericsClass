using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsClass
{
    class MyDictionary<T> //Generic Class
    {
           public void Add(T item)
        {
            Console.WriteLine("Sözcük eklendi.");
        }
    }
}
