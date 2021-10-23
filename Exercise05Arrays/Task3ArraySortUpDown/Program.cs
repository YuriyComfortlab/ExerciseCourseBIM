/*3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
 * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3ArraySortUpDown
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();

            //сортировка перебором по возрастанию. Сложность алгоритма ~квадратичная, т.к.
            //каждый элемент нужно сравнить с каждым

            //сортировка первой половины по возрастанию
            for (int i = 0; i < (4); i++) //цикл до предпоследнего элемента в массиве включительно
            {
                for (int j = i + 1; j < 5; j++) //проверка следующего за i элемента, до конца массива
                {
                    if (array[i] > array[j]) //проверка на правильность размещения элементов в массиве
                    {
                        //меняем местами элементы, если стоят не по порядку.
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;

                    }

                }

            }

            //сортировка второй половины по убыванию
            for (int i = 5; i < (9); i++) //цикл до предпоследнего элемента в массиве (8 включительно)
            {
                for (int j = i + 1; j < 10; j++) //проверка следующего за i элемента, до конца массива
                {
                    if (array[i] < array[j]) //проверка на правильность размещения элементов в массиве
                    {
                        //меняем местами элементы, если стоят не по порядку.
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;

                    }

                }

            }
            for (int i = 0; i < 10; i++)
            {

                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
