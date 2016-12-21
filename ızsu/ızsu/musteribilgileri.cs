using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ızsu

{
  public class musteribilgileri
    {
        public string AboneNo;
        public string AdSoyad;
        public int OncekiSayac;
        public int SonrakiSayac;
        public string AboneTuru;

        public double OdemeHesapla(double onceki, double sonraki, string aboneTuru)
        {
            double result = 0;
            if (aboneTuru=="EV")
            {
                result = (sonraki - onceki) * 0.3;
            }
            else
            {
                result = (sonraki - onceki) * 0.5;
            }
            return result;

        }
        public override string ToString()
        {
            return this.AboneNo; 
        }
    }
}
