/*5. Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1
0 1 0 1 0
1 0 1 0 1
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5ArrayNxN
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите целое число ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i, j;

            int[,] array = new int[n, n];
            Random rnd = new Random();

            for (i = 0; i < n; i++)
            {

                for (j = 0; j < n; j++)
                {
                    if (j % 2 == 0 && i%2==0)
                    {
                        array[i, j] = 1;
                    }

                    if (j % 2 == 0 && i % 2 != 0)
                    {
                        array[i, j] =  0;
                    }

                    if (j % 2 != 0 && i % 2 == 0)
                    {
                        array[i, j] = 0;
                    }

                    if (j % 2 != 0 && i % 2 != 0)
                    {
                        array[i, j] = 1;
                    }

                    Console.Write("{0,2}", array[i, j]);
                }

                Console.WriteLine();

            }
          
            Console.ReadKey();
        }
    }
}
