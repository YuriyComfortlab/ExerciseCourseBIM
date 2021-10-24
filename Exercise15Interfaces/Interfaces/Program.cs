/*Разработать интерфейс ISeries генерации ряда чисел. 
 * Интерфейс содержит следующие элементы:

метод void setStart(int x) - устанавливает начальное значение
метод int getNext() - возвращает следующее число ряда
метод void reset() - выполняет сброс к начальному значению
Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            ArithProgression arith = new ArithProgression(10);  // 10 - разность ариф прогрессии
            arith.setStart(45);
            arith.getNext();
            arith.getNext();
            arith.getNext();
            arith.reset();
            arith.getNext();

            Console.WriteLine();

            GeomProgression geom = new GeomProgression(2);  //100 - знаменатель геом прогрессии
            geom.setStart(4);
            geom.getNext();
            geom.getNext();
            geom.getNext();
            geom.reset();
            geom.getNext();

            Console.ReadKey();
        }
    }
    interface ISeries
    {
        int D { get; set; }
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int d;
        int begin;
        public int D
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public ArithProgression(int d)
        {
            D = d;
        }
        int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void setStart(int x)
        {
            //Console.Write("Введите начальное значение a = ");
            //x = Convert.ToInt32(Console.ReadLine());

            X = x;
            begin = x;
            Console.WriteLine("Начальное значение a = {0}", X);
        }


        public int getNext()
        {

            X += D;
            Console.WriteLine("Следующее значение ряда арифметической прогрессии {0}", X);
            return X;

        }

        public void reset()
        {
            X = begin;            
        }
    }
    class GeomProgression : ISeries
    {
        int d;
        int begin;
        public int D
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }
        public GeomProgression(int d)
        {
            D = d;
        }
        int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void setStart(int x)
        {
            //Console.Write("Введите начальное значение a = ");
            //  x = Convert.ToInt32(Console.ReadLine());
            X = x;
            begin = x;
            Console.WriteLine("Начальное значение a = {0}", X);
        }


        public int getNext()
        {

            X *= D;
            Console.WriteLine("Следующее значение ряда геометрической прогрессии {0}", X);
            return X;

        }

        public void reset()
        {
            X = begin;           
        }
    }
}



