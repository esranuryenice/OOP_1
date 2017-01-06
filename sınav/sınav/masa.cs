using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınav
{
    class masa
    {
        public double hesapla { get; set; }
        public List<siparis> siparisler = new List<siparis>();
        public masa()
        {
            siparisler = new List<siparis>();
        }
    }
}
