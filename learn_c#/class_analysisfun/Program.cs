using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_analysisfun
{
    class line
    {
        private double length;
        public line()
        {
            Console.WriteLine("对象已创建");
        }
        ~line()
        {
            Console.WriteLine("对象已删除");
        }
        public void setlength(double len)
        {
            length=len;
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
            line lin = new line();
            lin.setlength(6.0);
            Console.WriteLine("线条的长度：{0}", lin.getlength());
            Console.ReadLine();
        }
    }
}
