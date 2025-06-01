using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CümleSayısıBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yöntem 1: Split metodu kullanarak cümle sayısını bulma
            Console.WriteLine("Lütfen bir metin giriniz:");
            string metin = Console.ReadLine();
            string[] cumleler = metin.Split('.');
            int cumleSayisi = (cumleler.Length) - 1;
            // Eğer metin sonu noktayla bitmiyorsa, son eleman boş olabilir.
            Console.WriteLine("Cümle sayısı= {0}", cumleSayisi);

            //  Yöntem 2: Indexof kullanarak cümle sayısını bulma
            int indis = -1;
            int sayac = 0;
            string a= "xx xx xxx. yy yyyy. yyy yyy yy. zzzz. zzzzz. zzzzzzz. zzzzzzzz.";

            while (1==1)
            {
                try
                {
                    indis=a.IndexOf(".", indis + 1);
                    if(indis!=-1)
                    {
                        sayac++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Hata oluştu");
                }
            }
            Console.WriteLine("Cümle sayısı= {0}", sayac);
        }


    }
}
