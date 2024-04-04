using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ogrencı_Menu_App
{
    internal class Program
    {
        
        public class Ogrencı
        {
            private int ogrno { get; set; }
            private string name { get; set; }

            private string lastname { get; set; }

            private string okul { get; set; }

            private Int16 vıze { get; set; }

            private Int16 fınal { get; set; }

            public Ogrencı(int ogrno, string name, string lastname, string okul, short vıze, short fınal)
            {
                this.ogrno = ogrno;
                this.name = name;
                this.lastname = lastname;
                this.okul = okul;
                this.vıze = vıze;
                this.fınal = fınal;

                
            }
        
            public void ogrencıbılgılerınıgoster()
            {
                Console.WriteLine($"{ogrno} Ogrencının ısmı {name} , {lastname}");
            }

            public void  ogrnotubul() {
                double ortalama = (vıze + fınal) / 2;
                Console.WriteLine(ortalama);
            }
            
            public void okulgetır()
            {
                Console.WriteLine($"Ogrencının {okul} u ");
            }

        static void Main(string[] args)
        {
                Ogrencı o1 = new Ogrencı(1,"Enes","Oğuz","KTU",87,95);
                Console.WriteLine("Enes Oğuzun yazdığı programa hoşgeldiniz Abilerimm");

                //while (true)
                //{
                //    Menu();
                //    string secım = Console.ReadLine());
                //    switch (secım)
                //    {
                //        case 1:
                //            o1.ogrencıbılgılerınıgoster();
                //            break;

                //        case 2:
                //            o1.ogrnotubul();
                //            break;
                //        case 3:
                //            o1.okulgetır();
                //            break;


                //        default:
                //            Console.WriteLine("Herhang bir seçim yapmadınız ");
                //            break;
                //    }
                //}    



                //void Menu()
                //{
                //    Console.WriteLine("1 Öğrencı Bilgilerini Goster",1);
                //    Console.WriteLine("2 Ortalama",2);
                //    Console.WriteLine("3 Okul ismi",3);
                //    Console.WriteLine("4 Çıkış ");
                //}
                while (true)
                {
                    Menu();

                    // Kullanıcının seçimini al
                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            o1.ogrencıbılgılerınıgoster();
                            break;

                        case "2":
                             o1.ogrnotubul();
                            break;

                        case "3":
                            o1.okulgetır();
                            break;

                        case "4":
                            Console.WriteLine("Programdan çıkılıyor.");
                            return;

                        default:
                            Console.WriteLine("Geçersiz seçim.");
                            break;
                    }
                }
            }

            static void Menu()
            {
                Console.WriteLine("1. Öğrencı Bilgilerini Goster");
                Console.WriteLine("2. Ortalama");
                Console.WriteLine("3. Okul ismi");
                Console.WriteLine("4. Çıkış ");
                Console.Write("Seçiminiz: ");
            }



        }
    }
}

