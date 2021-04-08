using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        // Bir class'ın sonunda bu gibi ifadeler görürsek bunlar bir operasyon tutuyor demektir. (Manager, servise, dateaccess)
        // Bir ürünü sepete ekleme bir operasyondur.

        //Bir class'ın içinde birden fazla metot yazabiliriz ve kullanabiliriz. Bu yapacağımız operasyona bğlıdır.

        //Eklemek istediğimiz ürünü metoda verme işlemimize parametre demiyoruz.

        //naming Convention
        public void Ekle(Urun xxxurun) //Buradaki Ekle bloğu çağırılınca içerisindeki kodlar çağırılmış olur. metodumuz bir parametre alıyor ve ilgili parametreye Urun classını ekleyip takma isimle isimlendiriyoruz.
            //Parametreler değişkenler olanlardır.
        {
            Console.WriteLine("Sepete Eklendi Tebrikler ! : "+xxxurun.Adi + " "+xxxurun.Fiyati+"TL ");     //eğer yöneticiler buradaki sepete eklendi isminde değişiklik isterlerse projede bu metodu kullandığım tüm alanlarda güncelleme yapılacak ve bu çok daha mantıklı ve doğru yazılımcı işidir.
        }

        

             
    }
}
