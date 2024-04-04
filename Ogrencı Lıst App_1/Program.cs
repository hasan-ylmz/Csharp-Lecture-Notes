using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ogrencı_Lıst_App_1
{
    internal class Program
    {

        struct Ogrencı
        {
            public string ad { get; set; }

            public string soyad { get; set; }

            public Int64 tc { get; set; }

            public double agno  { get; set; }
        }


        static void Main(string[] args)
        {

            Ogrencı[] ogrencıler;
            Console.Write("adet girin");
            int os = int.Parse(Console.ReadLine());
            Console.WriteLine($"");

            ogrencıler = new Ogrencı[os];   


            // 
            for( int i = 0; i<ogrencıler.Length; i++)
            {
                Console.Write("Ad girin");
                ogrencıler[i].ad = Console.ReadLine();

                Console.Write("Soyad girin  ");
                ogrencıler[i].soyad = Console.ReadLine();   

                Console.Write(" Tc giriniz"   );
                ogrencıler[i].tc = int.Parse(Console.ReadLine());    

                Console.Write(" Agno giriniz " );
                ogrencıler[i].agno = double.Parse(Console.ReadLine());
            };

            foreach (var item in ogrencıler)
            {
                Console.WriteLine($"{item.ad} {item.soyad} adlı {item.tc} TC kimlik numaralı öğrencinin agnosu {item.agno} ");

            }

        }
    }
}
