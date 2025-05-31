using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisOluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrisin ilk boyutu kaç olsun?: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Matrisin ikinci boyutu kaç olsun?: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] M = new int[a, b];
            int[,] N = new int[a, b];
            Random rnd = new Random();

            Console.WriteLine("----------------- A MATRİSİ -----------------");
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    M[i,j]=rnd.Next(10,100);
                    Console.Write(M[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine() ;

            Console.WriteLine("----------------- B MATRİSİ -----------------");
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    N[i, j] = rnd.Next(10, 100);
                    Console.Write(N[i, j] + "   ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
