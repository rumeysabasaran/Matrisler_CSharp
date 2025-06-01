using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringİşlemler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a= "Merhaba Dünya";
            string b = "Dünya";
            //long x = 50000000000000000;
            //a=x.ToString("N");//basamaklara nokta ve en sona iki basamak ondalık ayıraç koyar.
            //Console.WriteLine(a);

            Console.WriteLine("Bir ifade giriniz:");
            string a = Console.ReadLine();
            Console.WriteLine("Değer= .{0}.", a); //başına ve sonuna nokta koyar.
            Console.WriteLine("Yeni= {0}", a.TrimStart()); //başındaki boşlukları siler.
            Console.WriteLine("Yeni= {0}", a.TrimEnd()); //sonundaki boşlukları siler.
            Console.WriteLine("Yeni= {0}", a.Trim()); //başındaki ve sonundaki boşlukları siler.
            Console.WriteLine("Karşılaştırma= {0}",String.Compare(a, b)); 
            //iki stringi karşılaştırır. 0 ise eşit, 1 ise a>b, -1 ise a<b demektir.
            Console.WriteLine("Birleştirme={0}", String.Concat(a, b));

            Console.WriteLine("Arama={0}", a.IndexOf("ha"));
            //a içinde "ha" ifadesinin ilk geçtiği yeri bulur.İndexini döndürür. Bulamazsa -1 döner.

            Console.WriteLine("Arama = {0}", a.IndexOf("ba",4));
            //a içinde "ba" ifadesinin 4. indexten sonraki ilk geçtiği yeri bulur.İndexini döndürür. Bulamazsa -1 döner.

            Console.WriteLine("Arama= {0}",a.IndexOf("ün", 4, 5));
            //a içinde "ün" ifadesinin 4. indexten başlayarak 5 karakter içinde arar.
            //Bulursa indexini döner, bulamazsa -1 döner.

            Console.WriteLine("Arama= {0}", a.LastIndexOf("a"));
            //a içinde "a" ifadesinin son geçtiği yeri bulur.İndexini döndürür. Bulamazsa -1 döner.

            Console.WriteLine("Arama= {0}", a.LastIndexOf("a", 4));
            //a içinde "a" ifadesinin 4. indexten önceki son geçtiği yeri bulur.İndexini döndürür. Bulamazsa -1 döner.

            Console.WriteLine("Arama= {0}", a.LastIndexOf("a", 4, 5));
            // a'nın belirtilen indisinden sola doğru belirtilen uzunluk kadar yerde arar bulursa indexini döner, bulamazsa -1 döner.

            //---------------------------------------------------------------------------------------------

            string[]y = a.Split('.'); 
            // nokta gördüğü yerde split ile bölüyor ve böldüğü kısımlardan diziye eleman oluşturuyor.
            for (int i = 0; i < y.Length-1; i++)
            {
                Console.WriteLine("Parçalı dizisinin {0} elemanı={1}",i,y[i]);
            }
            Console.WriteLine("Cümle Sayısı={0}", y.Length-1); //sondaki boşluğu almamak için -1 yapıyoruz
            //---------------------------------------------------------------------------------------------

            b = a.Substring(4);
            Console.WriteLine("Alt ifade= " + b);
            //a'nın 4. indisinden itibaren alt ifadeyi alır.

            b = a.Substring(4, 5);
            Console.WriteLine("Alt ifade= " + b);
            //a'nın 4. indisinden itibaren 5 karakterlik alt ifadeyi alır.

            Console.ReadLine();
        }
    }
}
