/*4. Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
 * Определить количество   нечетных положительных элементов, стоящих на четных местах.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4ArraySummOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int count = 0;
            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {

                Console.Write("{0,4} ", i + 1);

            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }

            Console.WriteLine();
            Console.Write("Нечетные положительные на четных местах ");
            for (int i = 1; i < n; i = i + 2)
            {
                if (array[i] > 0 && array[i] % 2 != 0)
                {
                    count++;
                    Console.Write("{0} ", (array[i]));
                }

            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных числе на четных местах {0 }", count);
            Console.ReadKey();
        }
    }
}
