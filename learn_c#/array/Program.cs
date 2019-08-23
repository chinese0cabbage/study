using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] balance = new double[10];
            int i = 0;
            for (; i < 10; i++)
            { 
                balance[i] = i + 10;
                ///Console.WriteLine("{0}", balance[i]);
             }
            foreach(int j in balance)
            {
                Console.WriteLine("{0}",j);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
