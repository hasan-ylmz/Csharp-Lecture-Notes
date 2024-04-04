using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Salary_Calculate_Applıcatıon__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Personel> personelListesi = new List<Personel>
        {
            new Isci { Ad = "Ahmet", Soyad = "Yılmaz", Kidem = 5, FazlaMesai = 10, Maas = 5000 },
            new Mudur { Ad = "Ayşe", Soyad = "Demir", Kidem = 10, MakamTazminat = 3000, Maas = 10000 },
            new Personel { Ad = "Mustafa", Soyad = "Kaya", Kidem = 2, Maas = 3000 }
        };

            Console.WriteLine("Personel Bilgileri:");
            foreach (var personel in personelListesi)
            {
                personel.Bilgi();
                Console.WriteLine();
            }
        }
    }

    class Personel
    {
        private string ad;
        private string soyad;
        private int kidem;
        private decimal maas;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }

        public int Kidem
        {
            get { return kidem; }
            set { kidem = value; }
        }

        public decimal Maas
        {
            get { return maas; }
            set { maas = value; }
        }

        public virtual void Bilgi()
        {
            Console.WriteLine($"{Ad} {Soyad} - Kıdem: {Kidem} yıl - Maaş: {Maas:C}");
        }
    }

    class Isci : Personel
    {
        private decimal fazlaMesai;

        public decimal FazlaMesai
        {
            get { return fazlaMesai; }
            set { fazlaMesai = value; }
        }

        public override void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Fazla Mesai: {FazlaMesai} saat");
        }

        public override decimal Maas
        {
            get { return base.Maas + (FazlaMesai * 20); } // Fazla mesai ücreti saat başına 20 TL olsun.
            set { base.Maas = value; }
        }
    }

    class Mudur : Personel
    {
        private decimal makamTazminat;

        public decimal MakamTazminat
        {
            get { return makamTazminat; }
            set { makamTazminat = value; }
        }

        public override void Bilgi()
        {
            base.Bilgi();
            Console.WriteLine($"Makam Tazminatı: {MakamTazminat:C}");
        }

        public override decimal Maas
        {
            get { return base.Maas + MakamTazminat; }
            set { base.Maas = value; }
        }
    }

}
