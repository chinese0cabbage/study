using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forth
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1=null;
            int num2=45;
            int num3;
            num3 = num1 ?? 3;
            double num4 = 3.1415926;
            double? num5 = new double?();
            Console.WriteLine("{0},{1},{2},{3},{4}",num1,num2,num3,num4,num5);
            Console.ReadLine();
        }
    }
}
