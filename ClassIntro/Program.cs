using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 17;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Furkan";
            kurs1.IzlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Css";
            kurs2.Egitmen = "İsmail";
            kurs2.IzlenmeOrani = "40";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Html";
            kurs3.Egitmen = "Ömner";
            kurs3.IzlenmeOrani = "30";

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen );

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public string IzlenmeOrani { get; set; }

    }
}
