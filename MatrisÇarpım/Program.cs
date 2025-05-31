using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisÇarpım
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin ilk boyutunu giriniz: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Matrisin ikinci boyutunu giriniz: ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            Console.WriteLine();
            int[,] A = new int[a, b];
            Console.WriteLine("---------- A MATRİSİ ----------");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    A[i, j] = rnd.Next(1,6);
                    Console.Write(A[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Matrisin ilk boyutunu giriniz: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Matrisin ikinci boyutunu giriniz: ");
            int d = int.Parse(Console.ReadLine());
            int[,] B = new int[c, d];

            Console.WriteLine("---------- B MATRİSİ ----------");
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < d; j++)
                {
                    B[i, j] = rnd.Next(1, 6);
                    Console.Write(B[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------- ÇARPIM SONUCU ----------");

            if ((A.GetLength(1)) == (B.GetLength(0)))
            {
                int[,] C = new int[a, d];
                for (int i = 0; i < (A.GetLength(0)); i++)
                {
                    for (int j = 0; j < (B.GetLength(1)); j++)
                    {
                        C[i, j] = 0;
                        for (int k = 0; k < (A.GetLength(1)); k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                        Console.Write(C[i, j] + "  ");

                    }
                    Console.WriteLine();
                }
         
            }
            Console.Read();
        }
    }
}