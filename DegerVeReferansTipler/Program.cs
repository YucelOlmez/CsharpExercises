using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Değer türlü değişkenler RAM'ın stack bölümünde tutulurlar.
            //Referans türlü değişkenler RAM'ın heap bölümünde tutulurlar.
            // new kelimesi Heap'te yeni bir yer oluştur demektir.
            //Değer türlü değişkenlerde atama işleminde ''''değer'''' atanır iken
            //Referans türlü değişkenlerde atama işleminde '''''adres'''' ataması yapılıyor.
            //Diziler 1. elemandan saymaya başlamaz 0. elemandan saymaya başlar.


            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

        }
    }
}
