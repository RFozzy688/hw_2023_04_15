using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class Point2D<T>
    {
        // параметр типа используется для задания типа свойства 
        public T X { get; set; }
        public T Y { get; set; }
        // параметр типа используется для задания типов параметров метода 
        public Point2D(T x, T y) 
        { 
            X = x;
            Y = y; 
        }
        public Point2D()
        { 
            X = default(T);
            Y = default(T);
        }
    }

}
