/*1.    Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
 * Знаки препинания не используются. Найти самое длинное слово в строке.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1String
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int maxLength = 0;
            int index = 0;
            int count = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxLength)
                {
                    maxLength = stringArray[i].Length;
                    index = i;
                    
                }
            }
            Console.WriteLine("Самое первое длинное слово - \"{0}\"", stringArray[index]);

                for (int i = index+1; i < stringArray.Length; i++)
                {
                    if (stringArray[i].Length == maxLength)
                    {
                        Console.WriteLine("Еще такое же длиное слово - \"{0}\"", stringArray[i]);
                    }
                }
            

            Console.ReadKey();
        }
    }
}
