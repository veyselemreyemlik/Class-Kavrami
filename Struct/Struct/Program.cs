using System;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dikdörtgen dikdörtgen = new Dikdörtgen();
          dikdörtgen.kisaKenar = 3;
          dikdörtgen.uzunKenar = 5;

          Console.WriteLine("Class Alan Hesabı :" + dikdörtgen.AlanHesapla());

          Dikdörtgen_Struct dikdörtgen_Struct = new Dikdörtgen_Struct();
          dikdörtgen_Struct.kisaKenar = 5;
          dikdörtgen_Struct.uzunKenar = 6;
          Console.WriteLine("Class Alan Hesabı :" + dikdörtgen_Struct.AlanHesapla());


        }
    }

    class Dikdörtgen
    {
        public int kisaKenar;

        public int uzunKenar;

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdörtgen_Struct
    {
        public int kisaKenar;

        public int uzunKenar;

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }
}
