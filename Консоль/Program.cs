using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль3
{
    class Program
    {


        static void Main()
        {
            //======================================ЗАДАНИЕ№1============================//
            Console.WriteLine("Первое задание");
            int Ax, Ay, Bx, By, Cx, Cy;
            Console.WriteLine("Введите координаты трех точек:");
            Console.Write("Ax = ");
            Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay = ");
            Ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bx = ");
            Bx = Convert.ToInt32(Console.ReadLine());
            Console.Write("By = ");
            By = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cx = ");
            Cx = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cy = ");
            Cy = Convert.ToInt32(Console.ReadLine());

            double a = Dlina(Ax, Ay, Bx, By);
            double b = Dlina(Ax, Ay, Cx, Cy);
            double c = Dlina(Cx, Cy, Bx, By);
            Console.WriteLine("a " + a);
            Console.WriteLine("b " + b);
            Console.WriteLine("c " + c);
            double min1 = Min(a, b);
            double min2 = Min(c, b);
            Console.WriteLine("min1 = " + min1);
            Console.WriteLine("min2 = " + min2);
            //======================================ЗАДАНИЕ№2============================//
            Console.WriteLine("Второе задание");
            Console.Write("a=");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("с=");
            double c2 = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a2; i <= b2; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, F(i, a2, b2, c2));
            //======================================ЗАДАНИЕ№3============================//
            Console.Write("a=");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b3 = double.Parse(Console.ReadLine());
            Console.Write("с=");
            double c3 = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h3 = double.Parse(Console.ReadLine());
            double y;
            for (double i = a3; i <= b3; i += h3)
            {
                F(i, a3, b3, c3, out y);
                Console.WriteLine("f({0:f2})={1:f4}", i, F(i, a3, b3, c3));
            }
            Console.ReadKey();
        }


        static double F(double x, double a, double b, double c)
        {
            double y;
            if (x < 93) y = a + b * x;
            else if (x > 120) y = a * b * x;
            else y = b - a * c;
            return y;
        }
        static void F(double x, double a, double b, double c, out double y)
        {
            y = 0.0;
            if (x < 93) y = a + b * x;
            else if (x > 120) y = a * b * x;
            else y = b - a * c;
        }
        static double Dlina(double x1, double y1, double x2, double y2)
        {
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return d;
        }
        static double Min(double a, double b)
        {
            double min = a;
            if (a > b)
                min = b;
            return min;
        }
        

    }
}
