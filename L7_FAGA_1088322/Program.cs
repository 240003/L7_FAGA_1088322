using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace L7_FAGA_1088322
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant;
            int a, b, c;
            Console.WriteLine("Ingrese un numero: ");
            cant = Int32.Parse(Console.ReadLine());
            a = 0; b = 1;
            Console.Write(a + " " + b + " ");
            for (int w = 3; w <= cant; w++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}