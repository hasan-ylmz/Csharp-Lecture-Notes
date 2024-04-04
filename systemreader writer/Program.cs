using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace systemreader_writer
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //try
            //{
            //	System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\ACE49\\OneDrive\\Masaüstü\\ybs.txt");
            //	Console.Write("Satır sayısı");
            //	int ss = Convert.ToInt32(Console.ReadLine());
            //	System.IO.StreamReader rw = new System.IO.StreamReader("C:\\Users\\ACE49\\OneDrive\\Masaüstü\\ybs2.txt");

            //	while (!rw.EndOfStream) 
            //	{

            //		string okunan =rw.ReadLine();
            //		if (ss>0)
            //		{
            //			sw.WriteLine(okunan);
            //			ss--;
            //		}
            //	}
            //	rw.Close();
            //	sw.Close();

            //}
            //catch (Exception ex  )
            //{

            //	Console.WriteLine(ex.ToString());
            //}
            //     }




            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\....\\ybs.txt");
                Console.Write("Satır sayısı");
                int ss = Convert.ToInt32(Console.ReadLine());
                System.IO.StreamReader rw = new System.IO.StreamReader("C:\\.....\\ybs2.txt");

                while (!rw.EndOfStream)
                {

                    string okunan = rw.ReadLine();
                    if (ss > 0)
                    {
                        sw.WriteLine(okunan);
                        ss--;
                    }
                }
                rw.Close();
                sw.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }



	}
}
