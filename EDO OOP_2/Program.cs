using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDO_OOP_2
{
    internal class Program
    {

        /*
         Clean code OOP - DEMO 

         Senaryo 

         ## Gereksinimler ##
         Kullanıcı bir ürünü almak istiyor .
         Ürünün fiyatı öğrencielere yüzde 10 indirim ile yansıtılmak isteniyor .
         Default olarak tl ile ödeme yapılacaktır.
         Ürün fiyatını isterse dolar veya euro ile ödeme yapılabilmektedir . 
         Döviz bankası karşılığı merkez bankası servisinden alınacaktır .

         Data: 
         Ürün : Televizyon /1000 tl 
         Normal bir müşteri / TL
         ÇIKTI : 
         Engin Demiroğ ürünü satın aldı . 1000 tl ödeme alındı .

         Data: 
         Ürün: Televizyon /1000 tl 
         Öğrenci TL 
         Çıktı : 
         Tahir Çalışkan ürünü satın aldı . 900 tl ödeme alındı .

         Data: 
         Ürün: Televizyon /1000 tl 
         Öğrenci / Dolar 
         Çıktı :
         Engin Demiroğ ürünü satın aldı . 170 dolar ödeme alındı.
        

        ************* Notlar *************
        Class çıplak kalmaz . Eğer herhangi bir class inherit veya implemente edilmiyorsa ileride bu sıkıntı yaratabilir.
        Güvenlik problemleri bunlardan bir tanesi olabilir . Projeye göre de değişkenlik yapılabilir.
*/
        interface IEntity
        {
            
        }

        
        public class Urun:IEntity
        {
            public double fıyat  { get; set; }
        }

        public class Musterı:IEntity
        {
            public int ID { get; set; }
            public string name { get; set; }

            public string lastName { get; set; }

            public void BılgıYaz(double f)
            {
                Console.WriteLine($"{ID} numarasına sahip {name} {lastName} televizyon aldı  : {f}");
            }

        }


        static void Main(string[] args)
        {
            Musterı musterı = new Musterı();
            musterı.name = "Rana";
            musterı.lastName = "Xyz";
            musterı.ID = 1;
            musterı.BılgıYaz(1000);

        }
    }
}
