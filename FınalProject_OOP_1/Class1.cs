using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FınalProject_OOP_1
{
    internal class Ogrencı
    {
        private int ogrencıNo;
        private string ısım;
        private string soyısım;
        private int vize1;
        //private int vize2;
        private int final;
        private string Okulİsmi;

        /*
        public int _ogrNo {
            get { return ogrencıNo; }
            set { ogrencıNo = value; }
        }

        public string _ısım
        {
            get { return ısım; }
            set { ısım = value; }
        }

        public string _soyısım
        {
            get { return soyısım; }
            set { soyısım = value; }
        }

        public int _vize1
        {
            get { return vize1; }
            set { vize1 = value; }
        }


        public int _final
        {
            get { return final; }
            set { final = value; }
        }

        public string _okul
        {
            get { return Okulİsmi; }
            set
            {
                Okulİsmi = value;
            }
        }
        */


        public Ogrencı(int NO , string ISIM , string SOYAD , int VIZE1 , int FINAL , string OKULISMI)
        {
            ogrencıNo= NO;
            ısım= ISIM;
            soyısım= SOYAD;
            vize1 = VIZE1;
            final = FINAL;
            Okulİsmi = OKULISMI;
        }

        public void ogrencıBılgılerıGoster()
        {
            Console.WriteLine("Öğrenci Bilgileri Ekranına hoşgeldiniz ");
            Console.WriteLine("Öğrenci adı " + ısım + " soyadı :"+soyısım + "  No :"+ogrencıNo +" Vize 1 : "+ vize1 + " Final "+final + " Okul ismi " + Okulİsmi);
        }

        public double OrtalamasıBul()
        {
            double ortalama = (vize1 + final) / 2;
            Console.WriteLine(ortalama);
            return ortalama;
            
        }
        
        public void okulGetır()
        {
            Console.WriteLine("Okul ısmı : " + Okulİsmi);
        }

        public void MENU()
        {
            Console.WriteLine ("1 - Öğrenci Bİlgilerini Göster" );
            Console.WriteLine("2 - Öğrenci Ortalamasını Göster");
            Console.WriteLine("3 - Öğrenci Okul İsmini Göster");
            Console.WriteLine("4 - Çıkış");
        }
    }
}
