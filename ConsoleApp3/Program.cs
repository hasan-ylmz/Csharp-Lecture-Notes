using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();


           

            class1.ADI = "emre";
            class1.SOYADIII = "bahceci";
            class1.YASLAR = 15;



            // Bilgileri ekrana yazdıralım
            Console.WriteLine("Ad: " + class1.ADI);
            Console.WriteLine("Soyad: " + class1.SOYADIII);
            Console.WriteLine("Yaş: " +class1.YASLAR);

        
            Console.ReadLine();
        }
    }
}
