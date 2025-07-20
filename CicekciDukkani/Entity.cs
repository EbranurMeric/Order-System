using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekciDukkani
{
    public class Musteri
    {
        public Guid MusteriID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public override string ToString()
        {
            return $"{Isim}{Soyisim}";
        }
    }
    public class Urun
    {
        public Guid UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string Tur { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public override string ToString()
        {
            return $"{UrunAdi}";
        }
    }
    public class Siparis
    {
        public Guid SiparisID { get; set; }
        public Musteri MusteriID { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string TeslimatAdresi { get; set; }
        public string Durum {  get; set; }

    }
    public class SiparisDetayi
    {
        public Guid DetayID { get; set; }
        public Siparis SiparisID { get; set; }
        public Urun UrunID { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal ToplamFiyat { get; set; }
    }
    public class Odemeler
    {
        public Guid OdemeID { get; set; }
        public Siparis SiparisID { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public decimal OdemeTutari { get; set; }
        public string Odemeturu { get; set; }
        public string Durum {  get; set; }

    }
}