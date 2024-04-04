using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1_YZG
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Product product = new Product
            { 
                ID = 1,
                CategoryID = 1 ,
                Name= "Product_1",
                Description="Product_1 Description",
                UnitPrice =99,
                UnitsInStock = 20,
            };

            Product product1 = new Product
            {
                ID = 2,
                CategoryID = 1 ,
                Name ="Product_2",
                Description="Product_description",
                UnitPrice=299,
                 UnitsInStock = 10,
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);

            productManager.Add(product1);

        }
    }
}
