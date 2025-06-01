using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KöşegenÜstü
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
            for (int i = 0; i <= n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    toplam += dizi[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Köşegenin üstündekilerin toplamı: "+toplam);
            Console.WriteLine();

            int sonuc = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0 ; j < i; j++)
                {
                    sonuc += dizi[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Köşegenin altındakilerin toplamı: " + sonuc);
            Console.WriteLine();

            int son = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i ; j < n; j++)
                {
                    son += dizi[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Köşegenler ve üstündekilerin toplamı: " + son);
            Console.WriteLine();

            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    result += dizi[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Köşegenler ve altındakilerin toplamı: " + result);

            Console.Read();
        }
    }
}