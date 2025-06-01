using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisKumSaati
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3'ten büyük bir sayı giriniz(Matris boyutu): ");
            int n=int.Parse(Console.ReadLine());
            int[,] dizi = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine();
            
            Console.WriteLine("----------MATRİSİMİZ----------");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dizi[i,j] = rnd.Next(1,10);
                    Console.Write(dizi[i,j]+"  ");
                }
                Console.WriteLine();
            }
            int toplam = 0;
            Console.WriteLine();
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                for (int j = i;j<=(n-1-i);j++)
                {
                    toplam += dizi[i - 1, j] + dizi[n - i, j];
                }
            }
            Console.WriteLine();
            Console.Write("Kum saati(köşegenlerin üst ve altındaki alanların toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
