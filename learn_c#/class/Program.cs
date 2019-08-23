using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class box
    {
        public double length;
        public double breadth;
        public double height;
    }
    class Program
    {
        static void Main(string[] args)
        {
            box wbox = new box();
            box bbox = new box();
            double volume = 0.0;
            wbox.height = 5.0;
            wbox.length = 6.0;
            wbox.breadth = 7.0;
            bbox.height = 10.0;
            bbox.length = 12.0;
            bbox.breadth = 13.0;
            volume = wbox.breadth * wbox.height * wbox.length;
            Console.WriteLine("{0}", volume);
            volume = bbox.length * bbox.height * bbox.breadth;
            Console.WriteLine("{0}", volume);
            Console.ReadLine();
        }
    }
}
