using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapıcımetod
{
    class Oyuncu
    {
        public string adi;
        public string takim;
        public byte formaNo;
        public string pozisyon;

        public Oyuncu(string ad)
        {
            adi = ad;
        }
        public Oyuncu(string ad,string takimi)
        {
            adi = ad;
            takim = takimi;
        }
    }
}
