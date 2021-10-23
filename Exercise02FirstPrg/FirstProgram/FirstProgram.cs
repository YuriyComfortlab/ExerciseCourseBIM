/*ЦЕЛЬ
Научиться составлять линейные алгоритмы на языке C#.
ХОД РАБОТЫ
1.	решить задачи: набрать текст программы, протестировать работоспособность, используя различные наборы исходных данных. 
Обязательные задачи обозначены *. Остальные задачи решить желательно, это позволит Вам лучше понять пройденную тему.
2.	оформить отчет.

СОДЕРЖАНИЕ ОТЧЕТА
архив с файлами проекта.
ПРАКТИЧЕСКАЯ ЧАСТЬ
Задачи

Обязательная задача*. Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью.
Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2, y2). Стороны прямоугольника параллельны осям координат. 
Найти периметр и площадь данного прямоугольника.
Даны координаты трех вершин треугольника: (x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь, используя формулу для расстояния 
между двумя точками на плоскости. Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона: ,  где  — полупериметр.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class FirstProgram
    {
        static void Main(string[] args)
        {
            #region Задача 1: Площадь и радиус круга
            Console.WriteLine("Задача 1: Нахождение площади и радиуса круга");
            Console.Write("Введите длину окружности L = ");
            double lengthCircle = Convert.ToInt32(Console.ReadLine());

            double areaCircle;
            double radiusCircle;
            radiusCircle = lengthCircle / (2 * Math.PI);
            areaCircle = Math.Pow(lengthCircle, 2) / (4 * Math.PI);

            Console.WriteLine("Радиус круга R = {0}", radiusCircle);
            Console.WriteLine("Площадь круга S =  {0}", areaCircle);
            Console.WriteLine("Нажмите любую клавишу для перехода к задаче 2");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Задача 2: Периметр и площадь прямоугольника
            Console.WriteLine("Задача 2: Нахождение периметра и площади прямоугольника");
            Console.Write("Введите координату x1 = ");
            int x1Rectangle = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y1 = ");
            int y1Rectangle = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x2 = ");
            int x2Rectangle = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y2 = ");
            int y2Rectangle = Convert.ToInt32(Console.ReadLine());

            int lengthA = Math.Abs(x1Rectangle - x2Rectangle);                    //сторона А
            int lengthB = Math.Abs(y1Rectangle - y2Rectangle);                    //сторона B
            int areaRectangle = lengthA * lengthB;              //площадь прямоугольника
            int perimetrRectangle = (lengthA + lengthB) * 2;    //периметр прямоугольника

            Console.WriteLine("Сторона А по оси X прямоугольника равна {0}", lengthA);
            Console.WriteLine("Сторона B по оси Y прямоугольника равна {0}", lengthB);
            Console.WriteLine("Площадь прямоугольника S = {0}", areaRectangle);
            Console.WriteLine("Периметр прямоугольника P = {0}", perimetrRectangle);
            Console.WriteLine("Нажмите любую клавишу для перехода к задаче 3");
            Console.WriteLine();
            Console.ReadKey();
            #endregion

            #region Задача 3: Периметр и площадь треугольника
            Console.WriteLine("Задача 3: Нахождение периметра и площади треугольника");
            Console.Write("Введите координату x первой вершины x1 = ");
            double x1Triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y первой вершины y1 = ");
            double y1Triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x второй вершины x2 = ");
            double x2Triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y второй вершины y2 = ");
            double y2Triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x третьей вершины x3 = ");
            double x3Triangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y третьей вершины y3 = ");
            double y3Triangle = Convert.ToDouble(Console.ReadLine());


            //Вычисление расстояния между взятыми на плоскости двумя точками А(хА; уА) и В(хВ; уВ),
            //выполняется по формуле d = √((хА – хВ)^2 + (уА – уВ)^2),
            //где d – длина отрезка, который соединяет эти точки на плоскости.

            double lengthATriangle = Math.Sqrt(Math.Pow((x1Triangle - x2Triangle), 2) + Math.Pow((y1Triangle - y2Triangle), 2));                   //сторона А
            double lengthBTriangle = Math.Sqrt(Math.Pow((x2Triangle - x3Triangle), 2) + Math.Pow((y2Triangle - y3Triangle), 2));
            double lengthCTriangle = Math.Sqrt(Math.Pow((x3Triangle - x1Triangle), 2) + Math.Pow((y3Triangle - y1Triangle), 2));
            Console.WriteLine("Сторона А треугольника равна {0}", lengthATriangle);
            Console.WriteLine("Сторона B треугольника равна {0}", lengthBTriangle);
            Console.WriteLine("Сторона C треугольника равна {0}", lengthCTriangle);
            //периметр
            double perimetrTriangle = lengthATriangle + lengthBTriangle + lengthCTriangle;
            Console.WriteLine("Периметр треугольника равен {0}", perimetrTriangle);
            //полупериметр
            double halfPerimetrTriangle = perimetrTriangle / 2;
            //Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона
            double areaTriangle = Math.Sqrt(halfPerimetrTriangle * (halfPerimetrTriangle - lengthATriangle) * (halfPerimetrTriangle - lengthBTriangle) * (halfPerimetrTriangle - lengthCTriangle));
            Console.WriteLine("Площадь треугольника равна {0}", areaTriangle);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
            #endregion
        }
    }
}
