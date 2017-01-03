using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Su_Kesintileri
    {
        public string ilceadi { get; set; }
        public string mahalleler { get; set; }
        public Su_Kesintileri(string ilceadi)
        {
            this.ilceadi = ilceadi;
           
        }
        public override string ToString()
        {
            return this.ilceadi + "\n" + this.mahalleler;
        }
    }
}
