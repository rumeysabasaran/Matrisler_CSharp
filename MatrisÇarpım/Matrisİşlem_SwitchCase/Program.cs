using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrisİşlem_SwitchCase
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
                for (int j = 0; j < b; j++)
                {
                    N[i, j] = rnd.Next(10, 100);
                    Console.Write(N[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Matris Toplama");
            Console.WriteLine("2 - Matris Çıkarma");
            Console.WriteLine("3 - Skaler Çarpım (Sabit sayı ile çarpma)");
            Console.Write("Seçiminiz: ");
            int secim = int.Parse(Console.ReadLine());

            int[,] P = new int[a, b];

            switch (secim)
            {
                case 1:
                    Console.WriteLine("----- TOPLAMA MATRİSİ -----");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            P[i, j] = M[i, j] + N[i, j];
                            Console.Write(P[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    Console.WriteLine("----- ÇIKARMA MATRİSİ -----");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            P[i, j] = M[i, j] - N[i, j];
                            Console.Write(P[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    Console.Write("Skaler çarpım için bir sayı girin: ");
                    int skaler = int.Parse(Console.ReadLine());

                    Console.WriteLine("----- SKALER ÇARPIM MATRİSİ (M * " + skaler + ") -----");
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            P[i, j] = M[i, j] * skaler;
                            Console.Write(P[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
