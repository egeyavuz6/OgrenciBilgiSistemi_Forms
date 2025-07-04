using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Admin
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }


        public Admin(string kullaniciAdi, string sifre)
        {
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }

        public bool GirisYap(string kullaniciAdi, string sifre)
        {
            return KullaniciAdi == kullaniciAdi && Sifre == sifre;
        }
    }
}
