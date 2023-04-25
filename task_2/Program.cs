//Создать обобщенный класс прямой на плоскости. В классе предусмотреть 2 поля типа обобщенной
//точки — точки, через которые проходит прямая.
//Реализовать в классе:
// ■ конструктор, который принимает 2 точки
// ■ конструктор, которые принимает 4 координаты (x и у координаты для первой и второй точки)
// ■ метод ToString()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_1;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> a1 = new Point2D<int>(10, 10);
            Point2D<int> b1= new Point2D<int>(20, 20);

            Line<int> line1 = new Line<int>(a1, b1);
            Console.WriteLine("line1:\n" + line1);

            Point2D<float> a2 = new Point2D<float>(10.5f, 10.7f);
            Point2D<float> b2 = new Point2D<float>(20.6f, 20.9f);

            Line<float> line2 = new Line<float>(a2, b2);
            Console.WriteLine("\nline2:\n" + line2);

            Line<int> line3 = new Line<int>(5, 4, 14, 15);
            Console.WriteLine("\nline3:\n" + line3);

            Line<float> line4 = new Line<float>(5.23f, 4.56f, 14.81f, 15.05f);
            Console.WriteLine("\nline4:\n" + line4);
        }
    }
}
