using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp_uygulama
{
    class Program
    {
        public  int cıkarma(int a ,int b )
        { return a - b; }

        public static int Kup(int a)
        {
            int Kupdeger = a*a*a;
            return Kupdeger;
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //Console.WriteLine("1. sayı");
            //int x = Convert.ToInt32( Console.ReadLine() );
            //Console.WriteLine("2. sayı");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(program.cıkarma(x, y));


            //Console.WriteLine("KUPU GİR KAVATT");
            //int Z= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Kup(Z));


            Arac araclar = new Arac();



            araclar.renk = "MAVİ";
            araclar.model = "2020";
            araclar._fiyat = 2000;







            Console.ReadLine();
        }
    }
}
