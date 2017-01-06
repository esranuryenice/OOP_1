using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınav
{
    class siparis
    {
        public string siparisadi { get; set; }
        public int adet { get; set; }
       public double adetucret { get; set; }
        
     public double ucret
        {
            get
           {
                if (siparisadi=="Kuru Fasulye")
                {
                    return 5;
                }
               else if (siparisadi == "Tavuklu Pilav")
                {
                    return 6;
                }
                else if (siparisadi == "Kaşarlı Tost")
                {
                    return 4;
                }
                else if (siparisadi == "Lazanya")
                {
                    return 2;
                }
                else if (siparisadi == "Su")
                {
                    return 1;
                }
                else if (siparisadi == "Kola")
                {
                    return 3;
                }
                else if (siparisadi == "Çay")
                {
                    return 1.5;
                }
                else if (siparisadi == "Limonata")
                {
                    return 3.5;
                }
               
                else if (siparisadi == "Kahve")
                {
                    return 4;
                }
                return 0;

            }

 }
        public override string ToString()
        {
            return siparisadi + " " + adet + "adet";
        }




















    }
}
