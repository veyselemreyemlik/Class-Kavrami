using System;

namespace Encapsualiton_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Adi = "Ahmet ";
            ogrenci.Soyadi = "Demir";
            ogrenci.Ogrno = 305;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Adi = "Mehmet ";
            ogrenci1.Soyadi = "Demir";
            ogrenci1.Ogrno = 310;
            ogrenci1.Sinif = 1;
            ogrenci1.SinifDüsür();
            ogrenci1.SinifDüsür();
            ogrenci1.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string adi;
        private string soyadi;
        private int ogrno;
        private int sinif;

      /*  public string Adi { get => adi; set => adi = value; }
        public string Soyadi { get => soyadi; set => soyadi = value; }
        public int OgrNo { get => ogrno; set => ogrno = value; }
        public int  Sinif{ get => sinif; set => sinif = value; } */

        public string Adi
        {
            get { return adi; }
            set { adi = value; }
        }

        public string Soyadi
        { 
            get { return soyadi; }  
            set { soyadi = value; }
        }

        public int Ogrno
        {
            get { return ogrno; }
            set { ogrno = value; }
        }

        public int Sinif
        {
            get => sinif;
            set
            {   
                if(value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir.");
                    sinif = 1;
                }
                else
                sinif = value; 
            }
        }

        public Ogrenci(string adi , string soyadi , int ogrno , int sinif)
        {
           Adi = adi;
           Soyadi = soyadi;
           Ogrno = ogrno;
           Sinif = sinif;   
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***************Öğrenci Bilgileri***************");
            Console.WriteLine("Öğrenci Adı  :" +" "+this.Adi);
            Console.WriteLine("Öğrenci Soyadı  : " +" "+ this.Soyadi);
            Console.WriteLine("Öğrenci Numarası  :" +" "+ this.Ogrno);
            Console.WriteLine("Öğrencinin Sınıfı  :" +" "+ this.Sinif);

        }

        public void SinifAtlat()
        {
            this.sinif = this.Sinif + 1;
        }

        public void SinifDüsür()
        {
            this.sinif = this.Sinif - 1;
        }
    }
}
