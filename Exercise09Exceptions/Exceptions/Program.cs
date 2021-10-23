/*1.    Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции 
 * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). 
 * После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, result = 0;
            char act = ' ';
            bool error = false;

            try
            {
                Console.Write("Введите число a =");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите число b =");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите действие (+,-,*,/): ");
                act = Convert.ToChar(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error {0}", ex.Message);
                error = true;
                Console.ReadKey();
            }

            finally
            {
                if (!error)
                {
                    Calc(a, b, act, out result);
                }
            }
        }
        static void Calc(double a, double b, char act, out double result)
        {
            result = 0;
            bool errorAct = false;
            switch (act)
            {
                case '+':
                    {
                        result = a + b;
                        break;
                    }
                case '-':
                    {
                        result = a - b;
                        break;
                    }
                case '*':
                    {
                        result = a * b;
                        break;
                    }
                case '/':
                    {
                        result = a / b;

                        break;
                    }
                default:

                    errorAct = true;
                    break;
            }

            if (double.IsInfinity(result) || (errorAct))
            {
                if (double.IsInfinity(result))
                {
                    Console.WriteLine("Попытка деления на 0");
                }
                if (errorAct)
                {
                    Console.WriteLine("Ввели не верное действие");
                }
            }
            else
            {
                Console.WriteLine("Result = {0:f3}", result);
            }

            Console.ReadKey();
        }
    }
}
