using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Porsche:Otomobil
    {
        public Porsche()
        {
            seri = "GT";
            model = "911";
            MotorGucu = 400;
            MotorHacmi = 3000;
        }
        public override string Calistir()
        {
            return "Vrom vrom";
        }
    }
   
}
