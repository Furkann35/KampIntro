using System;

namespace QuizDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Kıyafet terzi1 = new Kıyafet();
            terzi1.beden = "80 beden";
            terzi1.sayi = "10 adet";
            terzi1.renk = "Kırmızı";

            Kıyafet terzi2 = new Kıyafet();
            terzi2.beden = "70 beden";
            terzi2.sayi = "5 adet";
            terzi2.renk = "Yeşil";

            Kıyafet[] lcwaikiki = new Kıyafet[] { terzi1, terzi2 };

            for (int i = 0; i < lcwaikiki.Length; i++)
            {
                Console.WriteLine(lcwaikiki[i].beden);
                Console.WriteLine(lcwaikiki[i].sayi);
                Console.WriteLine(lcwaikiki[i].renk);

            }

        }

    }


        class Kıyafet
        { 
        public string beden { get; set; }
        public string sayi { get; set; }
        public string renk { get; set; }



    }
}
