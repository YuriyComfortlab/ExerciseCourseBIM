/*На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A, 
 * и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, 
 * совпадать с А или между собой - выдать соответствующее сообщение.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_A_B_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int xA, xB, xC;
            input:
            Console.Write("Введите координату точки A xA = ");
            xA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату точки B xB = ");
            xB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату точки C xC = ");
            xC = Convert.ToInt32(Console.ReadLine());
            if ((xA!=xB)&&(xB!=xC)&&(xC!=xA))
            {
                if (Math.Abs(xA - xB) == Math.Abs(xA - xC))
                {
                    Console.WriteLine("Координаты введены не корректно, точки B и C равноудалены от А");
                    Console.WriteLine("Введите координаты заново");
                    goto input;
                }
                else
                {
                    if (Math.Abs(xA - xB) < Math.Abs(xA - xC))
                    {
                        Console.WriteLine("Ближайшая точка B, расстояние до точки A = {0}", Math.Abs(xA - xB));
                    }
                    if (Math.Abs(xA - xB) > Math.Abs(xA - xC))
                    {
                        Console.WriteLine("Ближайшая точка C, расстояние до точки A = {0}", Math.Abs(xA - xC));
                    }
                }

            }

            else
            {
                Console.WriteLine("Координаты введены не корректно, есть совпадающие координаты");
                Console.WriteLine("Введите координаты заново");
                goto input;
            }
            
            Console.ReadKey();
        }
    }
}
