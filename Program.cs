using System;

namespace PatikaOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ödev1 1.Soru
            /*Console.Write("Pozitif bir sayı giriniz: ");
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
            Console.WriteLine("Pozitif iki sayı giriniz :");
            int n=int.Parse(Console.ReadLine()); 
            int m=int.Parse(Console.ReadLine());
            int[] dizi =new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write(n +" pozitif tam sayıdan "+(i+1)+".sayı giriniz:");
                dizi[i]=int.Parse(Console.ReadLine());  
            }

            foreach (int sayi in dizi)
            {
                if((sayi==m) ||(sayi%m==0))
                    Console.WriteLine(sayi);
            }*/
            //Ödev1 3.Soru
            
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            Console.WriteLine(n+" adet kelime giriniz: ");
            for (int i = 0; i < n; i++)
            {
              words[i] = Console.ReadLine();  
            }

            Console.WriteLine("*********************");
            Array.Reverse(words);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            
            
            
            
        }
    }
}
