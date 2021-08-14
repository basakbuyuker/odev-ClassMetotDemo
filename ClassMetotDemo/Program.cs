using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.AdiSoyadi = "Betül";
            musteri1.KimlikNumarasi = 12345678910;
            musteri1.MusteriNumarasi = 00001;
            musteri1.DogumTarihi = "02-Ekim-1998";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.AdiSoyadi = "Başak";
            musteri2.KimlikNumarasi = 23456789123;
            musteri2.MusteriNumarasi = 00002;
            musteri2.DogumTarihi = "19-Temmuz-1996";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 201;
            musteri3.AdiSoyadi = "Emrecan";
            musteri3.KimlikNumarasi = 34567891230;
            musteri3.MusteriNumarasi = 10001;
            musteri3.DogumTarihi = "08-Kasım-2000";

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3};

            Console.WriteLine("---------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriBilgileriGuncelle(musteri3);
            musteriManager.MusteriListele(musteriler);


        }
    }
}
