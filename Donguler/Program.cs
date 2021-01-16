using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım gelişitirici kampı";
            string kurs2 = "Programlamaya baslangic icin temel kurs";

            string[] kurslar = new string[] { "Yazılım gelişitirici kampı" , "Programlamaya baslangic icin temel kurs" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)//dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
