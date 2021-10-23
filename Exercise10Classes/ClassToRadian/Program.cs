/*1.   Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
 * Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных. 
 * Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы. 
 * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.


 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToRadian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы = ");
            bool successfullyGradus = int.TryParse(Console.ReadLine(), out int gradus);
            Console.Write("Введите минуты = ");
            bool successfullyMin = int.TryParse(Console.ReadLine(), out int min);
            Console.Write("Введите секунды = ");
            bool successfullySec = int.TryParse(Console.ReadLine(), out int sec);
            if (!successfullyGradus || !successfullyMin || !successfullySec)
            {
                Console.WriteLine("Одно из значений введено не верно, будет принято = 0");
            }
            Angle angle = new Angle(gradus, min, sec);
            angle.ToRadians();
            Console.ReadKey();
        }
    }
    class Angle
    {
        int gradus;
        int min;
        int sec;


        public int Gradus
        {
            set
            {
                if (value >= 0 && value <= 360)
                {
                    gradus = value;
                }

                else
                {
                    Console.WriteLine("Градусы должны быть в диапазоне 0...360");
                    gradus = value - (value / 360) * 360;

                }
            }
            get
            {
                return gradus;
            }
        }

        public int Min
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    min = value;
                }

                else
                {
                    Console.WriteLine("Минуты должны быть в диапазоне 0...60");
                    min = value - (value / 60) * 60;
                }
            }
            get
            {
                return min;
            }
        }

        public int Sec
        {
            set
            {
                if (value >= 0 && value <= 60)
                {
                    sec = value;
                }

                else
                {
                    Console.WriteLine("Секунды должны быть в диапазоне 0...60");
                    sec = value - (value / 60) * 60;
                }
            }
            get
            {
                return sec;
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

        public void ToRadians()
        {
            Console.WriteLine("градус {0}, минуты {1}, секунды {2}", Gradus, Min, Sec);
            double radian = (Convert.ToDouble(Gradus) + (Convert.ToDouble(Min) + Convert.ToDouble(Sec) / 60) / 60) * Math.PI / 180;
            Console.WriteLine("В радианах = {0:F3}", radian);

        }
    }
}
