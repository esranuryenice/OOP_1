using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class Haberler
    {
        public string haber { get; set; }
       
        public Haberler(string haber )
        {
            this.haber = haber;
           
          
        }
        public override string ToString()
        {
            return this.haber ;
            
        }
    }
}
