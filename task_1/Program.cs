using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Point3D : Point2D<int>
    {
        public int Z { get; set; }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public Point3D() : base()
        {}
        public override string ToString()
        {
            return $"x = {X}\ny = {Y}\nz = {Z}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point3D = new Point3D(100, -10, 50);
            Console.WriteLine(point3D);

            point3D = new Point3D();
            Console.WriteLine(point3D);
        }
    }
}
