/*Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста, 
 * обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». 
 * Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_Age_20_69
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, tens, ones;
            string tensString, onesString;
            input:
            Console.WriteLine("Введите возраст в диапазоне 20...69 лет");
            age = Convert.ToInt32(Console.ReadLine());
            if ((age>=20)&&age<=69)
            {
                tens = age / 10;
                ones = age % 10;
                switch (tens)
                {
                    case 2:
                        {
                            tensString = " - Двадцать";
                            break;
                        }
                    case 3:
                        {
                            tensString = " - Тридцать";
                            break;
                        }
                    case 4:
                        {
                            tensString = " - Сорок";
                            break;
                        }
                    case 5:
                        {
                            tensString = " - Пятьдесят";
                            break;
                        }
                    case 6:
                        {
                            tensString = " - Шестьдесят";
                            break;
                        }
                    default:
                        {
                            goto input;                            
                        }
                }
                switch (ones)
                {
                    case 0:
                        {
                            onesString = " лет";
                            break;
                        }
                    case 1:
                        {
                            onesString = " один год";
                            break;
                        }
                    case 2:
                        {
                            onesString = " два года";
                            break;
                        }
                    case 3:
                        {
                            onesString = " три года";
                            break;
                        }
                    case 4:
                        {
                            onesString = " четыре года";
                            break;
                        }
                    case 5:
                        {
                            onesString = " пять лет";
                            break;
                        }
                    case 6:
                        {
                            onesString = " шесть лет";
                            break;
                        }
                    case 7:
                        {
                            onesString = " семь лет";
                            break;
                        }
                    case 8:
                        {
                            onesString = " восемь лет";
                            break;
                        }
                    case 9:
                        {
                            onesString = " девять лет";
                            break;
                        }

                    default:
                        {
                            goto input;
                        }
                        
                }

                Console.Write(age);
                Console.Write(tensString+ onesString);                
            }
            else
            {
                Console.WriteLine("Введено не корректное значение");
                Console.WriteLine("Введите возраст заново.5");
                goto input;
            }
            Console.ReadKey();
        }
    }
}
