using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{
    class OgretmenKart:Kart
    {
        public override void Okut()
        {
            MessageBox.Show("2 TL alındı.Kalan Bakiye: "+(bakiye-2));
            bakiye -= 2;
        }
    }
}
