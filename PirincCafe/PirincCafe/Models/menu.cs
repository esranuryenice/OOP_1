using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirincCafe.Models
{
    class menu
    {
        public List<AnaYemek> anayemekler { get; set; }
        public List<Salata> salatalar { get; set; }
        public List<Tatli> tatli { get; set; }
    }
}
