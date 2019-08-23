using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace third
{
    class Program
    {
        static void Main(string[] args)
        {
            animal cat = new animal();
            cat.kind = "cat";
            cat.weight = 10;
            cat.length = 3;
            cat.display();
            Console.ReadLine();
        }
    }
    class animal
    {
        public string kind;
        public double weight;
        public double length;
        public double w_per_l()
        {
            return weight / length;
        }
        public void display()
        {
            Console.WriteLine("该动物的种类是：{0}", kind);
            Console.WriteLine("该动物单位长度的重量是：{0}", w_per_l());
        }
    }
}
