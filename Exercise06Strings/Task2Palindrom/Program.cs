/*2.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
 * (пример палиндрома – «А роза упала на лапу Азора»). * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrom = Console.ReadLine();

           // string polindrom = "А роза упала на лапу азора";

            palindrom = palindrom.Replace(" ", "");
            palindrom = palindrom.ToLower();
            string chek = "";
            
            for (int i = (palindrom.Length-1); i >=0; i--)
            {
               chek += palindrom[i];
            }

            if (chek==palindrom)
            {
                Console.WriteLine("Введенная фраза - палиндром");
            }
            else
            {
                Console.WriteLine("Введенная фраза - НЕ палиндром");
            }
                 
            //Console.WriteLine(polindrom);
            //Console.WriteLine(chek);
            Console.ReadKey();
        }
    }
}
