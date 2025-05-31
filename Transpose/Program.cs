using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transpose
{
    class Program
    {
        private static int j;

        static void Main(string[] args)
        {
            Console.Write("Matrisin satır sayısını giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Matrisin sütun sayısını giriniz: ");
            int b = int.Parse(Console.ReadLine());

            int[,] dizi = new int[a, b];
            Random rnd = new Random();

            Console.WriteLine("DİZİNİN NORMAL HALİ");
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    dizi[i, j] = rnd.Next(1,11);
                    Console.Write(dizi[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("DİZİNİN TRANSPOSE HALİ");
            Console.WriteLine();
            int[,]transposedizi = new int[b, a];
            for(int i = 0;i < b; i++)
            {
                for(int j = 0;  j < a; j++)
                {
                    transposedizi[i, j] = dizi[j,i];
                    Console.Write(transposedizi[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
