using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_format
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("enter yoour first name");
            string fname = Console.ReadLine();
            Console.WriteLine("enter our last name");
            string lname = Console.ReadLine();
            Console.WriteLine("hello {0} {1}", fname,lname);
            Console.Read();
        }
    }
}
