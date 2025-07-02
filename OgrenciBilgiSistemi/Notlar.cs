using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    internal class Notlar : OBS
    {
        public List<int> notlist { get; set; }
        public int ortalama { get; set; }

        public void NotEkle(int notDegeri)
        {
            if (notlist == null)
            {
                notlist = new List<int>();
            }
            notlist.Add(notDegeri);
        }
        public double OrtalamaHesapla()
        {
            if (notlist == null || notlist.Count == 0)
            {
                return 0;
            }
            return notlist.Average();
        }
    }
}
