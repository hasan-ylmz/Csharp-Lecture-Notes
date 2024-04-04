using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sadık_Turan_Methods
{
    internal class Program
    {
        class Person
        {
            public string Name  { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }

            public void Info()
            {
                Console.WriteLine($" AD :  {this.Name} , ID {this.Id} , Title  {this.Title}");
            }
        }

        static void Main(string[] args ){
            //class -> object 

            Person p1 = new Person()
            {
               Name="Mehmet",
               Id=1,
               Title="Business Partner",
               
            };

            Person p2 = new Person()
            {
                Name = "Ziya",
                Id = 2,
                Title = "Backend Developer ",
            };

            Person p3 = new Person()
            {
                Name = "Mine",
                Id = 3,
                Title = "UX Developer",
            };
            p1.Info();
            p2.Info();
            p3.Info();
        }

    }
}

