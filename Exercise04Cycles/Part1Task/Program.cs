/*Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: 
 * N^2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы 
 * (в результате будут выведены квадраты всех целых чисел от 1 до N).
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,n2;
            input:
            Console.WriteLine("Введите целое число >0");
            n = Convert.ToInt32(Console.ReadLine());
            n2 = 0;
            if (n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    n2+=(2*i-1);
                    Console.WriteLine("Квадрат числа {0} равен {1}", i, n2);
                }
            }
            else
            {
                Console.WriteLine("Введите не верное число, повторите ввод");
                goto input;
            }
            Console.ReadKey();
        }
    }
}
