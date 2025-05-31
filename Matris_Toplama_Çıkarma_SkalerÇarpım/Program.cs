using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_Toplama_Çıkarma_SkalerÇarpım
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin ilk boyutu kaç olsun?: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Matrisin ikinci boyutu kaç olsun: ");
            int b = int.Parse(Console.ReadLine());

            int[,] M = new int[a, b];
            int[,] N = new int[a, b];

            Random rnd = new Random();

            Console.WriteLine("---------- M MATRİSİ ----------");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    M[i, j] = rnd.Next(10, 100);
                    Console.Write(M[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("---------- N MATRİSİ ----------");
            for (int i = 0; i < a; ++i)
            {
                for(int j = 0;j < b; j++)
                {
                    N[i, j] = rnd.Next(10, 100);
                    Console.Write(N[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("İŞLEM SONUCU OLUŞACAK MATRİSİMİZ");
            if (M.GetLength(0) == N.GetLength(0) && M.GetLength(1) == N.GetLength(1))
            {
                int[,] P = new int[a, b];

                for (int i = 0; i < a; ++i)
                {
                    for (int j = 0; j < b; ++j)
                    {
                        P[i, j] = M[i, j] + N[i, j]; //toplama işlemi
                        Console.Write(P[i,j] + "      ");
                        //P[i, j] = M[i, j] - N[i, j]; //çıkarma işlemi
                        //P[i, j] = M[i, j] * 3; //skaler çarpım
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("BOYUT HATASI!!");
            }
            Console.ReadKey();
        }
    }
}