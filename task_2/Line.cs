using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1;

namespace task_2
{
    internal class Line<T> : Point2D<T>
    {
        public Point2D<T> A { get; set; }
        public Point2D<T> B { get; set; }
        public Line(Point2D<T> a, Point2D<T> b)
        {
            A = a;
            B = b;
        }
        public Line(T x1, T y1, T x2, T y2) 
        { 
            A = new Point2D<T>(x1, y1);
            B = new Point2D<T>(y2, x2);
        }
        public override string ToString()
        {
            return $"A: x = {A.X} y = {A.Y}\nB: x = {B.X} y = {B.Y}";
        }
    }
}
