/*6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
 * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры 
 * матрица магическим квадратом. Магическим квадратом называется матрица, сумма элементов которой в каждой строке, 
 * в каждом столбце и по каждой диагонали одинакова.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6ArrayMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность матрицы (целое число) ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sumD1 = 0; //сумма диаг 1
            int sumD2 = 0; //сумма диаг 2
            int sumRow = 0;
            int sumColumn = 0;
            int[,] array = new int[n, n]/* { { 16, 3, 2,  13 },
                                           { 5,  10, 11, 8 },
                                           { 9,  6,  7,  12 },
                                           { 4,  15, 14, 1 } }*/;
            Console.WriteLine();
            Console.Write("Заполните матрицу последовательно числами ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            
            // вывод массива на экран
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }

            // суммы диагоналей
            for (int j = 0; j < n; j++)
            {
                sumD1 += array[j, j];
                sumD2 += array[j, (n - 1 - j)];
            }
            Console.Write("{0} {1}", sumD1, sumD2);
            Console.WriteLine();

            //если магические диагонали, проверяем суммы строк и столбцов
            if (sumD1 == sumD2)
            {
                for (int i = 0; i < n; i++)
                {
                    sumRow = 0;
                    sumColumn = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sumRow += array[i, j];
                        sumColumn += array[j, i];
                    }
                    //если сумма строк или стоблцов не равна диагонали прерываем цикл
                    if (sumRow != sumD1 ^ sumColumn != sumD1)
                    {
                        Console.WriteLine("Магии нет в строках или столбцах");
                        break;
                    }
                }
                //если сумма столбцов = сумме строк и сумма столбцов равна диагональ - магия
                if ((sumColumn == sumRow) && (sumColumn == sumD1))
                {
                    Console.WriteLine("Магический квадрат");
                }
            }
            else
            {
                Console.WriteLine("Магии нет в диагоналях");
            }
            Console.ReadKey();
        }
    }
}
