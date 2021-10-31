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

            BigInteger result = FactorialAsync(number).Result;
            Console.WriteLine("Факториал числа {0:0,0}", result);    

            Console.ReadKey();
        }
        static BigInteger Factorial(int number) //метод возаращает значение
        {           
            BigInteger fact = 1;
            Console.WriteLine("Идет расчет...");
            for (int i = 1; i <= number; i++)
            {
                fact *= (BigInteger)i;
                Thread.Sleep(500);
            }          
            return (fact);
        }
        static async Task<BigInteger> FactorialAsync(int number)
        {
            Console.WriteLine(" Расчет запущен: ");
            BigInteger result = await Task.Run(() => Factorial(number)); 
            Console.WriteLine(" Расчет закончен");
            return result;
        }
    }
}
