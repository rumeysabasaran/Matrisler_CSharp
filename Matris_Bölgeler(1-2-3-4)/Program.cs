using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Bölgeler_1_2_3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("3'ten büyük bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,]dizi =new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("----------------- DİZİ MATRİSİ -----------------");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dizi[i, j] = rnd.Next(1,10);
                    Console.Write(dizi[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // BÖLGE 1: Üst üçgen bölgesi ( köşegenler hariç)
            int toplam = 0;
            Console.WriteLine("----------------- BÖLGE 1 -----------------");
            for (int i = 0; i < n / 2; i++)
            {
               for (int j = i+1; j < n-1-i; j++)
                {
                    toplam+=dizi[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bölge 1'in toplamı: " + toplam);
            Console.WriteLine();    

            // BÖLGE 2: Sağ üçgen bölgesi ( köşegenler hariç)
            toplam = 0;
            Console.WriteLine("----------------- BÖLGE 2 -----------------");
            for (int i=n-1;i>(n-1)/2; i--)
            {
                for (int j = n-i; j < i; j++)
                {
                    toplam += dizi[j, i];
                }
                Console.WriteLine();
            }
            Console.Write("Bölge 2'nin toplamı: " + toplam);
            Console.WriteLine();

            // BÖLGE 3: Alt üçgen bölgesi ( köşegenler hariç)
            toplam = 0;
            Console.WriteLine("----------------- BÖLGE 3 -----------------");
            for (int i = n - 1; i > (n-1)/ 2; i--)
            {
                for (int j = i - 1; j > n-i-1; j--)
                {
                    toplam += dizi[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bölge 3'ün toplamı: " + toplam);
            Console.WriteLine();

            // BÖLGE 4: Sol üçgen bölgesi ( köşegenler hariç)
            toplam = 0;
            Console.WriteLine("----------------- BÖLGE 4 -----------------");
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                for (int j = i + 1; j < n - 1 - i; j++)
                {
                    toplam += dizi[j, i];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bölge 4'ün toplamı: " + toplam);
Console.ReadKey();
           
        }
    }
}
