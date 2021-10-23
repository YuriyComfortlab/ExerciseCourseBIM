/*1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

метод, определяющий длину окружности по заданному радиусу;
метод, определяющий площадь круга по заданному радиусу;
метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12Static
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, x0 = 0, y0 = 0;
            Console.Write("Введите координату X точки ");
            x = InputIntData(Console.ReadLine());
            Console.Write("Введите координату Y точки ");
            y = InputIntData(Console.ReadLine());
            Console.Write("Введите координату X0 центра круга ");
            x0 = InputIntData(Console.ReadLine());
            Console.Write("Введите координату Y0 центра круга ");
            y0 = InputIntData(Console.ReadLine());
            Console.Write("Введите радиус R = ");
            if (int.TryParse(Console.ReadLine(), out int radius))
            {
                Console.WriteLine("Длина окружности {0:F3}", Circle.СircumferenceFromRadius(radius));
                Console.WriteLine("Площадь круга {0:F3}", Circle.AreaCircle(radius));
            }
            else
            {
                Console.Write("Введено неверное значение");
            }

            Circle.CheckPointToCircle(radius, x, y, x0, y0);
            Console.ReadKey();
        }

        static int InputIntData(string a)
        {
            int b;
            if (!int.TryParse(a, out b))
            {
                Console.WriteLine("Введено неверное значение, будет присвоено значение 0");
            }
            return b;

        }
    }

    public static class Circle
    {

        public static double СircumferenceFromRadius(int radius)
        {
            double circuit = 2 * Math.PI * radius;
            return circuit;
        }
        public static double AreaCircle(int radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static void CheckPointToCircle(int radius, int x, int y, int x0, int y0)
        {           
            if (((Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2))) <= (radius * radius))
            {                
                Console.WriteLine("Точка принадлежит кругу");   
            }
            else
            {
                Console.WriteLine("Точка не принадлежит кругу");
            }


        }
    }
}
