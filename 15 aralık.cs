using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Hesap makinesi yapma */

            /* Console.WriteLine("Hesap Makinesi");
            Console.WriteLine("*********************");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            Console.WriteLine("Gerçekleştirmek istediğiniz işlemi seçin (1-4):");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Write("1. sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            double sonuc;

            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sayi1 + " + " + sayi2 + " = " + sonuc);
                    break;

                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine(sayi1 + " - " + sayi2 + " = " + sonuc);
                    break;

                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine(sayi1 + " * " + sayi2 + " = " + sonuc);
                    break;

                case 4:
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + sonuc);
                    break;

                default:
                    Console.Write("Geçersiz bir seçim yaptınız");
                    break;

            } */


            /* kullanıcıdan fiyatı alınan bir ürünün türüne göre vergisini hesaplama. kitap = 0.04, temel gıda= 0.056, lüks ürün = 0.1 */

            /* Console.WriteLine("Vergi hesaplama");
            Console.WriteLine("*********************");
            Console.WriteLine("1. Kitap");
            Console.WriteLine("2. Temel Gıda");
            Console.WriteLine("3. Lüks Ürün");

            Console.WriteLine("Gerçekleştirmek istediğiniz işlemi seçin (1-3):");
            int secim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ürünün fiyatını giriniz:");
            double fiyat = Convert.ToInt32(Console.ReadLine());

            double vergi;

            switch (secim)
            {
                case 1:
                    vergi = fiyat * 0.04;
                    Console.WriteLine(fiyat + " olan ürünün vergisi " + vergi);
                    break;

                case 2:
                    vergi = fiyat * 0.056;
                    Console.WriteLine(fiyat + " olan ürünün vergisi " + vergi);
                    break;

                case 3:
                    vergi = fiyat * 0.1;
                    Console.WriteLine(fiyat + " olan ürünün vergisi " + vergi);
                    break;

                default:
                    Console.Write("Geçersiz bir seçim yaptınız");
                    break;

            } */


            /*  klavyeden girilen  sayıların toplamı 50'yi geçince duran ve toplam değer ile kaç adet sayı girildiğini yazdıran program */
            /*
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            int toplam = 0, sayi, sayac = 0;

            while ( toplam < 50 )
            {
                Console.Write("sayı giriniz:");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
                sayac++;
            }

            Console.Write("Toplam = " + toplam + " , " + sayac + " adet sayı girildi: ");
            */


            /* sayı tahmin oyunu */

            /* Random random = new Random();
            int tahmin;
            int sayi = random.Next(100);

            // Console.WriteLine(sayi);

            while (true)
            {
                Console.Write("Sayı giriniz:");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (sayi > tahmin)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                }

                else if (sayi < tahmin)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                }
                else
                {
                    Console.WriteLine("Tebrikler");
                    Console.WriteLine("Sayı: " + sayi);
                    break;
                }

            } */


            /* sayı tahmin oyunu fakat 5 hak olsun */

            /*
            Random random = new Random(); 
            int tahmin;
            int sayi = random.Next(100);
            int hak = 5;

            while (true)
            {
                Console.WriteLine(hak + " hakkınız kaldı");
                hak --;

                if (hak < 0)
                {
                    Console.WriteLine("Hakınızı kaybettiniz.");
                    break;
                }

                Console.Write("Sayı giriniz:");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (sayi > tahmin)
                {
                    Console.WriteLine("Daha büyük bir sayı girin");
                }

                else if (sayi < tahmin)
                {
                    Console.WriteLine("Daha küçük bir sayı girin");
                }
                else
                {
                    Console.WriteLine("Tebrikler");
                    Console.WriteLine("Sayı: " + sayi);
                    break;
                }
            }
            */



            /* array - dizi */


            /*string[] sehirler = new string[3]; // {"Düzce","Ankara","İstanbul"}
            sehirler[0] = "Düzce";
            sehirler[1] = "Ankara";
            sehirler[2] = "İstanbul";
            Console.WriteLine(sehirler[1]);

            for ( int i = 0; i <sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            } */

            /* 
            Console.WriteLine("Dizi kaç boyutlu olacak?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];


            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("Diziye bir eleman ekle");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Oluşturulan dizi:");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(sayilar[j]);
            }
            */


            /* oluşturulan dizinin elemanlarının toplamını ve ortalamasını bulduram programı yaz */


            /* Console.WriteLine("Dizi kaç boyutlu olacak?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[n];
            double ortalama = 0.0, toplam = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Diziye bir eleman ekle");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayilar[i];
            }
            Console.WriteLine("Oluşturulan dizi:");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(sayilar[j]);
            }

            ortalama = toplam / n;
            Console.WriteLine("Toplam: " + toplam);
            Console.WriteLine("Ortalama:" + ortalama); */


            /* Oluşturulan dizinin en küçük ve en büyük lemenını yazdıran program */ 


        }
    }
}
