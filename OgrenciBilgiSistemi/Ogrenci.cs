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
        public string password { get; set; } // Password for student logins
        public ICollection<Grade> Notlar { get; set; } = new List<Grade>();
        public void NotEkle(double notDegeri, string courseId)
        {
            Notlar.Add(new Grade { Grades = notDegeri, OgrenciId = this.Id, CourseId = courseId });
        }

    }



}
