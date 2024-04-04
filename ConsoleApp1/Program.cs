using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();

            customerManager.Add(1,"Ahmet", " Mehmetoğlu");
            customerManager.Update(1,"Ahmet" ," Mehmetoğlu");
            customerManager.Remove(1,"Ahmet"," Mehmetoğlu");


            Console.WriteLine("*******************************");

            Console.WriteLine("Kullanıcı bilgileri düzenlendi");

            Console.WriteLine("----------------------------------");

            IPersonManager personalManager= new PersonalManager();
            personalManager.Add(2, "Mahmut", " Orhan ");
            personalManager.Update(2, "Mahmut", " Orhan ");
            personalManager.Remove(2, "Mahmut", " Orhan ");

            Console.WriteLine("**********************");
            Console.WriteLine("Personel bilgileri düzenlendi");

            Console.WriteLine("-----------------------------------");
            
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(personalManager();
        
        }
    }

    interface IPersonManager
    {   
        void Add(/*int ID , string name ,string lastName*/);
        void Update(int ID, string name ,string lastName);
        void Remove(int ID, string name, string lastName);

    }

    class CustomerManager : IPersonManager
    {
        /// <summary>
        /// Kullanıcının adı ve soyadı alınacak .
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>

        // Customer ADD
        public void Add(int ID, string name, string lastName)
        {
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı müşteri  bilgisi  eklendi");
        }
            ss

        // Customer Update
        public void Update(int ID, string name, string lastName)
        {
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı müşteri  bilgisi  güncellendi ");
        }

        // Customer REMOVE
        public void Remove(int ID, string name, string lastName)
        {
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı müşteri bilgisi   silindi");
        }

    }

    class PersonalManager:IPersonManager
    {
        /// <summary>
        /// Personelin adı ve soyadı alınacak 
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        // Personal  ADD
        public void Add(int ID, string name, string lastName)
        {
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı personel bilgisi eklendi  ");
        }

        // Personal UPDATE
        public void Update(int ID, string name, string lastName)
        { 
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı personel  bilgisi  güncellendi");
        }

        // Personal REMOVE
        public void Remove(int ID, string name, string lastName)
        { 
            Console.WriteLine($"{ID} numaralı {name} {lastName} adlı personel  bilgisi silindi");
        }
    }


    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

    }


}
