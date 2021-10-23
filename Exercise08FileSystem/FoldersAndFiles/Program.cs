/*2.    Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
 * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FoldersAndFiles
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "d:/BIM/file.txt";

            CreatFile(path);
            Console.ReadKey();
        }

        static void CreatFile(string path)
        {
            Console.WriteLine();
            Console.WriteLine(path);

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            else
            {
                Console.WriteLine("File already exist");
            }

            Random rand1 = new Random();
            int[] array = new int[10];

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = rand1.Next(0, 100);
                    sw.WriteLine((array[i]));
                }
            }

            string str;

            using (StreamReader sr = new StreamReader(path))
            {
                str = sr.ReadToEnd();
                Console.WriteLine(str);
            }

            int sum = 0;
            string cleaned = str.Replace("\r\n", ".");
            string[] arrayStr = cleaned.Split('.');

            for (int i = 0; i < arrayStr.Length - 1; i++)
            {
                sum += Convert.ToInt32(arrayStr[i]);
            }
            Console.WriteLine("Сумма чисел = {0}", sum);

        }
    }
}
