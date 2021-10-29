/*Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  
 * типом  процессора,  частотой  работы  процессора,  объемом оперативной памяти, 
 * объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, 
 * имеющихся в наличии. 
 * Создать список, содержащий 6-10 записей с различным набором значений характеристик.

Определить:
- все компьютеры с указанным процессором. Название процессора запросить у пользователя; +
- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя; +
- вывести весь список, отсортированный по увеличению стоимости; +
- вывести весь список, сгруппированный по типу процессора; + 
- найти самый дорогой и самый бюджетный компьютер;
- есть ли хотя бы один компьютер в количестве не менее 30 штук? + 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Comp
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Cpu { get; set; }
        public int FreqCpu { get; set; }
        public int VolMemRam { get; set; }
        public int VolHdd { get; set; }
        public int VolMemGpu { get; set; }
        public int Cost { get; set; }
        public int Number { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var listComp = new List<Comp>()
            {
            new Comp() { Code = "001", Name = "HP", Cpu="i7", FreqCpu = 3200, VolMemRam=8,VolHdd=256,VolMemGpu=2,Cost=50000, Number=120},
            new Comp() { Code = "002", Name = "HP", Cpu="i9", FreqCpu = 3500, VolMemRam=32,VolHdd=1000,VolMemGpu=6,Cost=160000, Number=3},
            new Comp() { Code = "003", Name = "Dell", Cpu="i5", FreqCpu = 2500, VolMemRam=8,VolHdd=256,VolMemGpu=2,Cost=50000, Number=15},
            new Comp() { Code = "004", Name = "Dell", Cpu="i5", FreqCpu = 3200, VolMemRam=16,VolHdd=512,VolMemGpu=4,Cost=80000, Number=35},
            new Comp() { Code = "005", Name = "Lenovo", Cpu="i7", FreqCpu = 3500, VolMemRam=16,VolHdd=512,VolMemGpu=4,Cost=88000, Number=5},
            new Comp() { Code = "006", Name = "HP", Cpu="i9", FreqCpu = 4200, VolMemRam=64,VolHdd=2000,VolMemGpu=6,Cost=210000, Number=4},
            new Comp() { Code = "007", Name = "Lenovo", Cpu="i9", FreqCpu = 4000, VolMemRam=32,VolHdd=512,VolMemGpu=4,Cost=120000, Number=10},
            new Comp() { Code = "008", Name = "Dell", Cpu="i7", FreqCpu = 3200, VolMemRam=8,VolHdd=256,VolMemGpu=2,Cost=60000, Number=21},
            };
            Console.Write("Введите модель CPU ");
            var cpu = Console.ReadLine();
            Console.Write("Введите объем ОЗУ ");
            var ram = Convert.ToInt32(Console.ReadLine());
            FindCpu(listComp, cpu);
            FindVolMem(listComp, ram);
            SortCostUp(listComp);
            GroupCpu(listComp);
            FindCount(listComp, 30);
            FindMinMax(listComp);
            Console.ReadKey();
        }

        static void WriteList(List<Comp> comp)
        {
            foreach (var c in comp)
            {
                Console.WriteLine($"Код {c.Code,3}, Марка {c.Name,7}, Проц {c.Cpu,3}, Част {c.FreqCpu,5}, Пам {c.VolMemRam,3}, HDD {c.VolHdd,5}, Пам GPU {c.VolMemGpu,3}, Ст-ть {c.Cost,8}, Кол-во {c.Number,4}");
            }
        }
        static void FindCpu(List<Comp> listComp, string cpu)
        {
            List<Comp> comp = listComp
                    .Where(c => c.Cpu == cpu)
                    .ToList();
            Console.WriteLine();
            Console.WriteLine($"Компьютеры с процессором {cpu} : ");
            WriteList(comp);
        }
        static void FindVolMem(List<Comp> listComp, int ram)
        {
            List<Comp> comp = listComp
                    .Where(c => c.VolMemRam >= ram)
                    .ToList();
            Console.WriteLine();
            Console.WriteLine($"Компьютеры с ОЗУ >= {ram} : ");
            WriteList(comp);
        }
        static void SortCostUp(List<Comp> listComp)
        {
            List<Comp> comp = listComp
                    .OrderBy(c => c.Cost)
                    .ToList();
            Console.WriteLine();
            Console.WriteLine($"Сортировка по возрастанию цены:");
            WriteList(comp);
        }
        static void GroupCpu(IEnumerable<Comp> listComp)
        {
            var comp = listComp
                .GroupBy(c => c.Cpu);
            Console.WriteLine();
            Console.WriteLine($"Группировка по типу CPU");
            foreach (var group in comp)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine($"    {item.Name} {item.Code}");
                }
            }
        }
        static void FindMinMax(IEnumerable<Comp> listComp)
        {
            var min = listComp
                .Min(c => c.Cost);
            var max = listComp
                .Max(c => c.Cost);
            var compMin = listComp
            .Where(c => c.Cost == min)
            .ToList();
            var compMax = listComp
           .Where(c => c.Cost == max)
           .ToList();
            Console.WriteLine($"минимальная стоимость {min:0,0}");
            WriteList(compMin);
            Console.WriteLine($"Максимальная стоимость {max:0,0}");
            WriteList(compMax);
        }
        static void FindCount(List<Comp> listComp, int number)
        {
            var comp = listComp
                    .Where(c => c.Number > number)
                    .Count();
            Console.WriteLine();
            Console.WriteLine($"Количество типов более {number} = {comp}");
        }
    }
}
