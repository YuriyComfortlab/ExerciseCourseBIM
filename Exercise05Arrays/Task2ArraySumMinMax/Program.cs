/*2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
 * Определить сумму максимального и минимального элементов массива.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ArraySumMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int m = 50;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, m);
                Console.Write("{0} ", array[i]);
            }

            int max = array[0];
            int min = array[0];

            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }

            }

            Console.WriteLine();
            Console.WriteLine("Максимальное число {0}, минимальное число {1}, их сумма {2}", max, min, max+min);
            Console.ReadKey();
        }
    }
}
