/*Разработать асинхронный метод для вычисления факториала числа. 
 * В методе Main выполнить проверку работы метода.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace FactorialAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, факториал которого нужно найти ");
            int number = Convert.ToInt32(Console.ReadLine());

            FactorialAsync(number);
            Console.WriteLine("А пока выполняем другие методы");

            Console.ReadKey();
        }
        static void Factorial(int number) //метод не возвращает значение
        {
            BigInteger fact = 1;
            Console.WriteLine("Идет расчет факториала...");
            for (int i = 1; i <= number; i++)
            {
                fact *= (BigInteger)i;
                Thread.Sleep(50);
            }
            Console.WriteLine("Факториал числа {0:0,0}", fact);
        }
        static async Task FactorialAsync(int number)
        {
            Console.WriteLine(" Расчет запущен: ");
            await Task.Run(() => Factorial(number));
            Console.WriteLine(" Расчет закончен");
        }
    }
}
