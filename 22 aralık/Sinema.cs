using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Aralık
{
    public class Sinema
    {
        public int bakiye;
        public string salonNo;
        public int toplamKoltukSayisi;
        public int bosKoltukSayisi;
        public bool indirimliMi;
        public int Tam = 15;
        public int indirimli = 10;


        /*
        public Sinema()
        {
            Console.WriteLine("Sinema sınıfından yeni bir nesne oluşturuldu.");

        }*/

        public Sinema (string salonNo, int koltuksayisi)
        {
            this.salonNo = salonNo;
            toplamKoltukSayisi = koltuksayisi;
            bosKoltukSayisi = koltuksayisi;
            bakiye = 0;

            Console.WriteLine(salonNo + " salonunda " + koltuksayisi + " koltuk vardır.");
        }


        public void BiletSat(bool ogrenciMi)
        {

            if ( bosKoltukSayisi > 0)
            {
                if (ogrenciMi)
                {
                    bakiye = bakiye + indirimli;
                }
                else
                {
                    bakiye = bakiye + Tam;
                }

                bosKoltukSayisi = bosKoltukSayisi - 1;
            }
            else
            {
                Console.WriteLine("Bu salonda Boş koltuk kalmamıştır.");
            }
            
        }

        public int BosKoltukOgren()
        {
            return bosKoltukSayisi;
        }

        public int BakiyeOgren()
        {
            return bakiye;
        }

        public void BiletIptal(bool ogrenciMi)
        {
            if ( ogrenciMi)
            {
                bakiye = bakiye - indirimli;
            }
            else
            {
                bakiye = bakiye - Tam;
            }
            bosKoltukSayisi = bosKoltukSayisi + 1;
        }




    }
}
