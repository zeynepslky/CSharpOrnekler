n nusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            /* silindirin hacmini hesaplayan program */

             /* 
             Console.Write("Yüksekliği giriniz:");
             int h = Convert.ToInt32(Console.ReadLine());

             Console.Write("Yarıçapı Giriniz:");
             int r = Convert.ToInt32(Console.ReadLine());
             
             double pi = 3.14;
             double hacim = pi * r * r * h;

             Console.Write("Yarıçapı: "+ r + " ve yüksekliği: " + h+ " olan Silindririn hacmi: " + hacim);
             */



            /* klavyeden girilen 2 basamaklı bir sayının basamak değerlerinin kareleri toplamını yazdır */

            /*
            Console.Write("2 basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int birler = sayi % 10;
            int onlar = sayi / 10;
            int toplam = birler * birler + onlar * onlar;
            
            Console.Write("Toplam: " + toplam);
            */


            /* klavyeden girilen 3 basamaklı bir sayının basamak değerlerinin kareleri toplamını yazdır */

            /*
            Console.Write("3 basamaklı bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
           
            int birler = sayi % 10;
            int onlar = ((sayi % 100) - birler )/10;
            int yuzler = sayi / 100;
            
            int toplam = birler * birler + onlar * onlar + yuzler * yuzler;
            
            Console.Write("Toplam: " + toplam);
            */



            /* 100 soruluk bir sınavda 4 yanlış 1 doğruyu götürsün.Kullanıcıdan yanlış ve boş değerleri al. 85 üzeriçok başarılı,70-85 arası orta seviye,
             * 55-70 idare eder, 55 altı çok kötü yazdır.*/

            /*
            Console.Write("yanlış sayısını girin:");
            int yanlis = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("boş sayısını girin:");
            int bos = Convert.ToInt32(Console.ReadLine());
            
            int dogru = 100 - bos - yanlis;
            double net = dogru - yanlis / 4;
            
            if (net >= 85)
                Console.Write("Çok Başarılı");
            
            else if ((70 <= net) && (net < 85))
                Console.Write("Orta Seviye");
            
            else if ((70 > net) && (net >= 55))
                Console.Write("İdare eder");
            
            else
                Console.Write("Çok kötü");
            */


            /* klavyeden girlen 3 kenar için eşkenar mı, ikizkenar mı, çeşit kenar mı yazdır.*/

            /*
            Console.Write("1. kenar değerini girin:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. kenar değerini girin:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("3. kenar değerini girin:");
            int c = Convert.ToInt32(Console.ReadLine());

            if ((a == b) && (a == c) && (b == c))
                Console.WriteLine("Eşkenar Üçgendir.");

            else if ((a == b) || (a == c) || (b == c))
                Console.WriteLine("İkizkenar Üçgendir.");
            
            else
                Console.WriteLine("Çeşitkenar Üçgendir.");
            */


            /* klavyeden girilen 3 sayının en küçüğünü ve en büyüğünü yazdır.*/

            /*
            Console.WriteLine("1. sayıyı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı girin:");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int enkucuk = sayi1;
            int enbuyuk = sayi2;

            if (sayi2 < enkucuk)
                enkucuk = sayi2;

            if (sayi3 < enkucuk)
                enkucuk = sayi3;

            if (sayi1 > enbuyuk)
                enbuyuk = sayi1;

            if (sayi3 > enbuyuk)
                enbuyuk = sayi3;

            Console.WriteLine("En küçük sayı: " + enkucuk + ", en büyük sayı: " + enbuyuk);
            */



            /* klavyeden girilen 5 sayının toplamını yazdır */

            /*
            int toplam = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i + ". sayıyı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }

            Console.WriteLine("Toplam değer: " + toplam);
            */


            /* klavyeden kaç adet sayı girileceğini de girdiren sayıların toplamını yazdır. */

            /*
            int toplam = 0;
            
            Console.WriteLine("Klavyeden kaç tane sayı girilecek:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i + ". sayıyı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;

            }
            Console.WriteLine("Toplam değer: " + toplam); 
            */


            /* 1 ile 100 arasındaki sayılardan 3,4,5'e tam bölünenleri yazdır. */

            /*
            for ( int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 4 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i + " sayısı 3'e, 4'e ve 5'e tam bölünür.");
                }

            }
            */


            /* ayrı ayrı bölünenleri bulalım.*/

            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i + " sayısı 3'e tam bölünür.");
                if (i % 4 == 0)
                    Console.WriteLine(i + " sayısı 4'e tam bölünür.");
                if (i % 5 == 0)
                    Console.WriteLine(i + " sayısı 5'e tam bölünür.");

            }
            */


            /* *'dan klavyeden girilen nxn boyutunda kare olşturma. */

            /*
            Console.WriteLine("Karenin n boyutunu giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            */


            /* dik üçgen oluşturma */

            /*
            Console.WriteLine("Üçgenin n boyutunu giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            } 
            */

        }
    }
}
