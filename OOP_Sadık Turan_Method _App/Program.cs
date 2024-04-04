using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sadık_Turan_Method__App
{
    internal class Program
    {

        class Car
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }

            public bool Automatıc { get; set; }
        

            public void Start()
            {
                Console.WriteLine("Car is Started");
            }

            public void Stop() 
            { 
                Console.WriteLine("Car is stopped"); 
            }
            
            public void Accelerate () 
            { 
                Console.WriteLine("Car is accelerated");
            }

            public void Slowed()
            {
                Console.WriteLine("Car is slowed ");
            }

            public void Menu()
            {
                string komut = "";

                do
                {
                    Console.WriteLine("Araba Komut Menüsüne hoşgeldiniz .Lütfen seçiminizi yapınız . 1-Start ,  2-Stop , 3-Accelerate , 4-Slowed  ,  E-Exit");
                    Console.Write("Seçiminiz : ")
                    komut= Console.ReadLine();

                    switch (komut)
                    {
                        case 1:
                            this.Start(); break
                        case 2:
                            this.Stop(); break;
                        case 3:
                            this.Accelerate(); break;
                        case 4:
                            this.Slowed(); break;
                        default:
                            Console.WriteLine("Menüden Çıkış yapıldı .");
                    }

                } while (komut !="E");
            }
        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Çalışma Dizini: " + Environment.CurrentDirectory);
            Car maserati = new Car()
            {
                Name = "Maserati ",
                Model = "Maserati GranTurismo Gt-789",
                Color = "Pearl White",
                Automatıc = false
            };


            maserati.Menu();

        }
    }
}
