/*Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать. 
 * Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
 * Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз. 
 * Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево. 
 * Если садовник видит, что участок сада уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно. 
 * Создать многопоточное приложение, моделирующее работу садовников.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GardenThread
{
    class Program
    {
        static int[,] array = { { 0,0,0,0,0,0,0,0,0,0},
                                { 0,0,0,0,0,0,0,0,0,0},
                                { 0,0,0,0,0,0,0,0,0,0},
                                { 0,0,0,0,0,0,0,0,0,0},
                                { 0,0,0,0,0,0,0,0,0,0},
                                { 0,0,0,0,0,0,0,0,0,0} };

        static object locker = new object();
        public static void GardenPrint(object name)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Gardener1(object name)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Thread.Sleep(50);
                    lock (locker)
                    {
                        if (array[i, j] == 2)
                        {
                            break;
                        }
                        else
                        {
                            array[i, j] = 1;
                            Console.SetCursorPosition(j, i);
                            Console.Write(array[i, j]);
                        }
                    }
                }
            }
        }

        public static void Gardener2(object name)
        {
            for (int j = (array.GetLength(1) - 1); j >= 0; j--)
            {
                for (int i = (array.GetLength(0) - 1); i >= 0; i--)
                {
                    Thread.Sleep(100);
                    lock (locker)                    {

                        if (array[i, j] == 1)
                        {
                            break;
                        }
                        else
                        {
                            array[i, j] = 2;
                            Console.SetCursorPosition(j, i);
                            Console.Write(array[i, j]);
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ParameterizedThreadStart(Gardener1));
            thread1.Start(array);
            Thread thread2 = new Thread(new ParameterizedThreadStart(Gardener2));
            thread2.Start(array);           
            Console.ReadKey();
        }
    }
}
