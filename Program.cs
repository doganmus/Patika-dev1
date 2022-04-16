using System;

namespace PatikaOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev1 1.Soru
            Console.Write("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int[] diziSayi = new int[n];
            for (int i = 0 ; i < n; i++)
            {
               Console.Write("Pozitif sayı adedince sayı girişi yapınız: ");
               diziSayi[i]= int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
              if(diziSayi[i]%2==0)
               {  
                  Console.WriteLine("Girilen çift sayı:" +diziSayi[i]);
               }
            }
            //Ödev1 2.Soru
            
            
        }
    }
}
