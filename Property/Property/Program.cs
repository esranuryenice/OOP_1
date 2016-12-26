using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 nesne = new Class1();
            nesne.Z = 55;
            Console.WriteLine(nesne.Z);
        }
    }
}
