/*Часть №2

Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, 
выполнить реализацию алгоритма с использованием операторов цикла do - while, обеспечить вывод полученных результатов. 
Использование других операторов цикла недопустимо.
Задачи

Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,positive,negative;
            n = positive = negative = 0;
            Console.WriteLine("Вводите целые числа, после завершения ввода введите 0");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n>0)
                {
                    positive++;
                }
                if (n < 0)
                {
                    negative++;
                }
            } while (n !=0);
            if (positive>negative)
            {
                Console.WriteLine("Положительных чисел больше и равно {0}, отрицательных чисел меньше и равно {1}", positive, negative);
            }
            if (positive == negative)
            {
                Console.WriteLine("Положительных и отрицательных чисел одинаково и равно {0}", positive);
            }
            if (positive < negative)
            {
                Console.WriteLine("Отрицательных чисел больше и равно {0}, положительных чисел меньше и равно {1}", negative, positive);
            }
            Console.ReadKey();
        }
    }
}
