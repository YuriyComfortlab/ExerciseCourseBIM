/*Задан класс Building, который описывает здание. Класс содержит следующие элементы:

адрес здания;
длина здания;
ширина здания;
высота здания.
В классе Building нужно реализовать следующие методы:

конструктор с 4 параметрами;
свойства get/set для доступа к полям класса;
метод Print(), который выводит информацию о здании.
Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:

конструктор с 5 параметрами – реализует вызов конструктора базового класса;
свойство get/set доступа к внутреннему полю класса;
метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
Класс MultiBuilding сделать таким, что не может быть унаследован.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13Nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Москва", 20000, 30000, 50000);
            Console.WriteLine("Class Building:");
            building.Print(); 
            Console.WriteLine();

            MultiBuilding multibuilding = new MultiBuilding ("Новосибирск", 40000, 50000, 100000, 99);
            Console.WriteLine("Class MultiBuilding:");
            multibuilding.Print();

            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
       // public Building() { }

        public Building(string adress, int length, int width, int height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Adress   {0} ", Adress);
            Console.WriteLine("Length = {0:0,0} ", Length);
            Console.WriteLine("Width  = {0:0,0} ", Width);
            Console.WriteLine("Height = {0:0,0} ", Height);
        }
    }
    sealed class MultiBuilding:Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string adress, int length, int width, int height, int floor)
            :base (adress, length, width, height)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
            Floor = floor;
        }
        public new void Print()
        {
            Building building = new Building(Adress, Length, Width, Height);
            building.Print();
            Console.WriteLine("Floor  = {0} ", Floor);
        }
    }
}
