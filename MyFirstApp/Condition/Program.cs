using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A value is:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value is:");
            int B = int.Parse(Console.ReadLine());
            if(A<B)
            {
                Console.WriteLine("B is grater");
            }
            else
            {
                Console.WriteLine("A is grater");
            }
            
            
                //Console.WriteLine("Both are same ");
            
            Console.Read();

        }
    }
}
