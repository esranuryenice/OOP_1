﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Tofas:Otomobil
    {
        public Tofas()
        {
            seri = "Serçe";
            model = "Murat 131";
            MotorGucu = 65;
            MotorHacmi = 1400;
        }
        public override string Calistir()
        {
            return "Tır Tır";
            
        }
    }
}
