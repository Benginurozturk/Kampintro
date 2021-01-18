using System;

namespace ternaryOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {

            bool medeniHal = true;
            string mesaj = medeniHal == true ? "Evlilere kampanya..." : "Bekarlara kampanya...";
            Console.WriteLine(mesaj);         
        }
    }
}
