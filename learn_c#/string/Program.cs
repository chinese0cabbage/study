using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Roman";
            lname = "Atkinson";
            string fullname = fname + lname;
            Console.WriteLine("{0}", fullname);
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("{0}", greetings);
            string[] sarray = { "hello", "from", "tutorials", "point" };
            string message = string.Join(" ", sarray);
            Console.WriteLine("{0}", sarray);
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = string.Format("message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("{0}", chat);
            Console.ReadLine();
        }
    }
}
