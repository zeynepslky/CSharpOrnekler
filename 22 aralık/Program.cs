using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Aralık
{
    class Program
    {


        static void Main(string[] args)
        {

            /*
            Ogrenci ogrenci = new Ogrenci();
            //ogrenci.ad = "Zeynep";
            // ogrenci.soyad = "ÇELİK";
            //ogrenci.numara = 123456789;

            ogrenci.Ekle("Zeynep", "ÇELİK", 123456789);

            Ogrenci ogrenci1 = new Ogrenci();


            Console.WriteLine(ogrenci.ad + " " + ogrenci.soyad + " " + ogrenci.numara);


            Console.WriteLine(ogrenci1.ad + " " + ogrenci1.soyad + " " + ogrenci1.numara);
            */


            /*
            Kopek kopek = new Kopek();

            kopek.Ekle("Zift", "Siyah", "Anadolu Çoban Köpeği", true);

            Kopek kopek1 = new Kopek();
            kopek1.Ekle("Pars", "Kahverengi", "Malinois", false);

            kopek.KopekGetir(); 
            kopek.Havla();        
            kopek.kuyrukSalla();
            
            kopek1.KopekGetir();
            kopek1.Havla();
            kopek1.kuyrukSalla();
            */



            Sinema s = new Sinema("Salon 1",40);

            s.BiletSat(false);
            s.BiletSat(true);
            s.BiletSat(true);
            s.BiletSat(true);
            s.BiletSat(false);
            s.BiletSat(false);

            Console.WriteLine("Bakiye: " + s.BakiyeOgren());
            Console.WriteLine("Boş koltuk sayısı: " + s.bosKoltukSayisi);

            s.BiletIptal(false);
            s.BiletIptal(true);

            Console.WriteLine("Bakiye: " + s.BakiyeOgren());
            Console.WriteLine("Boş koltuk sayısı: " + s.bosKoltukSayisi);



            /* ödev otobüs bileti satma yap */





        }
    }
}
