/*Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
 * Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
 * параллельными координатным осям, вывести соответствующее сообщение.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int xA, yA, xB, yB, xC, yC, xD, yD;
            input:
            Console.WriteLine("A(xA,yA) ._________________.B(xB,yB)");
            Console.WriteLine("         |                 |");
            Console.WriteLine("         |                 |");
            Console.WriteLine("         |                 |");
            Console.WriteLine("D(xD,yD) ._________________.C(xC,yC");
            Console.WriteLine();
            Console.WriteLine("Введите координаты вершин A, B, C таким образом, ");
            Console.WriteLine("чтобы стороны прямоугольника были параллельны координатным осям");
            Console.Write("Введите координату x вершины A xA = ");
            xA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y вершины A yA = ");
            yA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x вершины B xB = ");
            xB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y вершины B yB = ");
            yB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату x вершины C xC = ");
            xC = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите координату y вершины C yC = ");
            yC = Convert.ToInt32(Console.ReadLine());
            //проверка одинаковых координат
            if ((xA==xB&&yA==yB) ^ (xA == xC && yA == yC) ^ (xB == xC && yB == yC)) 
            {
                Console.WriteLine("Координаты введены не корректно, есть совпадающие координаты");
                Console.WriteLine("Введите координаты заново");
                goto input;
            }
            //проверка параллельности осям
            if (((xA!=xB&&yA==yB)&&(xB==xC&&yB!=yC))^((xA==xB&&yA!=yB)&&(xB!=xC&&yB==yC)))
            {
                //если AB || X, BC || Y
                if ((xA != xB && yA == yB) && (xB == xC && yB != yC))
                {
                    xD = xA;
                    yD = yC;
                    Console.WriteLine("Координаты вершины D: xD = {0}, yD = {1}", xD, yD);
                }
                //если AB || Y, BC || X
                if ((xA == xB && yA != yB) && (xB != xC && yB == yC))
                {
                    xD = xC;
                    yD = yA;
                    Console.WriteLine("Координаты вершины D: xD = {0}, yD = {1}", xD, yD);
                }
                  
            }
            else
            {
                Console.WriteLine("Координаты введены не корректно, стороны не параллельны осям");
                Console.WriteLine("Введите координаты заново");
                goto input;
            }
            Console.ReadKey();
        }
    }
}
