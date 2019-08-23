using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace @enum
{
    class Program
    {
        enum days { sun, mon, tue, wed, thu, fri, sat };
        static void Main(string[] args)
        {
            int x = (int)days.sun;
            int y = (int)days.fri;
            Console.WriteLine("{0}", x);
            Console.WriteLine("{0}", y);
            Console.ReadLine();
        }
    }
}
