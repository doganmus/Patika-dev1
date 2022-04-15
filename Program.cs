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
            
            int[] ciftSayi = new int[n];
            for (int i = 0 ; i < n; i++)
            {
               Console.Write("Pozitif sayı adedince sayı girişi yapınız: ");
               int nSayi= int.Parse(Console.ReadLine());
               if (nSayi%2==0)
                Console.WriteLine(nSayi);
               
            }

            //Ödev1 2.Soru
            
            
        }
    }
}
