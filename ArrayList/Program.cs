using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
// ArrayList sınıfını kullanabilmek için gerekli kütüphane

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            List <object> KarışıkListe = new List<object>();
            for (int i = 0; i < 10; i++)
            {
                KarışıkListe.Add(i);
                Console.WriteLine("Diziye {0} eklendi.", i);
            }
            KarışıkListe.Add("Merhaba");
            KarışıkListe.Add(3.14);
            KarışıkListe.Add(true);
            KarışıkListe.Remove(5);
            KarışıkListe.RemoveAt(0); // İlk elemanı kaldırır
            KarışıkListe.Insert(0, "Yeni Eleman"); // İlk elemanı yeni bir elemanla değiştirir

            foreach (object eleman in KarışıkListe)
            {
                Console.WriteLine("Dizinin elemanı: {0}", eleman);
            }
            int elemansayisi = KarışıkListe.Count;
            Console.WriteLine("Dizinin eleman sayısı: {0}", elemansayisi);

            int kapasite = KarışıkListe.Capacity;
            Console.WriteLine("Dizinin kapasitesi: {0}", kapasite);

            bool varMi = KarışıkListe.Contains("Merhaba");//öğeyi kontrol eder varsa true yoksa false döndürür

            Console.WriteLine("Dizide 'Merhaba' var mı? {0}", varMi ? "Evet" : "Hayır");

            //KarışıkListe.Clear(); // Tüm elemanları temizler

            //KarışıkListe.Sort(); // Listeyi sıralar

           // int indeks = KarışıkListe.BinarySearch(6); //Değeri arar bulursa indeksi döndürür yoksa negatif değer döndürür.Bunu kullanmak için listenin sıralı olması gerekir.(sort metodunu kullanarak sıraladık)

            //if (indeks >= 0)
            //{
            //    Console.WriteLine("6 sayısı dizide bulundu, indeksi: {0}", indeks);
            //}
            //else
            //{
            //    Console.WriteLine("6 sayısı dizide bulunamadı.");
            //}

            KarışıkListe.Reverse(); // Listeyi ters çevirir
            Console.WriteLine("Liste ters çevrildi:");
            foreach (object eleman in KarışıkListe)
            {
                Console.WriteLine("Dizinin elemanı: {0}", eleman);
            }

            Console.ReadKey();
        }
    }
}
