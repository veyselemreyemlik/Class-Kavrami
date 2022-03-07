using System;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)(Gunler.Cumartesi));

            int sıcaklık = 25;

            if(sıcaklık <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekleyelim.");
            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya Çıkmak İçin Çok Sıcak Bir Gün");
            else if(sıcaklık >= (int)HavaDurumu.Normal && sıcaklık< (int)HavaDurumu.ÇokSıcak)
            {
                Console.WriteLine("Hadi Dışarıya Çıkalım.");
            }
        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
        
    }

    enum HavaDurumu
    {
        Soguk = 5 ,
        Normal = 20,
        Sıcak = 25 ,
        ÇokSıcak = 30 
    }
}
