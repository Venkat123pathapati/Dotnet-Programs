using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f,g;
            Console.WriteLine("Enter any numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = a * a;
            Console.WriteLine("A squre is:" + c);
            d = b * b;
            Console.WriteLine("B squre is:" + d);
            e = a + b;
            Console.WriteLine("A+B is:" + e);
            f = c + d;
            Console.WriteLine("A squre+ B squre is:" + f);
            g = e * e;
            Console.WriteLine("A+B squre  is:" + g);
            Console.Read();
        }
    }
}
