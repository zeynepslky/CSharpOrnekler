using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Aralık
{
    public class Ogrenci
    {
        public int numara;
        public string ad;
        public string soyad;

        public void Ekle(string ad, string soyad, int numara)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.numara = numara;
        }


    }





}
