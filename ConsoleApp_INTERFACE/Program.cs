using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_INTERFACE
{
    internal class Program
    {
        // interfaceler newlenemez 
        static void Main(string[] args)
        {
            IPersonManager customerManager= new CustomerManager();
            customerManager.Add(1, "Ahmet", "Yılmaz");
        }
    }

    interface IPersonManager
    {
        // Unımpelemented  Operation 
        void Add(int ID , string name, string lastName);
        void Update(int ID, string name, string lastName);

        void Remove(int ID, string name, string lastName);
        
    }

    // inherits -> class  ----------------- implements -> interface 
    class CustomerManager : IPersonManager
    {
        public void Add(string name , string lastName , int ID)
        {
            // Müşteri Ekleme Kodlar 
            Console.WriteLine($"{ID} numarasına sahip  {name} adlı {lastName} soyadlı kullanıcı  bilgisi eklendi . ");
        }

        // CUSTOMER UPDATE 
        public void Update(string name, string lastName, int ID) 
        { 
            Console.WriteLine($"{ID} numarasına sahip  {name} adlı {lastName} soyadlı kullanıcı  bilgisi güncellendi . ");
        } 

        // CUSTOMER REMOVE
        public void Remove(string name, string lastName, int ID) 
        { 
            Console.WriteLine($"{ID} numarasına sahip  {name} adlı {lastName} soyadlı kullanıcı  bilgisi silindi. ");
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }

    /* class PersonalManager : IPersonManager
     {
         // PERSONAL ADD 
         public void Add(string name )
         {       
             Console.WriteLine($"{name} adlı personel eklendi");
         }

         // PERSONAL UPDATE 

         /// <summary>
         ///  Personel update işlemleri yapılacak 
         /// </summary>
         /// <param name="name"></param>
         public void Update(string name) { }     



     }*/
}
