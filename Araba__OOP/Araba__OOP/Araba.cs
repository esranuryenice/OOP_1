using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba__OOP
{
    class Araba
    {
        public int yakitDepoKapasite { get; set; }
        public double ortamalaTuketim100km { get; set; }
        public static double yakitFİyat { get; set; }
        public double ToplamYol
        {
            get
            {
                return (yakitDepoKapasite / ortamalaTuketim100km) * 100;
            }


        }
        public double UcretHesaplama(double km)
        {
            return km * (ortamalaTuketim100km / 100) * yakitFİyat;

        }
        public Araba(int yakitkapasite,double ortalama100km)
        {
            this.ortamalaTuketim100km = ortalama100km;
            this.yakitDepoKapasite = yakitkapasite;
        }
       
    }
}
