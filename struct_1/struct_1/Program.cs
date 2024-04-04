using System;
using System.Linq.Expressions;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Personel Durumunu giriniz ( 1: Yazılımcı , 2:İş analisti , 3:Muhasebe ) ")
        int ısTuru = Convert.ToInt16(Console.ReadLine);

        double maas = 0;

        switch(maas)
        {
            case 1:// Yazılımcı 
                maas = 3000;
                break;
            
            case 2: // Analist
                maas = 2600;
                break;
                
            case 3: // muahsebeci
                maas = 2600;
                break;

            default:
                Console.WriteLine("Geçersiz meslek grubu girdiniz .Lütfen tekrar girin.");
                return;
        }

    }
}