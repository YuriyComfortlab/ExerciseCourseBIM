/*3.    Вручную подготовьте текстовый файл с фрагментом текста. 
 * Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/BIM/file.txt";
            StatisticsInfo(path);
            Console.ReadKey();
        }

        static void StatisticsInfo(string path)
        {
            string str = File.ReadAllText(path);
            string[] strLines = File.ReadAllLines(path);
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Simbols = {0}", str.Replace("\r\n", "").Length);
            Console.WriteLine("Words = {0}", str.Replace("\r\n", " ").Split(' ').Length);
            Console.WriteLine("Lines = {0}", strLines.Length);

        }
    }
}
