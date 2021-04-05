using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Yücel";
            int yas = 27;

            Kurs kurs1 = new Kurs();  //değişken türümüzün ismi Kurs ve bu tür kendine atanacak değerleri alabiliyor. Atanabilen value KursAdi-Egitmen-izlenmeOrani isimli değişken değerleri alacaktır. 
            // Burada kurs1 isimli değişkene Kurs isimli altta görünen property yani özelliklere sahip yeni bir obje gibi bakabiliyoruz. Kısaca yeni bir kurs ürünü üretilip ilgili ürünün kendine has özelliklere sahip oldğu anlaşılabilir.
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Gençay";
            kurs1.izlenmeOranı = 96;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ahmet";
            kurs2.izlenmeOranı = 66;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Levent";
            kurs3.izlenmeOranı = 55;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOranı { get; set; }
    }
}
