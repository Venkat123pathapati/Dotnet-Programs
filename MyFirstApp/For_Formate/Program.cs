using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Formate
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Enter B number:");
            B = int.Parse(Console.ReadLine());
            for(A=0; A<=50; A++)
            {
                C = A * B;
                Console.WriteLine("{0}*{1}={2}", A, B, C);

            }
            Console.Read();

        }
    }
}
