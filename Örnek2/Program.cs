using System;
using System.Collections.Generic;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ad-soyad;bölüm;ad-soyad;bölüm; şeklinde veri giriniz: ");
            string girdi = Console.ReadLine();
            Yazdir(girdi);
            Console.ReadLine();
        }
        static void Yazdir(string girdi)
        {
            string[] adsoyad_bolum = girdi.Split(';');

            int kisiSayisi = adsoyad_bolum.Length / 2;

            string[] ad_soyad = new string[kisiSayisi];
            string[] bolum = new string[kisiSayisi];

            int j = 0;
            for (int i = 0; i < adsoyad_bolum.Length - 1; i += 2)
            {
                ad_soyad[j] = adsoyad_bolum[i];
                bolum[j] = adsoyad_bolum[i + 1];
                j++;
            }

            string[] ad = new string[kisiSayisi];
            string[] soyad = new string[kisiSayisi];

            for (int i = 0; i < kisiSayisi; i++)
            {
                string[] parca = ad_soyad[i].Split('-');
                ad[i] = parca[0];
                soyad[i] = parca[1];
            }

            List<string> liste1 = new List<string>();
            foreach (var a in ad)
                if (a.Contains("es"))
                    liste1.Add(a);

            List<string> liste2 = new List<string>();
            foreach (var s in soyad)
                if (s.Contains("ds"))
                    liste2.Add(s);

            List<string> liste3 = new List<string>();
            foreach (var b in bolum)
                if (b.Contains("ce"))
                    liste3.Add(b);

            Console.WriteLine("Adları 'es' içerenler:");
            foreach (var item in liste1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Soyadları 'ds' içerenler:");
            foreach (var item in liste2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Bölümleri 'ce' içerenler:");
            foreach (var item in liste3)
            {
                Console.WriteLine(item);
            }
        }
    }
}