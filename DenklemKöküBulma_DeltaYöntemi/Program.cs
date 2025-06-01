using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenklemKöküBulma_DeltaYöntemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen ax^2 + bx+c = 0 denkleminin köklerini Delta Yöntemi ile bulalım.
            int a = 0, b = 0, c = 0;
            Console.Write("Denklem giriniz: ");
            string ax = Console.ReadLine();

            string[] s = ax.Split('x');
            string[] t = s[1].Split(' ');
            string[] v = s[2].Split(' ');

            a = Convert.ToInt32(s[0]);
            b = Convert.ToInt32(t[2]);
            c = Convert.ToInt32(v[2]);

            Console.WriteLine("Denklem: {0}x^2 + {1}x + {2} = 0", a, b, c);
            Console.WriteLine("a= {0}, b = {1}, c = {2}", a, b, c);

            int delta = b*b - 4 * a * c;

            Console.WriteLine("Delta: {0}", delta);

            if (delta > 0)
            {
                double kok1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double kok2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Denklemin iki farklı kökü vardır.");
                Console.WriteLine("Kök 1: {0}, Kök2: {1}", kok1, kok2);

            }
            else if (delta == 0)
            {
                double kok1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("İki kök birbirine eşit,Kök1={0}", kok1);
            }
            else
            {
                Console.WriteLine("Denklemin reel kökü yoktur.");
            }
            
            Console.ReadLine();
        }
    }
}