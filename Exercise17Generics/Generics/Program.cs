
/*1.    Создать класс для моделирования счета в банке. 
 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
 * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
 * Создать  несколько экземпляров класса, параметризированного различными типам. 
 * Заполнить его поля и вывести информацию об экземпляре класса на печать.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Write(123234234,5345435,"Иванов И.И.");
            bankAccount1.Print();
            Console.WriteLine();

            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Write("счет № 789456", 789654.45, "Петров П.П.");
            bankAccount2.Print();

            Console.ReadLine();
        }
    }
    class BankAccount<T>
    {
        private T number;
        private double balance;
        private string fio;

        public T Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Fio
        {
            get
            {
                return fio;
            }
            set
            {
                fio = value;
            }
        }

        public void Write (T number, double balance, string fio)
        {
            Number = number;
            Balance = balance;
            Fio = fio;
        }
        public void Print()
        {
            Console.WriteLine("ФИО          {0} ", Fio);
            Console.WriteLine("Номер счета  {0} ", Number); 
            Console.WriteLine("Баланс счета {0:N2} руб.", Balance);            
        }       
    }
}
