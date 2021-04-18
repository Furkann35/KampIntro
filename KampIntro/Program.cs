using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety - tip güvenliği
            //Do not yourself - Kendini tekrarlama
            //Değer tutucu, alias

            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azaldı butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Arttı butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(KategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
        }
    }
}
