using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.musteriID = 1;
            M1.tcKimlikNumarasi = "12254401285";
            M1.isim = "Faik";
            M1.soyisim = "Turan";
            M1.olusturmaTarih = DateTime.Now;

            //M1.musteriAdresleri = new MusteriAdres[5]; // Asla yapılmamalı!!!

            M1.musteriAdresleri[0] = new MusteriAdres()
            {
                Il = "İstanbul",
                Ilce = "Kadıköy",
                Adres = "Adres",
                adresTip = "İşyeri"
            };

            M1.musteriAdresleri[0].MusteriAdresTestMetot();
            M1.musteriSiparisBilgileri[0] = new MusteriSiparisBilgisi()
            {
                siparisNumarasi = "SIP0001"
            };

            M1.musteriSiparisBilgileri[0].urunler[0] = new Urun()
            {
                urunId = 1,
                Tanim = "Telefon",
                fiyat = 1500
            };

            foreach (var item in )
            {

            }
        }
    }
}
