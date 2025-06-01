using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisKöşegen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kare matrisin boyutunu giriniz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] dizi = new int[n, n];
            Random rnd = new Random();


            Console.WriteLine("----------KARE MATRİSİMİZ----------");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dizi[i, j] = rnd.Next(1, 11);
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            int toplam = 0;
            if (n % 2 == 0)
            {     for (int i = 0; i < n; i++)
                {
                    toplam += dizi[i, i];
                }

                for (int i = 0; i < n; i++)
                {
                    toplam += dizi[i, n - i - 1];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    toplam += dizi[i, i];
                }

                for (int i = 0; i < n; i++)
                {
                    toplam += dizi[i, n - i - 1];
                }
                toplam = toplam - dizi[n/2,n/2];
            }
                Console.WriteLine("Köşegenlerdeki elemanların toplamı: " + toplam);
        }
    }
}