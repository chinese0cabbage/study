using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_class
{
    class box
    {
        private double length;
        private double breadth;
        private double height;
        public void setlength(double len)
        {
            length = len;
        }
        public void setheight(double hei)
        {
            height = hei;
        }
        public void setbreadth(double bre)
        {
            breadth = bre;
        }
        public double getvolume()
        {
            return length * breadth * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            box wbox = new box();
            box bbox = new box();
            double volume;
            wbox.setlength(6.0);
            wbox.setbreadth(7.0);
            wbox.setheight(5.0);
            bbox.setbreadth(13.0);
            bbox.setlength(12.0);
            bbox.setheight(10.0);
            volume = wbox.getvolume();
            Console.WriteLine("{0}", volume);
            volume = bbox.getvolume();
            Console.WriteLine("{0}", volume);
            Console.ReadLine();
        }
    }
}
