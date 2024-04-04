using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FınalProject_OOP_1
{
    internal class Program
    {
        public static string  OGRmenu()
        {
            Console.WriteLine("1 - Öğrenci Bİlgilerini Göster");
            Console.WriteLine("2 - Öğrenci Ortalamasını Göster");
            Console.WriteLine("3 - Öğrenci Okul İsmini Göster");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Seçiminiz : ");
            string s = Console.ReadLine();
            return s;
        }

        static int Main(string[] args)
        {
            Ogrencı ogrencı = new Ogrencı(444, "Hasan" ,"Yılmaz",90,100,"KTU");

            string  s1;
            while((s1 = OGRmenu()) !=  "4")  {       
                switch (s1)
                {
                    case "1":
                        ogrencı.ogrencıBılgılerıGoster();
                    break;
                    case "2":
                        ogrencı.OrtalamasıBul();
                    break;
                    case "3":
                        ogrencı.okulGetır();
                    break;
                    case "4":
                        Console.WriteLine("Çıkış yapıldı");
                     break;   

                }
            }

            return 0;
        }
    }
}
