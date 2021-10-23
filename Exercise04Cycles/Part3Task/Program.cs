/*Часть №3

Задачи на использование операторов цикла с предусловием. Осуществить ввод необходимых данных, 
выполнить реализацию алгоритма с использованием операторов цикла while, обеспечить вывод полученных результатов. 
Использование других операторов цикла недопустимо.
Задачи

Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество 
квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. 
Операции умножения и деления не использовать.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, count1, lineA, lineB;
            count1 = lineA = lineB = 0;
            input:
            Console.Write("Введите число A = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C = ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a <= 0) ^ (b <= 0) ^ (c <= 0))
            {
                Console.WriteLine("Одно из чисел меньше или = 0, повторите ввод");
                goto input;
            }

            while (lineB <= (b - c))
            {

                while (lineA <= (a - c))
                {
                    count1++;
                    lineA += c;

                }
                lineA = 0;
                lineB += c;

            }

            Console.WriteLine("Количество квадратов в прямоугольнике = {0}", count1);

            //Console.Write("проверка через деление: ");
            //Console.WriteLine((a / c) * (b / c));
            Console.ReadKey();
        }
    }

}
