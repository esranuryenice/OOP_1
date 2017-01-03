using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class baraj
    {
        public string ad { get; set; }
        public string doluluk { get; set; }
        public static  DateTime tarih { get; set; }
        public baraj(string ad,string doluluk)
        {
            this.ad = ad;
            this.doluluk = doluluk;
        }

        public override string ToString()
        {
            return this.ad + "\t" + "\t" + this.doluluk;
        }
    }
}
