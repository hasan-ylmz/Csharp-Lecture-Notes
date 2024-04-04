using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        private string ad;
        private string soyad;
        private int yas;

        public string ADI
        {
            get { return ad; }
            set
            {
                if (value == "emre")
                {
                    ad = "ziya";
                }
                else { ad = value; }

            }
        }


            public string SOYADIII
        {
            get { return soyad; }
            set
            {
                if (value
                   == "bahceci")
                {

                    soyad = "Ayaz";
                }
                else { soyad = value; }

            }


        }

        public int YASLAR
        {
            get { return yas; }
            set
            {
                if (value < 18) { yas = 18; }
                else { yas = value; }
            }
        }
    }
}
