using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 3;

            Console.WriteLine("kalkulator sederhana");
            Console.WriteLine("1. penambahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");
            Console.WriteLine("");
            Console.Write("masukkan menu yang [1...4]");
            int pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1)
            {
                Console.WriteLine("hasil penjumlahan " + a + " + " + b + " = " + penambahan(a, b));
            }else if(pilihan == 2)
            {
                Console.WriteLine("hasil pengurangan dari {0} - {1} = {2}", a, b, pengurangan(a, b));
            }else if (pilihan == 3)
            {
                Console.WriteLine("hasil perkalian dari {0} * {1} = {2}", a, b, perkalian(a, b));
            }else if (pilihan == 4)
            {
                Console.WriteLine("hasil pembagian dari {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("pilihan tidak tersedia");
            }

            Console.ReadKey();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a + b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a/b;
        }
    }
}
