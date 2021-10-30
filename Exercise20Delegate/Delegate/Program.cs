/*приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-метод получает входным параметром переменную типа double;
-метод возвращает значение типа double, которое является результатом вычисления.

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-длину окружности по формуле D = 2 * π* R;
-площадь круга по формуле S = π* R²;
-объем шара.Формула V = 4 / 3 * π * R³.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        delegate double RadiusDelegate(double r);
        static void Main(string[] args)
        {
           
            Console.Write("Введите радиус R= ");
            double r = Convert.ToDouble(Console.ReadLine());

            RadiusDelegate circuitDelegate = Сircuit;
            if (circuitDelegate != null)
            {
                Console.WriteLine("Длина окружности радиуса {0} = {1:F2}", r, circuitDelegate(r));
            }

            RadiusDelegate areaDelegate =Area;
            if (circuitDelegate != null)
            {
                Console.WriteLine("Площадь круга радиуса {0} = {1:F2}", r, areaDelegate(r));
            }

            RadiusDelegate volumeDelegate = Volume;
            if (circuitDelegate != null)
            {
                Console.WriteLine("объем шара радиуса {0} = {1:F2}", r, volumeDelegate(r));
            }            
            Console.ReadKey();
        }

        static double Сircuit(double r)
        {
            double result = 2 * Math.PI * r;
            return result;
        }
        static double Area(double r)
        {
            return Math.PI *Math.Pow(r,2);
        }
        static double Volume(double r)
        {
            return (4/3)* Math.PI * Math.Pow(r, 3);
        }

    }

    
}
