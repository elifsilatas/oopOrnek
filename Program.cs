using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Seven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(8, 2);
            isl.fark(8, 2);
            isl.carp(8, 2);
            isl.bol(8, 2);
            Console.Read();
        }
    }
}
