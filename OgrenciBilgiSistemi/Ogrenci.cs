using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Ogrenci
    {
        public int Id { get; set; }  //Primary Key
        public string OgrenciNo { get; set; } 
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public ICollection<Grade> Notlar { get; set; } = new List<Grade>();
        public void NotEkle(double notDegeri)
        {
            Notlar.Add(new Grade { Deger = notDegeri, OgrenciId = this.Id });
        }

        public double OrtalamaHesapla()
        {
            if (Notlar == null || Notlar.Count == 0) return 0;
            return Notlar.Average(n => n.Deger);
        }
    }



}
