using System;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Zadanie_JSON
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите код товара 1, затем нажмите Enter");
            int kod1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара 1, затем нажмите Enter");
            string naz1 = Console.ReadLine();
            Console.WriteLine("Введите цену товара 1, затем нажмите Enter");
            double cen1 = Convert.ToDouble(Console.ReadLine());
            #region
            Console.WriteLine("Введите код товара 2, затем нажмите Enter");
            int kod2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара 2, затем нажмите Enter");
            string naz2 = Console.ReadLine();
            Console.WriteLine("Введите цену товара 2, затем нажмите Enter");
            double cen2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код товара 3, затем нажмите Enter");
            int kod3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара 3, затем нажмите Enter");
            string naz3 = Console.ReadLine();
            Console.WriteLine("Введите цену товара 3, затем нажмите Enter");
            double cen3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код товара 4, затем нажмите Enter");
            int kod4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара 4, затем нажмите Enter");
            string naz4 = Console.ReadLine();
            Console.WriteLine("Введите цену товара 4, затем нажмите Enter");
            double cen4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код товара 5, затем нажмите Enter");
            int kod5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название товара 5, затем нажмите Enter");
            string naz5 = Console.ReadLine();
            Console.WriteLine("Введите цену товара 5, затем нажмите Enter");
            double cen5 = Convert.ToDouble(Console.ReadLine());
            #endregion
            string path = @"C:\Users\Nikryuchkov\Desktop\New folder (3)\Products.json.txt";
            StreamWriter sr = new StreamWriter(path);
            Tovar tovar1 = new Tovar()
            {
                KodTovara = kod1,
                NazvanieTovara = naz1,
                CenaTovara = cen1
            };
            #region
            Tovar tovar2 = new Tovar()
            {
                KodTovara = kod2,
                NazvanieTovara = naz2,
                CenaTovara = cen2
            };
            Tovar tovar3 = new Tovar()
            {
                KodTovara = kod3,
                NazvanieTovara = naz3,
                CenaTovara = cen3
            };
            Tovar tovar4 = new Tovar()
            {
                KodTovara = kod4,
                NazvanieTovara = naz4,
                CenaTovara = cen4
            };
            Tovar tovar5 = new Tovar()
            {
                KodTovara = kod5,
                NazvanieTovara = naz5,
                CenaTovara = cen5
            };
            #endregion
            Tovar[]massiv ={ tovar1, tovar2, tovar3, tovar4, tovar5 };
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            foreach (Tovar i in massiv)
            {
                string jsonString1 = JsonSerializer.Serialize(i, options);
                sr.WriteLine(jsonString1);
            }
            sr.Close();
            Console.WriteLine("Информация записана в файл по указанному пути, для продолжения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
    class Tovar
    {
        public int KodTovara { get; set; }
        public string NazvanieTovara { get; set; }
        public double CenaTovara { get; set; }
    }

}
