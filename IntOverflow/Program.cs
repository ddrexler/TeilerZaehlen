using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Int32.MinValue;
            int max = Int32.MaxValue;
            int errorInt = Convert.ToInt32("2147483648");

            Console.WriteLine("{0}, {1}", min, max);

            Console.ReadLine();
        }
    }
}
