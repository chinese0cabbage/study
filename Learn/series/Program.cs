using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace series
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    XYZp xyz = new XYZp(1, 2, 3);
        //    XYZp xY = new XYZp(xyz);
        //    Console.WriteLine(xY.X);
        //    Console.WriteLine(xY.Y);
        //    Console.WriteLine(xY.Z);
        //    Console.ReadLine();
        //}
    }
    [Serializable]
    class TestSerializable
    {
        private int num1;
        private int num2;

        public TestSerializable(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Add()
        {
            return num2 + num1;
        }
        public static void Formatter()
        {
            TestSerializable testSerializable = new TestSerializable(1, 2);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(@"C:\Users\zhangjun\Desktop\test", FileMode.OpenOrCreate);
            binaryFormatter.Serialize(fileStream, testSerializable);
        }
        public static void UnFormatter()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(@"C:\Users\zhangjun\Desktop\test", FileMode.Open);
            TestSerializable test = (TestSerializable)binaryFormatter.Deserialize(fileStream);
            Console.WriteLine(test.Add());
            Console.ReadLine();
        }
    }
}
