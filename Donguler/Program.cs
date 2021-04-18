using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "C++";
            string kurs5 = "C#";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);



            //array - dizi

            string[] kurslar = new string [] { "Yazılım geliştirici kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "C++", "Pyhton" , "C#"};


            // for (int i = 0; i <= 10; i=i+2)
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            //kurs elemanı takma isimdir istediğimizi yazabiliriz - alias
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
    