using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class Ogrenci : IKisiBilgileri
    {
        private string _ad;
        private string _soyad;
        private string _telefon;
        public string ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string telefon
        {
            get
            {
                return _telefon;
            }

            set
            {
                _telefon = value;// Value Sadece set değişkeni içinde kullanrılır.Gelen değeri yakalar. get de değer geri döner.Ve bi yerlerde kullanılır.
            }
        }

        public string BilgiGöster()
        {

            return string.Format("Ad: {0} \t Soyad:{1} \t Telefon:{2}", _ad, _soyad, _telefon);
        }
        public Ogrenci Dondur()
        {
            Ogrenci o = new Ogrenci();
            o.ad = ad;
            o.soyad = soyad;
            o.telefon = telefon;
            return o;
        }
    }
}
