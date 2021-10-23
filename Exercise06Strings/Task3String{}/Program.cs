/*3.    Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
 * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
 * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3StringVSkobkah
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //string text = "12}3{456}7890";

            int countOpen = 0;
            int countClose = 0;
            int count = 0;
            int i = 0;
            int j = 0;
            for (i = text.IndexOf('{'); i <= text.LastIndexOf('}'); i++)
            {
                if (text[i] == '{')
                {
                    countOpen++;
                }
                if (text[i] == '}')
                {
                    countClose++;
                }
            }
          //  Console.WriteLine("Исходный {0}", text);
            while (Math.Min(countOpen, countClose) > 0)
            {
                for (i = 0; i < text.Length; i++)
                {
                    if (text[i] == '{')

                    {
                        count = i;

                        for (j = i; j < text.Length - 1; j++)
                        {
                            if (text[j + 1] == '{')
                            {
                                count = j + 1;
                            }
                            else
                            {
                                if (text[j + 1] == '}')
                                {

                                    text = text.Remove(count, (j + 1 - count + 1));
                                    countOpen--;
                                    countClose--;
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            Console.WriteLine("Результирующий текст - {0} ", text);
            Console.ReadKey();
        }
    }
}
