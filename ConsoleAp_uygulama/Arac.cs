using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAp_uygulama
{
    internal class Arac
    {
        
        public string renk { get; set; }
        public int _fiyat;
        private  int fiyat;
        
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value < 0)
                {
                    _fiyat = 0;
                }
                else
                {
                    _fiyat = value;
                }
            }
        }

        public string model { get; set; }

        public void bilgiyaz(string a ,int b,string c)
        {
            this.fiyat = b;
            this.model = c;
            this.renk = a;
            Console.WriteLine(a,b,c);
        }
    }
    



}
