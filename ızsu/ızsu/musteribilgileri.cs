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
        public double toplamodeme;
        public double OdemeHesapla(double onceki, double sonraki, string aboneTuru)
        {

            double result = 0;
            double toplamödeme;

            if (aboneTuru == "EV")
            {
                toplamödeme = (sonraki - onceki) * 0.3;
                result++;
            }
            else
            {
                result = (sonraki - onceki) * 0.5;
                result++;
            }
            return result;
        }
        
	
    
       public override string ToString()
        {
            return this.AboneNo; 
        }
    }
}
