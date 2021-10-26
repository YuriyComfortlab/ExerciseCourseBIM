/*1.    Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

Разработать класс для моделирования объекта «Товар». 
Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.IO;

namespace JsonToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "d:/BIM/Products.json";
            int number = 5;
            Product[] products = new Product[number];
            int code = 0;
            string name = "";
            double price = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Введите данные товара {0}", i + 1);
                Console.Write("Введите код продукта ");
                code = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите название продукта ");
                name = Console.ReadLine();

                Console.Write("Введите цену продукта ");
                price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product()
                { CodeProduct = code, NameProduct = name, PriceProduct = price };
                Console.WriteLine();
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(products, options);
            File.WriteAllText(path, jsonString);          
           
        }

    }
    public class Product
    {
        [JsonPropertyName("Код товара")]
        public int CodeProduct { get; set; }
        [JsonPropertyName("Название товара")]
        public string NameProduct { get; set; }
        [JsonPropertyName("Цена товара")]
        public double PriceProduct { get; set; }
    }


}
