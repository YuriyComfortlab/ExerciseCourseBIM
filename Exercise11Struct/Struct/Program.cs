/*1.   Разработать структуру для решения линейного уравнения 0=kx+b. 
 * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. Для решения уравнения предусмотреть метод Root. 
 * Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearEquation linearEquation = new LinearEquation();
            Console.WriteLine("уравнение вида 0=kx+b");
            Console.Write("Введите коэффициент k = ");
            bool chek1 = float.TryParse(Console.ReadLine(), out float k);
            Console.Write("Введите коэффициент b = ");
            bool chek2 = float.TryParse(Console.ReadLine(), out float b);
            if (!chek1 || !chek2)
            {
                Console.WriteLine("Данные введены не верно");
            }
            float x = linearEquation.Root(k, b);
            Console.WriteLine("Решение x = {0}", x);
            Console.ReadKey();
        }
    }

    struct LinearEquation
    {
        public float k;
        public float b;

        public float Root(float k, float b)
        {
            float x = (0 - b) / k;
            if (float.IsInfinity(x))
            {
                Console.WriteLine("Попытка деления на 0");
            }
            return x;
        }

    }
}
