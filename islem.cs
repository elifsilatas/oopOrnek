using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Seven
{
    internal class islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.Write("Toplam: " + toplam);
            Console.WriteLine();
            return toplam;
        }

        public int fark(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.Write("Fark: " + cikar);
            Console.WriteLine();
            return cikar;
        }

        public int bol(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.Write("Bölüm: " + bolme);
            Console.WriteLine();
            return bolme;
        }

        public int carp(int sayi1, int sayi2)
        { 
            int carpma = sayi1 * sayi2;
            Console.Write("Çarpım: " + carpma);
            Console.WriteLine();
            return carpma;
        }

        
    }
}
