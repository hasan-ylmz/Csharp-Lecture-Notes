using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Adet sayısı ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a; i++) 
            {
                for (int j = 0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            for (int i = a-1 ;i >= 1; i--)
            {
                for(int j = 1;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
