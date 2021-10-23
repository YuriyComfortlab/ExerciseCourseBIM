/*2.    Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetosSandVCube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите ребро куба ");
            int a = Convert.ToInt32(Console.ReadLine());
            int S, V;
            CalcVandSCube(a,out S, out V);
            Console.WriteLine("Площадь куба = {0}, объем куба = {1}", S,V);
            Console.ReadKey();
        }

        static void CalcVandSCube(int a,out int S, out int V)
        {
            S = a * a*6;
            V = a * a * a;
        }
    }
}
