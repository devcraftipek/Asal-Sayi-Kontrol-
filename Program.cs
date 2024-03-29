using System;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Uygulama: Asal Sayı
           // Girilen bir sayının asal olup olmadığını kontrol ediniz.
           // Bir sayı, sadece 1'e ve kendisine tam bölünebiliyorsa asal sayıdır.

            bool asalmi = true;

            Console.Write("sayı: ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi==1)
                asalmi = false;

            for (int i = 2; i < sayi; i++)           
            {
                if(sayi%i==0)
                {
                    asalmi = false;
                    break;
                }
            }

            if (asalmi)
                Console.WriteLine("sayı asaldır.");
            else
                Console.WriteLine("sayı asal değildir");

        }
    }
}
