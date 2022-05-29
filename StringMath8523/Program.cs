using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMath8523
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PI : " + Math.PI);
            int sayi1 = 10;
            int sayi2 = 20;
            Console.WriteLine("Sonuç : " + (sayi1-sayi2) + " , Mutlak değer : " + Math.Abs(sayi1 - sayi2));

            double sayi = 2.9;
            Console.WriteLine((int)sayi); // 2
            Console.WriteLine(Math.Floor(sayi)); // 2
            Console.WriteLine(Math.Ceiling(sayi)); // 3
            Console.WriteLine(Math.Pow(2,4)); // 16
            Console.WriteLine(Math.Min(1 , 2 ) + " - " + Math.Max(1.1 , 2.2));
            double sayi4 = 12.34501;
            double sayi5 = 98.76500;
            Console.WriteLine(Math.Round(sayi4));
            Console.WriteLine(Math.Round(sayi5));
            Console.WriteLine(Math.Round(sayi4 , 1));
            Console.WriteLine(Math.Round(sayi5 , 1));
            Console.WriteLine(Math.Round(sayi4 , 2));
            Console.WriteLine(Math.Round(sayi5 , 2));
            Console.WriteLine(Math.Sqrt(64));

            Console.WriteLine(Math.Pow(8 , 1.0 / 3.0));



            Console.ReadLine();

        }
    }
}
