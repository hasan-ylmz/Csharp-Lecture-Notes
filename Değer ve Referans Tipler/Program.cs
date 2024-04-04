using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Değer_ve_Referans_Tipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 10;
            int sayı2 = 20;
            sayı1 = sayı2;
            sayı2 = 30;
            // sayı1 ?? 

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 99;
            // sayılar1[0] ?? 

            /*
            Primitive Types = float, double , bool ,int ,byte, short ,long ,decimal  
            Referance Types = arrays ,class , interface 

            Primitive Types 
            ________________________

            STACK                               HEAP 
            sayı1 =10                     
            sayı2 =20
            sayı1 =sayı2 

            sayı1 =20 
            sayı1 sadece sayı2'nin değerini alır .




            Reference Types 
            ________________________

            STACK                               HEAP 
            101|sayılar1                     101|{10,20,30}
            102|sayılar2                     102|{100,200,300}   

            sayılar1 = sayılar2 ;
            sayılar2[0] = 99


            // Bu kodu yazdığınızda sayılar1 referansı sayılar2 referansına eşitleniyor .
            sayılar1'in  101 adres değeri artık 102 oluyor .
            Adres değiştikten sonraki stack ve heap hafıza durumu şu şekilde oluyor .


            STACK                               HEAP 
            102|sayılar1                     101|{10,20,30}
            102|sayılar2                     102|{100,200,300}   

            101 -> garbage collector bu adresi kullanılmadığı için bellekten siliyor .

            */


        }
    }
}
