﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomobil_OOP
{
    class Honda:Otomobil
    
    {
        public Honda()
        {
            seri = " vtec";
            model = "s2000";
            MotorGucu =250 ;
            MotorHacmi = 2000;
        }
        public override string Calistir()
        {
            return "honda hayat onda";
        }
    }
}
