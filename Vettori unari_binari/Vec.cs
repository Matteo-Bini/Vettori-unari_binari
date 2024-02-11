using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori_unari_binari
{
    internal class Vec
    {
        

        public double  X { get; set; }
        public double Y { get; set; }

        public Vec(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vec operator +(Vec v) 
        {
            return v;
        }
        public static Vec operator +(Vec v, Vec c)
        {
            return new Vec(v.X + c.X, v.Y + c.Y);
        }
        public static Vec operator -(Vec v)
        {
            return new Vec(-v.X, -v.Y);
        }
        public static Vec operator -(Vec v, Vec c) 
        {
            return new Vec(v.X -v.Y, v.Y -c.Y);
        }
        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }
    }
}
