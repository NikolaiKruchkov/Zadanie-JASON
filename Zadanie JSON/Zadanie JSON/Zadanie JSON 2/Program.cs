using System;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.RegularExpressions;
using System.IO;
namespace Zadanie_JSON_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nikryuchkov\Desktop\New folder (3)\Products.json.txt";
            string read = File.ReadAllText(path);
            string[] massiv = read.Split("}");
            for (int i=0; i<5; i++)
            {
                massiv[i] += "}";
            }
            Tovar[] tovari=new Tovar[5];
            for (int j = 0; j<5; j++)
            {
                Tovar tovar = JsonSerializer.Deserialize<Tovar>(massiv[j]);
                tovari[j] = tovar;
            }
            Tovar tovar1 = tovari[0];
            Tovar tovar2 = tovari[1];
            Tovar tovar3 = tovari[2];
            Tovar tovar4 = tovari[3];
            Tovar tovar5 = tovari[4];
            double max = 0;
            int s = 0;
            for (int r = 0; r < 5; r++)
            {
                if (tovari[r].CenaTovara > max)
                {
                    max = tovari[r].CenaTovara;
                }
            } 
            for (int l = 0; l < 5; l++)
                {
                    if (tovari[l].CenaTovara == max)
                    {
                    Console.WriteLine("Название самого дорогого товара {0}, цена самого дорогого товара {1}", tovari[l].NazvanieTovara, max);
                    }

                }
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


