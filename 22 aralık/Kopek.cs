using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Aralık
{
    public class Kopek
    {
        public string ad;
        public string rengi;
        public string cins;
        public bool aclikDurumu;

        public void Ekle (string ad, string rengi, string cins, bool aclikDurumu)
        {
            this.ad = ad;
            this.rengi = rengi;
            this.cins = cins;
            this.aclikDurumu = aclikDurumu;
        }

        public void KopekGetir()
        {
            Console.WriteLine(ad + " " + rengi + " " + cins + " " + aclikDurumu);
        }

        public void Havla()
        {
            Console.WriteLine("hav hav hav");
        }

        public void kuyrukSalla()
        {
            Console.WriteLine("Kuyruk sallıyor !!!");
        }

    }
}
