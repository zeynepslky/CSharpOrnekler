using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrnekDers
{
    internal class Program
    {
        /*public static void Yaz()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Merhaba Dünya!");
        }

        public static int Topla(int x, int y)
        {
            Console.WriteLine(x+y);
            return x + y;
        }
        public static void Carp()
        {
            int x = 5; 
            int y = 10;
            Console.WriteLine(x * y);
        }

        public static string Birlestir(string x, string y)
        {
            return x + " " + y;
        }
        */

        /*public static void Yaz(string diziad, int[] dizi)
        {
            Console.WriteLine(diziad + " adlı dizinin elemanları: ");
            foreach (int d in dizi)
            {
                Console.WriteLine(d);
            }
        }*/

        /*public static void isim(string diziad, string[] dizi)
        {
            Console.WriteLine(diziad + " adlı dizi:");
            foreach (int i in dizi)
            {
                Console.WriteLine(i);
            }
        }*/



        static void Main(string[] args)
        {
            /* Kullanıcıdan alınan n boyutlu bir sayı dizisinin en büyük ve en küçük elemaını bulma. */

            /* Console.WriteLine("Boyutu giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Dizinin " + i + ". elemanını giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }

            int enkucuk = dizi[0];
            int enbuyuk = dizi[0];

            for ( int j = 1; j < n; j++)
            {
                if (dizi[j] < enkucuk)
                {
                    enkucuk = dizi[j];
                }
                if (dizi[j] > enbuyuk)
                {
                    enbuyuk = dizi[j];
                }
            }

            Console.WriteLine("Dizinin en küçük elemanı: " +  enkucuk);
            Console.WriteLine("Dizinin en buyuk elemanı: " + enbuyuk);

            // Console.WriteLine("Dizinin en küçük elemanı: " + dizi.Min());
            // Console.WriteLine("Dizinin en küçük elemanı: " + dizi.Max());

            */



            /* Kullanıcıdan alınan n boyutlu iki sayı dizisinin elemanlarını toplayıp yeni diziye atama */

            /* Console.WriteLine("Dizilerin boyutunu giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] dizi1 = new int[boyut];
            int[] dizi2 = new int[boyut];
            int[] dizisonuc = new int[boyut];

            for ( int i = 0; i < boyut; i++ )
            {
                Console.WriteLine("Dizi 1'in " + i + ". elemanını giriniz:");
                dizi1[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Dizi 2'in " + i + ". elemanını giriniz:");
                dizi2[i] = Convert.ToInt32(Console.ReadLine());

                dizisonuc[i] = dizi1[i] + dizi2[i];
            }

            foreach ( int ds in dizisonuc )
            {
                Console.WriteLine(ds);
            }
            */


            /* Kullanıcıdan alınan n boyutlu sayı dizisinin elemanlarını tersten yeni biz diziye atama */

            /* Console.WriteLine("Dizilerin boyutunu giriniz:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            int[] dizi = new int[boyut];
            int[] diziters = new int[boyut];

            for (int i = 0; i < boyut; i++)
            {
                Console.WriteLine("Dizinin " + i + ". elemanını giriniz:");
                dizi[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            int a = 0;
            for ( int i = boyut-1; i >= 0; i--)
            {
                diziters[i] = dizi[a];
                a++;
            }

            foreach (int dt in diziters)
            {
                Console.WriteLine(dt);
            } */



            /* şehir plaka dizisi */

            /* string[,] sehirplaka= { { "Düzce","81"},{ "Ordu","52"},{ "Denizli","20"} };

            for ( int i = 0; i < sehirplaka.GetLength(0); i++ )
            {
                for ( int j = 0; j < sehirplaka.GetLength(1); j++ )
                {
                    Console.Write(sehirplaka[i,j] + " " );
                }
                Console.WriteLine();
            }
            
            foreach (string sp in sehirplaka)
            {
                Console.Write(sp);
            }
            */




            /* fonksiyon oluşturmak için başa yazılacak sonra çağırılacak.  */

            //yaz();

            //Topla(5, 10);

            //Carp();

            //Console.WriteLine(Birlestir("Zeynep", "Çelik"));


            /*int[] dizi1 = { 1, 2, 3, 4, 5, 6 };
            int[] dizi2 = { 78, 65, 98, 47, 32, 56 };

            Yaz("Dizi 1 ", dizi1);
            Yaz("Dizi 2 ", dizi2);
            */

            /*
            string[] isimler = { "Ali", "Veli", "Hayri" };
            Yaz("İsimler",isimler);
            */
        }
    }
}
