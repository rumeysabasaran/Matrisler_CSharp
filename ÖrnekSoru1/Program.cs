using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖrnekSoru1
{
    class Program
    {
        //2020-2021 BÜT SORUSU 1
        static void Main(string[] args)
        {
            Console.Write("Lütfen dizinin boyutu olacak bir tek sayı giriniz: ");
            Console.Write("Dizi boyutu: n x n (n x n kare matris)");
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] dizi = new int[n, n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int a;
                    do
                    {
                        a = rnd.Next(1, 11);
                    }
                    while (a % 7 != 0);
                    dizi[i, j] = a;
                    Console.Write(dizi[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sonuc = AralıklıKumSaati(dizi);
            Console.WriteLine("Aralıklı kum saati toplamı: " + sonuc);

            Console.ReadLine();
        }
        
        public static int AralıklıKumSaati(int[,]dizi)
        {
            int toplam1 = 0;
            int toplam2 = 0;
            int n = dizi.GetLength(0); // Dizinin boyutunu al
            // Üst üçgen ve alt üçgen toplamlarını hesapla

            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = i; j <= n - i - 1; j += 2)
                {
                    toplam1 += dizi[i,j];
                }
            }

            for (int i = n - 1; i > n / 2; i--)
            {
                for (int j = n - i - 1; j <= i; j += 2)
                {
                    toplam2 += dizi[i,j];
                }
            }
            int sonuc = toplam1 + toplam2;
            return sonuc;
        }
    }
}
