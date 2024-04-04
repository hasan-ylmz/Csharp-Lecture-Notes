using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_YZG
{
    internal class Product
    {
        public  int ID { get; set; }
        public  int CategoryID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public  double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

    }
}
