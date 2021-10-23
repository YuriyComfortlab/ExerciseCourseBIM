/*1.    Обязательная задача*. Два треугольника заданы длинами своих сторон. 
 * Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  
 * Для решения задачи можно использовать формулу Герона 
, где x, y, z – стороны треугольника, p – полупериметр.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodSTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длины сторон 1 теугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double S1, S2;
            S1 = CalcSTriangle(a, b, c);
            Console.WriteLine("Введите длины сторон 2 теугольника");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            S2 = CalcSTriangle(a, b, c);

            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого S1 = {0:F2} больше площади второго S2 = {1:F2}", S1, S2);
            }
            if (S1 < S2)
            {
                Console.WriteLine("Площадь первого S1 = {0:F2} меньше площади второго S2 = {1:F2}", S1, S2);
            }
            if (S1 == S2)
            {
                Console.WriteLine("Площади равны, S1 = S2 = {0:F2}", S1);
            }
            Console.ReadKey();

        }

        static double CalcSTriangle(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
    }
}
