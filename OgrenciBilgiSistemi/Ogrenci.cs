using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class Ogrenci : OBS
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int ID { get; set; }
            
        public Ogrenci(String isim, String soyisim, int ID) {
            this.isim = isim;
            this.soyisim = soyisim;
            this.ID = ID;
        }
    }
}
