using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri Eklendi : " + musteri.AdiSoyadi + " - " + musteri.MusteriNumarasi);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri bilgileri silindi : " + musteri.AdiSoyadi + " - " + musteri.MusteriNumarasi);
        }
        public void MusteriBilgileriGuncelle(Musteri musteri)
        {
            Console.WriteLine("Musteri bilgileri guncellendi : " + musteri.AdiSoyadi + " - " + musteri.MusteriNumarasi);
        }
        public void MusteriListele(Musteri[] musteri)
        {
            Console.WriteLine("----------------Musteriler : --------------");
            foreach (Musteri mus in musteri)
            {
                Console.WriteLine("Musteri adi : " + mus.AdiSoyadi + " - " + "Musteri numarasi : " + mus.MusteriNumarasi);
            }
        }
    }
}
