﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Class1
    {
        public int X;
        public int Y { get; set; }
        public int _z;
        public int Z
        {
            get
            {
                return _z;
            }
            set
            {
                if (value > 81||  value <1)
                {

                }
                else
                {

                    _z = value;
                }
            }
            

        }
    
    }
   
}
