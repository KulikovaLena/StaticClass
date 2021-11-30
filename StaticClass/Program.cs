using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            try
            {
                Console.Write("Ввведите значение координаты центра окружности x0 ");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ввведите значение координаты центра окружности y0 ");
                double y0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение радиуса r ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координаты точки x ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите координаты точки y ");
                double y = Convert.ToDouble(Console.ReadLine());
                Circle.CircleL(r);
                Circle.CircleS(r);
                Circle.CircleXY(r, x0, y0, x, y);
            }
            catch
            {
                Console.WriteLine("Ошибка! Входная строка имела неверный формат");
            }
            Console.ReadKey();
        }
        public static class Circle
        {
            public static void CircleL(double d)
            {
                if (d <= 0)
                {
                    Console.WriteLine("Радиус должен быть > 0");
                }
                else
                {
                    Console.WriteLine("Длина окружности = {0:0.00}", 2 * Math.PI * d);
                }
            }
            public static void CircleS(double d)
            {
                if (d <= 0)
                {
                    Console.WriteLine("Радиус должен быть > 0");
                }
                else
                {
                    Console.WriteLine("Площадь круга = {0:0.00}", Math.PI * d * d);
                }  
            }
            public static void CircleXY(double d, double x0, double y0, double x, double y)
            {
                if (d == Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0)))
                {
                    Console.WriteLine("Точка с координатами (x,y) принадлежит окружности");
                }
                else
                {
                    Console.WriteLine("Точка с координатами (x,y) не принадлежит окружности");
                }
            }
        }
    }
}
