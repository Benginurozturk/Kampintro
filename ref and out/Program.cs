using System;

namespace ref_and_out
{
    class Program
    {
       
         static void Main()
            {

                int sayimizOut;
                DegistirOut(out sayimizOut);
                Console.WriteLine(sayimizOut);

                int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
                DegistirRef(ref sayimizRef);
                Console.WriteLine(sayimizRef);
            }

            static void DegistirRef(ref int sayiRef)
            {
                sayiRef = 1234;
            }

            static void DegistirOut(out int sayiOut)
            {
                sayiOut = 1234;
            }
        }
    }
    

