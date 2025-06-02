using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        //Öğrenci numarası girildiğinde öğrencinin ad-soyad bilgilerini ekrana yazdıran uygulama
        //Öğrenci no -> key -> int 
        //Öğrenci ad-soyad -> value -> string
        static void Main(string[] args)
        {
            Dictionary <int, string> Student = new Dictionary<int, string>();
            Student.Add(1, "John");
            Student.Add(2, "Jane");
            Student.Add(3, "Sam");
            Student.Add(4, "Sara");

            Console.Write("Öğrenci no giriniz: ");
            int no = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine(no+"numaralı öğrenci: "+Student[no]);
            }
            catch
            {
                Console.WriteLine("Öğrenci bulunamadı");
            }

            bool varmi = Student.ContainsKey(3); //3 nolu öğrenci varsa true yoksa false döner
            bool varmi2 = Student.ContainsValue("John"); //John varsa true yoksa false döner

            if (varmi)
            {
                Console.WriteLine("3 nolu öğrenci var");
            }
            else
            {
                Console.WriteLine("3 nolu öğrenci yok");
            }
            if (varmi2)
            {
                Console.WriteLine("John var");
            }
            else
            {
                Console.WriteLine("John yok");
            }
        }
    }
}
