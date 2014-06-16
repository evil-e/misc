using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testns
{
    class test
    {
        static test()
        {
            Console.WriteLine("First");
        }

        public test()
        {
            Console.WriteLine("Second");
        }
     
        public static void Main(String[] args)
        {
            test t = new test();
            Console.Write("Hello");
        }
    }
}
