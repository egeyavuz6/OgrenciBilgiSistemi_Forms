using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ogrenci
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int ID { get; set; }
        public List<int> notlar { get; set; } = new List<int>();

        public void NotEkle(int notDegeri)
        {
            notlar.Add(notDegeri);
        }

        public double OrtalamaHesapla()
        {
            if (notlar.Count == 0) return 0;
            return notlar.Average();
        }
    }
}
