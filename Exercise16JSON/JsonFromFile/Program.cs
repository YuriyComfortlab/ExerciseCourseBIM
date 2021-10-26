/*Необходимо разработать программу для получения информации о товаре из json-файла.
Десериализовать файл «Products.json» из задачи 
1. Определить название самого дорогого товара.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using JsonToFile;
using System.IO;
using System.Text.Json.Serialization;

namespace JsonFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/BIM/Products.json";

            string jsonString = File.ReadAllText(path);
            Console.WriteLine(jsonString);
            //List<Product> products = JsonSerializer.Deserialize<List<Product>>(jsonString);
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            double max = 0;
            string maxPrice ="";
            foreach (var product in products)
            {
                if (max< product.PriceProduct)
                {
                    max = product.PriceProduct;
                    maxPrice = product.NameProduct;
                }       
            }
            Console.WriteLine("Максимальная цена у товара \"{0}\" = {1:F2} руб. ", maxPrice, max);
            Console.ReadKey();

        }
    }
}
