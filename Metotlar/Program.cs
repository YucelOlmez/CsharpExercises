using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar tekrar kullanılabilirliği sağlayan bir ortam sağlar.
            // Do not repeat yourself !
            // Clean Code
            // Best Practice 

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Afyon Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Yaban Mersini";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Ormandan Toplanmış";

            Urun[] urunler = new Urun[] {urun1,urun2 };   //dizileştirme işlemini değişkene tanımlayıp yaptım.

            //type- safe -- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " :"+urun.Fiyati+" TL "+urun.Aciklama);
            }

            Console.WriteLine("--------------Metotlar---------------");


            //encapsulation ürünüme yeni bir özellik eklemek istediğimde nesneleştirdiğim alana yeni bir property ekleme işlemidir.
            SepetManager sepetManager = new SepetManager();    //burada classı sanki bir değişkenmiş gibi oluşturuyoruz. yani tanımlıyoruz. bu işleme Instance denir.
            sepetManager.Ekle(urun1);                                //Burada SepetManager class'ının içerisinde tanımladığımız Ekle metodonu member access operatörü ile çağırıp ekliyoruz.
            sepetManager.Ekle(urun2);

            
            




        }
    }
}
