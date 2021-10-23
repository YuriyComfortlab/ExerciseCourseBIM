/*1.    Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории. 
 * Выведите на консоль ее содержимое и содержимое всех подкаталогов.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryFound
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/BIM";
            Folders(path);
            Console.ReadKey();
        }

        static void Folders(string path)
        {
            Console.WriteLine();
            Console.WriteLine(path);
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo [] subdires = directory.GetDirectories();
            FileInfo []  files = directory.GetFiles();

            foreach (DirectoryInfo subdir in subdires)
            {
                Console.WriteLine(subdir.FullName);
            }

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName);
            }

            foreach (DirectoryInfo subdir in subdires)
            {
                Folders(subdir.FullName);
            }

            
        }
    }
}
