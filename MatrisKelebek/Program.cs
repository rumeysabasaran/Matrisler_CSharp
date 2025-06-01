using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisKelebek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3'ten büyük bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] dizi = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dizi[i, j] = rnd.Next(1, 10);
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }

            int toplam = 0;
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                for (int j = i; j <= (n - i - 1); j++)
                {
                    toplam += dizi[j, i - 1] + dizi[j, n - i];
                }
            }
            Console.WriteLine();
            Console.Write("Köşegenlerin yanındaki elemanların toplamı(kelebek): "+toplam);
            Console.Read();
        }

    }
}