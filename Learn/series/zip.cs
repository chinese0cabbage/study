using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series
{    class Zip
    {
        static void Main(string[] args)
        {
            string str = "12asdhfjklahndlfjkhalsdjfnajklhsejknfajsdn";
            var afterZip = Smaller(str);
            File.WriteAllText(@"C:\Users\JohnJun\Desktop\1.txt", str);
            FileStream fileStream = new FileStream(@"C:\Users\JohnJun\Desktop\2.txt", FileMode.OpenOrCreate);
            fileStream.Write(afterZip, 0, afterZip.Length);
        }
        public static byte[] Smaller(string str)
        {
            Stream stream = new MemoryStream();
            byte[] tmpByte= Encoding.UTF8.GetBytes(str);
            GZipStream gZipStream = new GZipStream(stream, CompressionMode.Compress);
            gZipStream.Write(tmpByte, 0, tmpByte.Length);
            return tmpByte;
        }
    }
}
