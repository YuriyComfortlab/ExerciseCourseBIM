/*1. Обязательная задача*. Сформировать одномерный массив из 7 элементов. 
 * Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int[] array = new int[n];
            Random rnd = new Random();
            float s = 0;
            Console.WriteLine("Заполните массив 7 числами ");
           
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} - е число ", i+1);
                array[i] = Convert.ToInt32(Console.ReadLine());
                s += array[i];
                
            }
            Console.WriteLine("Среднее арифметическое массива {0:f2} ",s/7);
            Console.ReadKey();
        }
    }
}
