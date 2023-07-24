using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch001_do.@while
{
    class Program
    {
        static void
            Main(string[] args)
        {
             int i = 1;
            
            do
            {
                Console.WriteLine (i);
                i++;
            }
            while (i<0);
            Console.WriteLine ("for loop terminates...");
            Console.ReadLine();
        }
    }
}
