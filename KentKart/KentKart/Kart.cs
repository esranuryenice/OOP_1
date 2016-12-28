using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart
{
   public enum yolcutipi
    {
        ogrenci,
        ogretmen,
        tam
    }


   public class Kart
    {
        private double _bakiye;

        public double bakiye

        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value < 0)
                {
                    System.Windows.Forms.MessageBox.Show("Bakiye Yetersiz!!!");
                }
                else
                {
                    _bakiye = value;
                }

            }
        }
        public int KartID { get; set; }
        public yolcutipi kartturu { get; set; }
        


        public virtual void Okut()
        {
            MessageBox.Show("Biniş Başarılı! Kalan Bakiye :" + (bakiye - 3));
            bakiye -= 3;
        }
        public override string ToString()
        {
            return this.KartID + "\t" + this.bakiye + "\t" +"\t"+this.kartturu;
        }
    }
}




