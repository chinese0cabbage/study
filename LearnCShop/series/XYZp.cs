using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series
{
    class XYZp
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public XYZp()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }
        public XYZp(double x,double y,double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public XYZp(XYZp xyz)
        {
            this.X = xyz.X;
            this.Y = xyz.Y;
            this.Z = xyz.Z;
        }
        public XYZp Add(XYZp anotherXYZp)
        {
            return new XYZp(this.X + anotherXYZp.X, this.Y + anotherXYZp.Y, this.Z + anotherXYZp.Z);
        }
        public double Multiple(XYZp anotherXYZp)
        {
            return this.X * anotherXYZp.X + this.Y * anotherXYZp.Y + this.Z * anotherXYZp.Z;
        }
        public XYZp Minus(XYZp anotherXYZp)
        {
            return new XYZp(this.X - anotherXYZp.X, this.Y - anotherXYZp.Y, this.Z - anotherXYZp.Z);
        }
        public static XYZp Transform(XYZp xyz)
        {
            return new XYZp(xyz.X, xyz.Y, xyz.Z);
        }
    }
}
