using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class OgretimGorevlisi : IKisiBilgileri,ICalisanBİlgileri
    {
        private string _ad;
        private string _soyad;
        private string _telefon;
        private string _bolum;
        private string _gorevi;
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
       
        public string bolumu
        {
            get
            {
                return _bolum;
            }

            set
            {
                _bolum = value;
            }
        }
       
        public string gorevi
        {
            get
            {
                return _gorevi;
            }

            set
            {
                _gorevi = value;
            }
        }

       

        public string BilgiGöster()
        {
            return string.Format("Ad: {0} \t Soyad:{1} \t Telefon:{2} \t  \t Bölümü {3} Görevi{4}", _ad, _soyad, _telefon, _bolum,_gorevi);
        }
    }
}
