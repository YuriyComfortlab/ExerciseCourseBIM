/*Разработать абстрактный класс Animal, который описывает животное. 
Класс содержит следующие элементы:
абстрактное свойство - название животного.
В классе Animal нужно определить следующие методы:

конструктор, устанавливающий значение по умолчанию для названия;
абстрактный метод Say(), который выводит звук, который издает животное;
неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).

Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
свойство – название животного;
метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14AbstractСlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Лабрадор");
            dog.ShowInfo();
            Console.WriteLine();
            Cat cat = new Cat("Сиамский");
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }       // абстрактное св-в - название животного, не изменно внутри класса
        public abstract string Breed { get; set; }      //добавил породу - порода - может меняться внутри класса
        public Animal(string breed)                    
        {          
        }
        public abstract string Say();                   //абстрактный класс
        public void ShowInfo()                          //неабстрактный класс, вызывающий say
        {
            Console.WriteLine("Название животного  - {0}", Name);
            Console.WriteLine("Порода животного    - {0}", Breed);
            Console.WriteLine("Звук животного      - {0}", Say());
        }
    }

    class Dog : Animal
    {
        string name = "Собака";                      //название по умолчанию, не изменяется т.к. класс Dog подразумевает что это собака
        string breed;                                //порода, которая может меняться
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        public Dog(string breed)
        : base(breed)
        {
            Breed = breed;
        }
        public override string Say()
        {
            return "Гав-гав";
        }
    }
    class Cat : Animal
    {
        string name = "Кошка";                     
        string breed;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }
        public Cat(string breed)
        : base(breed)
        {
            Breed = breed;
        }
        public override string Say()
        {
            return "Мяу-мяу";
        }
    }

}
