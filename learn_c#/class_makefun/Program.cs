using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_makefun
{
    class line
    {
        private double length;
        public line(double len)
        {
            Console.WriteLine("对象已创建，length={0}", len);
            length = len;
        }
        public void setlength(double len)
        {
            length = len;
        }
        public double getlength()
        {
            return length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            line lin = new line(10.0);
            Console.WriteLine("{0}", lin.getlength());
            lin.setlength(6.0);
            Console.WriteLine("{0}", lin.getlength());
            Console.ReadLine();
        }
    }
}
