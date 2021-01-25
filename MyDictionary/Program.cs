using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, string> sehirler = new System.Collections.Generic.Dictionary<int, string>();
            sehirler.Add(25, "Ankara");
            Console.WriteLine(sehirler[25]);


            Dictionary<int, string> sehirler2 = new Dictionary<int, string>();
            sehirler2.Add(1, "İzmir");
            sehirler2.Add(2, "Afyon");
            Console.WriteLine(sehirler2.Count);
            
        }
    }
}
