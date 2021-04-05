using System;

namespace _210403
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not repeat yourself

            // type safety-Tür Tip Güvenliği

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            Console.WriteLine(kategoriEtiketi);
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.50;
            double dolarBugun = 7.50;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap butonu");
            }


        }
    }
}
