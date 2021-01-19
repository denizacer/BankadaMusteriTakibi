using System;
using System.Collections.Generic;
using System.Text;

namespace BankadaMusteriTakibi
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad+" "+musteri.SoyAd+" Bankamıza hoş geldiniz. Başarıyla eklendiniz");
        }

        public void Musterilistele(params Musteri[] musteri) 
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Müsteri listesi");
            foreach (var mus in musteri)
            {

                Console.WriteLine(mus.Ad);
                Console.WriteLine(mus.SoyAd);
                Console.WriteLine(mus.TcId);
                Console.WriteLine("------------------------");

            }
        }
        public void MusteriSilme(Musteri musteri) 
        {
            Console.WriteLine(musteri.Ad + " " + musteri.SoyAd + "  Müşteri başarıyla silindi");
        }
    }
}
