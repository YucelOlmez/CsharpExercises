using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlama Temel Kursu";
            string kurs3 = "Java Kursu";

            // Array-Dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", 
                "Programlama Temel Kursu", 
                "Java Kursu",
                "Python",
                "C++"};

            for (int i = 0; i<kurslar.Length; i++)    // for bir döngüdür burada array yani dizi içine aldığım kurs ürünlerini bana ürün sayısı (Length) kadar döndürüp ekrana yazdırıyor. for döngüsünün kapsam alanı sadece dizilerle sınırlı değildir.
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("-----------For Döngüsü bitti-----------");

            foreach (string kurs in kurslar)   //foreach dizi temelli yapıları (array) tek tek dönmeye yaramaktadır. Dizilere Array uygulanır. Diziler için spesifik kullanımdır.
            {
                Console.WriteLine(kurs);
            }
            //---kurs--- isimli değişken dizilerdeki elemanları dolaşması için kullandığımız takma isimdir.

            Console.WriteLine("sayfa sonu - footer");

            //Programlama dillerinin çoğu sayı saymaya 0 dahil olmak üzere saymaya başlar.
        }
    }
}
