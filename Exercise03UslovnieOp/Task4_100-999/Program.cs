/*Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 
 * 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_100_999
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, hundreds, tens, ones, tensTwo;
            string hundredsString, tensString, onesString;
            input:
            Console.WriteLine("Введите число в диапазоне 100...999");
            n = Convert.ToInt32(Console.ReadLine());
            if ((n >= 100) && n <= 999)
            {
                hundreds = n / 100;
                tens = (n / 10)%10;
                ones = n % 10;
               // Console.WriteLine(hundreds);
               // Console.WriteLine(tens);
               // Console.WriteLine(ones);

                switch (hundreds)
                {
                    case 1:
                        {
                            hundredsString = " - Сто";
                            break;
                        }
                    case 2:
                        {
                            hundredsString = " - Двести";
                            break;
                        }
                    case 3:
                        {
                            hundredsString = " - Триста";
                            break;
                        }
                    case 4:
                        {
                            hundredsString = " - Четыреста";
                            break;
                        }
                    case 5:
                        {
                            hundredsString = " - Пятьсот";
                            break;
                        }
                    case 6:
                        {
                            hundredsString = " - Шестьсот";
                            break;
                        }
                    case 7:
                        {
                            hundredsString = " - Семьсот";
                            break;
                        }
                    case 8:
                        {
                            hundredsString = " - Восемьсот";
                            break;
                        }
                    case 9:
                        {
                            hundredsString = " - Девятьсот";
                            break;
                        }
                    default:
                        {
                            goto input;
                        }
                }


                switch (tens)
                {
                    case 0:
                        {
                            tensString = "";
                            break;
                        }
                    case 1:
                        {
                            tensTwo = n  % 100;
                            switch (tensTwo)
                            {
                                case 10:
                                    {
                                        tensString = " Десять";
                                        break;
                                    }
                                case 11:
                                    {
                                        tensString = " Одинадцать";
                                        break;
                                    }
                                case 12:
                                    {
                                        tensString = " Двенадцать";
                                        break;
                                    }
                                case 13:
                                    {
                                        tensString = " Тринадцать";
                                        break;
                                    }
                                case 14:
                                    {
                                        tensString = " Четырнадцать";
                                        break;
                                    }
                                case 15:
                                    {
                                        tensString = " Пятнадцать";
                                        break;
                                    }
                                case 16:
                                    {
                                        tensString = " Шестнадцать";
                                        break;
                                    }
                                case 17:
                                    {
                                        tensString = " Семнадцать";
                                        break;
                                    }
                                case 18:
                                    {
                                        tensString = " Восемнадцать";
                                        break;
                                    }
                                case 19:
                                    {
                                        tensString = " Девятнадцать";
                                        break;
                                    }
                                default:
                                    {
                                        goto input;
                                    }

                                    break;
                            }

                            break;
                        }
                    case 2:
                        {
                            tensString = " Двадцать";
                            break;
                        }
                    case 3:
                        { 
                            tensString = " Тридцать";
                            break;
                        }
                    case 4:
                        {
                            tensString = " Сорок";
                            break;
                        }
                    case 5:
                        {
                            tensString = " Пятьдесят";
                            break;
                        }
                    case 6:
                        {
                            tensString = " Шестьдесят";
                            break;
                        }
                    case 7:
                        {
                            tensString = " Семьдесят";
                            break;
                        }
                    case 8:
                        {
                            tensString = " Восемьдесят";
                            break;
                        }
                    case 9:
                        {
                            tensString = " Девяносто";
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
                            onesString = "";
                            break;
                        }
                    case 1:
                        {
                            onesString = " один";
                            break;
                        }
                    case 2:
                        {
                            onesString = " два";
                            break;
                        }
                    case 3:
                        {
                            onesString = " три";
                            break;
                        }
                    case 4:
                        {
                            onesString = " четыре";
                            break;
                        }
                    case 5:
                        {
                            onesString = " пять";
                            break;
                        }
                    case 6:
                        {
                            onesString = " шесть";
                            break;
                        }
                    case 7:
                        {
                            onesString = " семь";
                            break;
                        }
                    case 8:
                        {
                            onesString = " восемь";
                            break;
                        }
                    case 9:
                        {
                            onesString = " девять";
                            break;
                        }

                    default:
                        {
                            goto input;
                        }

                }


                if (tens==1)
                {
                    Console.Write(n);
                    Console.Write(hundredsString + tensString);
                }
                else
                {
                    Console.Write(n);
                    Console.Write(hundredsString + tensString + onesString);
                }
            }
            else
            {
                Console.WriteLine("Введено не корректное значение");
                Console.WriteLine("Введите значение заново.");
                goto input;
            }
            Console.ReadKey();
        }
    }
}
