using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_13._11
{
    /*
     *  
     *  4. hafta 
     *  ------------------
     *  
     *  WriteLİne ReadLine  
     *  Dosyaya yazma okuma 
     *  Bir dosyaya seçtiğimiz hedef dosyadan alınan değer kadar başka dosyaya satır veya metin yazdırma 
     *  
     *  
     *  
     *  5.hafta 
     *  -----------------
     *  
     *  Struct enum yapısı 
     *  Öğrenci Harf notu uygulaması 
     *  İşyerinde  kişiye göre maaş uygulaması  
     *  switch case 
     *  static
     *  
     *  
     *  6.Hafta 
     *  ----------------
     *  
     *  Interface 
     *  Bankaya para yatırma çekme hesap açma kapama para görüntüleme hesap kapama uygulaması yaptık .
     *  
     *  
     *  
     *  7.Hafta 
     *  ----------------
     *  
     *  Inheritance - Car 
     *  Base sınıf constructor 
     *  
     *  Arac constructor > Suv Constructor > Togg Constructor 
     *  İlk önce araç metodları çalıştırılıyor .Sonra Suv constructorı çalıştırılıyor .Daha sonra da togg constructor
     *  
     *  Arac classında 2 tane fiyat ve modelyılı ile alakalı 2 property var . Fıyatazam ve  bilgi adına 2 metod var. 
     *  Suv sınıfı oluşturup public propertyi taşıyıp renk propertsi  ve dört çeker adında bir metodu var daha sonra bir togg 
     *  bir class oluşturup suvdan miras alıyoruz . Togg classının da menzil adında bir metodu var . 
     *  3 tane nesne oluşturuldu . a1 ,s1, t1 buna göre değer atamaları ve durumlar oluşturuluyor .
     *  
     *  -Constructor 
     *  -Parametreli Constructor 
     *  
     *  
     *  ornek 
     *  Personel bilgilerinin tutulduğu personel ekleme i listeleme yapıldığı bir console uygulaması 
     *  Personel için Kıdem ve Maaş bilgisi tutulacaktır .Personel sınıfının "Bilgi" metodu personelin Kıdem ve Maaş tutarını 
     *  ekrana yazdıracktır .
     *  
     *  * İşçi sınıfı personel sınıfından üretilecek ve FazlaMesai ödemesi alınacaktır. İşçilerin fazla mesai tutarları
     *  maaşlarına eklenecektir 
     *  *Mudur sınıfı personel sınıfndan uretilecek ve MakamTazminat ödemesi alınacaktır .Müdürlerin  MakamTazminat tutarları 
     *  maaşlarına eklenecektir .
     * 
     *  Sınıfları propertyleri private olarak tanımlanacaktır .
     *  
     *  ________________________________________________________________
     *  Çalışanların bilgileri ilgili sınıfın yapıcısında alınacaktır .
     *  İlgili sınıf değeri atanırsa constructorda değer ataması yapılacak .
     *  Her bir sınıfın property setlemesi constructorda yapılacak anlamına gelir .Bunu başka bir metodda alınmayacak .
     *  Bunun sebebi dışarıda yaparsak Constructordan sonra 2.kez metod çağırılacaktır. Bunu istemiyoruz .
     * 
     *  ArrayList();
     *  Farklı türden nesneleri bir arada tutabiliriz. 
     *  Heap ve stack hafıza kavramları; FIFO - LIFO 
     *  
     *  count ve length farklılıkları count ve length neden kullanıyoruz ? 
     *  
     *  Override Iscı bilgiyaz kullanılsın Personel BilgiYazı kullanılmasın . Override 
     * 
     *  Sınavla alakalı büyük bir ağırlık klasik olacak en az 80  belki 100 puan 
     *  Farklı şekillerde 
     * 
     *  
     * 
    public class Arac
    {

        private decimal Fiyat;
        private Int32 ModelYili;
        
        /*
                public Arac(decimal fiyat, int modelYili)
                {
                    Fiyat = fiyat;
                    ModelYili = modelYili;
                }
        
        public void FiyataZam(decimal oran)
        {
            Fiyat += oran;
        }

        public void Bİlgi()
        {
            Console.WriteLine("Model Yılı {0} , Fiyat {1}, ", ModelYili, Fiyat);
        }
    }


    public class SUV:Arac
    {
           private bool is4×4 ;

    }
*/


    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return $"{Marka} {Model} - Fiyat: {Fiyat:C}";
        }
    }

    class SUV : Araba
    {
        public bool DortCeker { get; set; }

        public override string ToString()
        {
            string dortCekerDurumu = DortCeker ? "4x4" : "2WD";
            return $"{Marka} {Model} - Fiyat: {Fiyat:C} - Çekiş: {dortCekerDurumu}";
        }
    }

    class Program
    {
        static void Main(AsyncVoidMethodBuilder asyncVoid)
        {
            List<Araba> arabaListesi = new List<Araba>
        {
            new SUV { Marka = "Toyota", Model = "RAV4", Fiyat = 150000, DortCeker = true },
            new SUV { Marka = "Honda", Model = "CR-V", Fiyat = 140000, DortCeker = true },
            new Araba { Marka = "Ford", Model = "Focus", Fiyat = 90000 }
        };

            Console.WriteLine("Tüm Araba Fiyatları:");
            foreach (var araba in arabaListesi)
            {
                Console.WriteLine(araba);
            }

            Console.WriteLine("\nSUV Araba Fiyatları:");
            foreach (var araba in arabaListesi)
            {
                if (araba is SUV suvAraba)
                {
                    Console.WriteLine(suvAraba);
                   
                }
            }
        }

    }
}
